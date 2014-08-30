using System;
using LibGD;

public static class GlobalMembersGdnametest
{
    private const int WIDTH = 50;
    private const int HEIGHT = 50;
    private const int LX = (WIDTH/2);    // Line X
    private const int LY = (HEIGHT/2);   // Line Y
    private const int HT = 2;            // Half of line-thickness

	public static gdImageStruct mkwhite(int x, int y)
	{
		gdImageStruct im;

		im = gd.gdImageCreateTrueColor(x, y);
		gd.gdImageFilledRectangle(im, 0, 0, x - 1, y - 1, gd.gdImageColorExactAlpha(im, 255, 255, 255, 0));

        GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", (im != null) ? 1 : 0);

		gd.gdImageSetInterpolationMethod(im, gdInterpolationMethod.GD_BICUBIC); // FP interp'n

		return im;
	} // mkwhite


	public static gdImageStruct mkcross()
	{
		gdImageStruct im;
		int fg;
		int n;

		im = GlobalMembersGdnametest.mkwhite(WIDTH, HEIGHT);
		fg = gd.gdImageColorAllocate(im, 0, 0, 0);

		for (n = -HT; n < HT; n++)
		{
			gd.gdImageLine(im, WIDTH / 2 - n, 0, WIDTH / 2 - n, HEIGHT - 1, fg);
			gd.gdImageLine(im, 0, HEIGHT / 2 - n, WIDTH - 1, HEIGHT / 2 - n, fg);
		} // for

		return im;
	} // mkcross

    private struct Name
    {
        public readonly string nm; // Filename
        public readonly uint maxdiff; // Maximum total pixel diff
        public readonly int required; // 1 -> image type always supported, -1 -> skip it
        public readonly int @readonly; // 1 -> gd can only read this type

        public Name(string nm, uint maxdiff, int required, int @readonly) : this()
        {
            this.nm = nm;
            this.maxdiff = maxdiff;
            this.required = required;
            this.@readonly = @readonly;
        }
    }


	public static void do_test()
	{
		int n;
//C++ TO C# CONVERTER TODO TASK: C# does not allow declaring types within methods:
	//	struct
	//	{
	//		string nm; // Filename
	//		uint maxdiff; // Maximum total pixel diff
	//		int required; // 1 -> image type always supported, -1 -> skip it
	//		int @readonly; // 1 -> gd can only read this type
	//	}
		Name[] names = {
			new Name("img.png", 0, 0, 0),
			new Name("img.gif", 5, 1, 0), // This seems to come from tc<->palette
			new Name("img.GIF", 5, 1, 0), // Test for case insensitivity
			new Name("img.gd", 0, 1, 0),
			new Name("img.gd2", 0, 0, 0),
			new Name("img.jpg", 25, 0, 0),
			new Name("img.jpeg", 25, 0, 0),
			new Name("img.wbmp", 0, 1, 0),
			new Name("img.bmp", 0, 1, 0),
			new Name("img-ref.xpm", 0, 0, 1),

			// These break the test so I'm skipping them since the point
			// of this test is not those loaders.
			new Name("img-ref.xbm", 0, -1, 1),
			new Name("img-ref.tga", 0, -1, 1),
			new Name("img.webp", 0, -1, 0),
			new Name("img.tiff", 0, -1, 0),

			new Name(null, 0, 0, 0)
		};

		for (n = 0; names[n].nm; n++)
		{
			gdImageStruct orig;
			gdImageStruct copy;
			int status;
			string full_filename = new string(new char[255]);

			/* Some image readers are buggy and crash the program so we
			 * skip them.  Bug fixers should remove these from the list of
			 * skipped items as bugs are fixed. */
			if (names[n].required < 0)
			{
				Console.Write("Skipping test for '{0}'.  FIX THIS!\n", names[n].nm);
				continue;
			} // if

			/* Skip this file if the current library build doesn't support
			 * it.  (If it's one of the built-in types, *that* a different
			 * problem; we assert that here.) */
			if (!gd.gdSupportsFileType(names[n].nm, 0))
			{
	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
				GlobalMembersGdtest._gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (!names[n].required));
				continue;
			} // if

			orig = GlobalMembersGdnametest.mkcross();

			/* Prepend the test directory; this is expected to be run in
			 * the parent dir. */
			snprintf(full_filename, sizeof(sbyte), "gdimagefile/%s", names[n].nm);

			/* Write the image unless writing is not supported. */
			if (!names[n].@readonly)
			{
				gd.gdImageFile(orig, full_filename);
			} // if

			copy = gd.gdImageCreateFromFile(full_filename);
	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
			GlobalMembersGdtest._gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (!copy == null));
			if (copy == null)
				continue;

			/* Debug printf. */
			//printf("%s -> %d\n", full_filename, gd.gdMaxPixelDiff(orig, copy));

	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
			GlobalMembersGdtest._gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (GlobalMembersGdtest.gd.gdMaxPixelDiff(orig, copy) <= names[n].maxdiff));

			if (!names[n].@readonly)
			{
				status = remove(full_filename);
	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
				GlobalMembersGdtest._gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (status == 0));
			} // if

			gd.gdImageDestroy(orig);
			gd.gdImageDestroy(copy);
		} // for

	} // do_test


	public static void do_errortest()
	{
		gdImageStruct im;

		im = GlobalMembersGdnametest.mkcross();

	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
		GlobalMembersGdtest._gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (!gd.gdImageFile(im, "img.xpng")));
	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
		GlobalMembersGdtest._gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (!gd.gdImageFile(im, "bobo")));
	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
		GlobalMembersGdtest._gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (!gd.gdImageFile(im, "png")));
	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
		GlobalMembersGdtest._gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (!gd.gdImageFile(im, "")));

		gd.gdImageDestroy(im);
	} // do_errortest


	static int Main(string[] args)
	{

		GlobalMembersGdnametest.do_test();
		GlobalMembersGdnametest.do_errortest();

		return GlobalMembersGdtest.gd.gdNumFailures();
	}
}

