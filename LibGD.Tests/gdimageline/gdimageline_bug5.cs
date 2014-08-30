using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersGdimageline_bug5
{
    [Test]
    public void TestGdImageLine_bug5()
	{
		/* Declare the image */
		gdImageStruct im;
		gdImageStruct @ref;

		/* Declare output files */
		/* FILE *pngout; */
		int black;
		int white;

		im = gd.gdImageCreateTrueColor(63318, 771);

		/* Allocate the color white (red, green and blue all maximum). */
		white = gd.gdImageColorAllocate(im, 255, 255, 255);
		/* Allocate the color white (red, green and blue all maximum). */
		black = gd.gdImageColorAllocate(im, 0, 0, 0);

		/* white background */
		gd.gdImageFill(im, 1, 1, white);

		/* Make a reference copy. */
		@ref = gd.gdImageClone(im);

		gd.gdImageSetAntiAliased(im, black);

		/* This line used to fail. */
		gd.gdImageLine(im, 28562, 631, 34266, 750, GlobalMembersGdtest.DefineConstants.gdAntiAliased);

		GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", (GlobalMembersGdtest.gdMaxPixelDiff(im, @ref) > 0) ? 1 : 0);

	#if false
	//    {
	//        FILE *pngout;
	//
	// /* Open a file for writing. "wb" means "write binary",
	//  * important under MSDOS, harmless under Unix. */
	//        pngout = fopen("test.png", "wb");
	//
	// /* Output the image to the disk file in PNG format. */
	//        gd.gdImagePng(im, pngout);
	//
	// /* Close the files. */
	//        fclose(pngout);
	//    }
	#endif

		/* Destroy the image in memory. */
		gd.gdImageDestroy(im);
		gd.gdImageDestroy(@ref);

		Assert.AreEqual(0, GlobalMembersGdtest.gdNumFailures());
	}
}

