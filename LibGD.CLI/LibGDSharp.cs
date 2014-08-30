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
        private readonly string includeDir;
        private readonly string systemIncludeDir;
        private readonly string libraryFile;

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
            driver.Options.NoBuiltinIncludes = true;
            driver.Options.MicrosoftMode = false;
            driver.Options.TargetTriple = "i686-w64-mingw32";
            driver.Options.Abi = CppAbi.Itanium;
            driver.Options.LibraryName = "LibGDSharp";
            driver.Options.OutputNamespace = "LibGD";
            driver.Options.Verbose = true;
            driver.Options.IgnoreParseWarnings = true;
            driver.Options.CheckSymbols = true;
            driver.Options.Headers.AddRange(Directory.EnumerateFiles(this.includeDir, "*.h"));
            driver.Options.SystemIncludeDirs.Add(this.systemIncludeDir);
            driver.Options.IncludeDirs.Add(includeDir);
            driver.Options.LibraryDirs.Add(Path.GetDirectoryName(this.libraryFile));
            driver.Options.Libraries.Add(Path.GetFileName(this.libraryFile));
            string dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            driver.Options.CodeFiles.Add(Path.Combine(dir, "_iobuf.cs"));
        }

        public void SetupPasses(Driver driver)
        {
        }
    }
}
