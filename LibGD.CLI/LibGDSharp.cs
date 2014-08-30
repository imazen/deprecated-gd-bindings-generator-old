using System;
using System.IO;
using System.Linq;
using System.Reflection;
using CppSharp;
using CppSharp.AST;
using CppSharp.AST.Extensions;
using CppSharp.Generators;

namespace LibGD.CLI
{
    public class LibGDSharp : ILibrary
    {
        private  string includeDir;
        private  string systemIncludeDir;
        private  string libraryFile;

        public LibGDSharp(string includeDir, string systemIncludeDir, string libraryFile)
        {
            this.includeDir = includeDir;
            this.systemIncludeDir = systemIncludeDir;
            this.libraryFile = libraryFile;
        }

        public void Preprocess(Driver driver, ASTContext ctx)
        {
            var gd = driver.ASTContext.TranslationUnits.FirstOrDefault(t => t.FileName == "gd.h");
            if (gd != null)
            {
                foreach (var field in gd.FindClass("gdSink").Fields)
                {
                    FunctionType functionType;
                    if (field.Type.IsPointerTo(out functionType))
                    {
                        field.ExplicityIgnored = true;
                    }
                }
                foreach (var field in gd.FindClass("gdSource").Fields)
                {
                    FunctionType functionType;
                    if (field.Type.IsPointerTo(out functionType))
                    {
                        field.ExplicityIgnored = true;
                    }
                }
            }
            var gdIO = driver.ASTContext.TranslationUnits.FirstOrDefault(t => t.FileName == "gd_io.h");
            if (gdIO != null)
            {
                foreach (var field in gdIO.FindClass("gdIOCtx").Fields)
                {
                    FunctionType functionType;
                    if (field.Type.IsPointerTo(out functionType))
                    {
                        field.ExplicityIgnored = true;
                    }
                }
            }
        }

        public void Postprocess(Driver driver, ASTContext lib)
        {
        }

        public void Setup(Driver driver)
        {
            driver.Options.GeneratorKind = GeneratorKind.CSharp;
            driver.Options.Is32Bit = true;
            driver.Options.NoBuiltinIncludes = false;
            driver.Options.MicrosoftMode = true;
            //driver.Options.TargetTriple = "i686-w64-mingw32";
            driver.Options.Abi = CppAbi.Microsoft;
            driver.Options.LibraryName = "LibGDSharp";
            driver.Options.OutputNamespace = "LibGD";
            driver.Options.Verbose = true;
            driver.Options.IgnoreParseWarnings = true;
            driver.Options.CheckSymbols = true;


            string projDir = @"C:\Users\nathanael\Documents\gd-libgd\";
            this.includeDir = projDir + @"\src";
            driver.Options.Headers.AddRange(Directory.EnumerateFiles(this.includeDir, "*.h"));


            driver.Options.SystemIncludeDirs.Add(@"C:\Program Files (x86)\Microsoft Visual Studio 12.0\VC\INCLUDE");
            driver.Options.SystemIncludeDirs.Add(@"C:\Program Files (x86)\Microsoft Visual Studio 12.0\VC\ATLMFC\INCLUDE");
            driver.Options.SystemIncludeDirs.Add(@"C:\Program Files (x86)\Windows Kits\8.1\include\shared");
            driver.Options.SystemIncludeDirs.Add(@"C:\Program Files (x86)\Windows Kits\8.1\include\um");
            driver.Options.SystemIncludeDirs.Add(@"C:\Program Files (x86)\Windows Kits\8.1\include\winrt");



            driver.Options.IncludeDirs.Add(this.includeDir);

            driver.Options.IncludeDirs.Add(projDir + @"deps\include");
            driver.Options.IncludeDirs.Add(@"C:\Users\nathanael\Documents\gd-libgd\deps\include\freetype");
            driver.Options.IncludeDirs.Add(@"C:\Users\nathanael\Documents\gd-libgd\deps\include\libpng15");
            driver.Options.IncludeDirs.Add(@"C:\Users\nathanael\Documents\gd-libgd\deps\include\vpx");


            this.libraryFile = @"C:\Users\nathanael\Documents\gd-libgd\Release_GD\static\libgd.lib";
            driver.Options.LibraryDirs.Add(Path.GetDirectoryName(this.libraryFile));
            driver.Options.LibraryDirs.Add(projDir + @"deps\lib");

            driver.Options.Libraries.Add(Path.GetFileName(this.libraryFile));


            string dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            driver.Options.CodeFiles.Add(Path.Combine(dir, "_iobuf.cs"));
        }

        public void SetupPasses(Driver driver)
        {
        }
    }
}
