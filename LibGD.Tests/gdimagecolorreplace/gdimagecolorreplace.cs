using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersGdimagecolorreplace
{
	internal static int callback(IntPtr imPtr, int src)
	{
		int r;
		int g;
		int b;

        var im = new gdImageStruct(imPtr);
		r = ((im).trueColor != 0 ? (((src) & 0xFF0000) >> 16) : (im).red[(src)]);
		g = ((im).trueColor != 0 ? (((src) & 0x00FF00) >> 8) : (im).green[(src)]);
		b = ((im).trueColor != 0 ? ((src) & 0x0000FF) : (im).blue[(src)]);
		if ((b & 0xFF) != 0)
		{
			return gd.gdImageColorResolve(im, 0x0F & r, 0x0F & g, 0);
		}
		else
		{
			return -1;
		}
	}

	internal static unsafe void run_tests(gdImageStruct im, ref int error)
	{
		int black;
		int white;
		int cosmic_latte;
		int cream;
		int ivory;
		int magnolia;
		int old_lace;
		int seashell;
		int yellow;
		int c;
		int d;
		int[] src = new int[2];
		int[] dst = new int[2];
		int n;

		black = gd.gdImageColorAllocateAlpha(im, 0, 0, 0, GlobalMembersGdtest.DefineConstants.gdAlphaOpaque);
		white = gd.gdImageColorAllocateAlpha(im, 0xFF, 0xFF, 0xFF, GlobalMembersGdtest.DefineConstants.gdAlphaOpaque);
		cosmic_latte = gd.gdImageColorAllocateAlpha(im, 0xFF, 0xF8, 0xE7, GlobalMembersGdtest.DefineConstants.gdAlphaOpaque);
		cream = gd.gdImageColorAllocateAlpha(im, 0xFF, 0xFD, 0xD0, GlobalMembersGdtest.DefineConstants.gdAlphaOpaque);
		ivory = gd.gdImageColorAllocateAlpha(im, 0xFF, 0xFF, 0xF0, GlobalMembersGdtest.DefineConstants.gdAlphaOpaque);
		magnolia = gd.gdImageColorAllocateAlpha(im, 0xF8, 0xF4, 0xFF, GlobalMembersGdtest.DefineConstants.gdAlphaOpaque);
		old_lace = gd.gdImageColorAllocateAlpha(im, 0xFD, 0xF5, 0xE6, GlobalMembersGdtest.DefineConstants.gdAlphaOpaque);
		seashell = gd.gdImageColorAllocateAlpha(im, 0xFF, 0xF5, 0xEE, GlobalMembersGdtest.DefineConstants.gdAlphaOpaque);
		yellow = gd.gdImageColorAllocateAlpha(im, 0xFF, 0xFF, 0, GlobalMembersGdtest.DefineConstants.gdAlphaOpaque);

		c = gd.gdImageColorAllocate(im, 0xFF, 0, 0xFF);
		gd.gdImageFilledRectangle(im, 0, 0, 4, 4, white);
		gd.gdImageFilledRectangle(im, 0, 0, 3, 3, black);
		n = gd.gdImageColorReplace(im, white, c);

	    CheckValue(n, 9);
	    CheckPixel(im, 0, 0, black);
	    CheckPixel(im, 2, 3, black);
	    CheckPixel(im, 4, 4, c);

		gd.gdImageSetClip(im, 1, 1, 3, 3);
		n = gd.gdImageColorReplace(im, black, c);
        CheckValue(n, 9);
	    CheckPixel(im, 0, 0, black);
	    CheckPixel(im, 2, 3, c);

		src[0] = black;
		src[1] = c;
		dst[0] = c;
		dst[1] = white;
        gd.gdImageSetClip(im, 0, 0, 4, 4);
        fixed (int* srcPtr = src)
        {
            fixed (int* dstPtr = dst)
            {
                n = gd.gdImageColorReplaceArray(im, 2, srcPtr, dstPtr);
            }
        }
	    CheckValue(n, 25);
	    CheckPixel(im, 0, 0, c);
	    CheckPixel(im, 2, 3, white);
	    CheckPixel(im, 4, 4, white);

	    fixed (int* srcPtr = src)
	    {
	        fixed (int* dstPtr = dst)
	        {
                n = gd.gdImageColorReplaceArray(im, 0, srcPtr, dstPtr);	            
	        }
	    }
        CheckValue(n, 0);
        fixed (int* srcPtr = src)
        {
            fixed (int* dstPtr = dst)
            {
                n = gd.gdImageColorReplaceArray(im, -1, srcPtr, dstPtr);
            }
        }
        CheckValue(n, 0);
        fixed (int* srcPtr = src)
        {
            fixed (int* dstPtr = dst)
            {
                n = gd.gdImageColorReplaceArray(im, int.MaxValue, srcPtr, dstPtr);
            }
        }
	    CheckValue(n, -1);

		gd.gdImageSetClip(im, 1, 1, 4, 4);
		n = gd.gdImageColorReplaceCallback(im, GlobalMembersGdimagecolorreplace.callback);
	    CheckValue(n, 16);
	    CheckPixel(im, 0, 0, c);
	    CheckPixel(im, 0, 4, white);
		d = gd.gdImageColorExact(im, 0x0F, 0x0F, 0);
		if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", (d > 0) ? 1 : 0) != 1)
		{
			error = -1;
		}
	    CheckPixel(im, 2, 3, d);
	    CheckPixel(im, 4, 4, d);

		gd.gdImageSetClip(im, 0, 0, 4, 4);
        gd.gdImageFilledRectangle(im, 0, 0, 4, 4, black);
        gd.gdImageFilledRectangle(im, 1, 1, 3, 3, white);
        gd.gdImageSetPixel(im, 1, 1, cosmic_latte);
        gd.gdImageSetPixel(im, 1, 2, cream);
        gd.gdImageSetPixel(im, 2, 1, ivory);
        gd.gdImageSetPixel(im, 2, 2, magnolia);
        gd.gdImageSetPixel(im, 3, 1, old_lace);
        gd.gdImageSetPixel(im, 3, 2, seashell);
		n = gd.gdImageColorReplaceThreshold(im, white, yellow, 2);
	    CheckValue(n, 9);
	    CheckPixel(im, 0, 0, black);
	    CheckPixel(im, 1, 1, yellow);
	    CheckPixel(im, 2, 2, yellow);
	    CheckPixel(im, 3, 3, yellow);
	}

    [Test]
    public void TestGdImageColorReplace()
	{
		gdImageStruct im;
		int error = 0;

        //gd.gdSetErrorMethod(GlobalMembersGdtest.gdSilence);

		/* true color */
		im = gd.gdImageCreateTrueColor(5, 5);
		run_tests(im, ref error);
		gd.gdImageDestroy(im);

		/* palette */
		im = gd.gdImageCreate(5, 5);
		run_tests(im, ref error);
		gd.gdImageDestroy(im);

        if (error != 0)
        {
            Assert.Fail("Error: {0}", error);
        }
	}

    private static void CheckValue(int n, int expected)
    {
        do
        {
            if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__,
                                                 "assert failed in <%s:%i>\n", ((n) == (expected)) ? 1 : 0) != 1)
            {
                Assert.Fail("{0:D} is expected, but {1:D}\n", expected, n);
            }
        } while (false);
    }

    private static void CheckPixel(gdImageStruct im, int x, int y, int expected)
    {
        do
        {
            gd.gdImageSetClip(im, 0, 0, 4, 4);
            var c = gd.gdImageGetPixel(im, x, y);
            if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__,
                                                 "assert failed in <%s:%i>\n", (c == (expected)) ? 1 : 0) != 1)
            {
                Assert.Fail("{0:D} is expected, but {1:D}\n", expected, c);
            }
        } while (false);
    }
}

