using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersGdimagecolorresolve
{
    [Test]
    public void TestGdImageColorResolve()
	{
		gdImageStruct im;
		int error = 0;
		int c;
		int c1;
		int c2;
		int c3;
		int c4;
		int color;

		im = gd.gdImageCreateTrueColor(5, 5);
		c = gd.gdImageColorResolve(im, 255, 0, 255);
		c2 = gd.gdImageColorResolveAlpha(im, 255, 0, 255, 100);
		gd.gdImageDestroy(im);

		if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", (c == 0xFF00FF) ? 1 : 0) != 1)
		{
			error = -1;
		}
        if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", (c2 == 0x64FF00FF) ? 1 : 0) != 1)
		{
			error = -1;
		}

		im = gd.gdImageCreate(5, 5);

		c1 = gd.gdImageColorResolve(im, 255, 0, 255);
		c2 = gd.gdImageColorResolve(im, 255, 200, 0);
		c3 = gd.gdImageColorResolveAlpha(im, 255, 0, 255, 100);
		c4 = gd.gdImageColorResolveAlpha(im, 255, 34, 255, 100);

        if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", (c1 == 0) ? 1 : 0) != 1)
		{
			error = -1;
		}
        if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", (c2 == 1) ? 1 : 0) != 1)
		{
			error = -1;
		}
        if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", (c3 == 2) ? 1 : 0) != 1)
		{
			error = -1;
		}
        if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", (c4 == 3) ? 1 : 0) != 1)
		{
			error = -1;
		}

		color = (((0) << 24) + ((((im).trueColor != 0 ? (((c1) & 0xFF0000) >> 16) : (im).red[(c1)])) << 16) + ((((im).trueColor != 0 ? (((c1) & 0x00FF00) >> 8) : (im).green[(c1)])) << 8) + (((im).trueColor != 0 ? ((c1) & 0x0000FF) : (im).blue[(c1)])));
        if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", (color == 0xFF00FF) ? 1 : 0) != 1)
		{
			error = -1;
		}
		color = (((0) << 24) + ((((im).trueColor != 0 ? (((c2) & 0xFF0000) >> 16) : (im).red[(c2)])) << 16) + ((((im).trueColor != 0 ? (((c2) & 0x00FF00) >> 8) : (im).green[(c2)])) << 8) + (((im).trueColor != 0 ? ((c2) & 0x0000FF) : (im).blue[(c2)])));
        if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", (color == 0xFFC800) ? 1 : 0) != 1)
		{
			error = -1;
		}
		color = (((0) << 24) + ((((im).trueColor != 0 ? (((c3) & 0xFF0000) >> 16) : (im).red[(c3)])) << 16) + ((((im).trueColor != 0 ? (((c3) & 0x00FF00) >> 8) : (im).green[(c3)])) << 8) + (((im).trueColor != 0 ? ((c3) & 0x0000FF) : (im).blue[(c3)])));
        if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", (color == 0xFF00FF) ? 1 : 0) != 1)
		{
			error = -1;
		}
		color = (((0) << 24) + ((((im).trueColor != 0 ? (((c4) & 0xFF0000) >> 16) : (im).red[(c4)])) << 16) + ((((im).trueColor != 0 ? (((c4) & 0x00FF00) >> 8) : (im).green[(c4)])) << 8) + (((im).trueColor != 0 ? ((c4) & 0x0000FF) : (im).blue[(c4)])));
        if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", (color == 0xFF22FF) ? 1 : 0) != 1)
		{
			error = -1;
		}
		gd.gdImageDestroy(im);

        if (error != 0)
        {
            Assert.Fail("Error: {0}", error);
        }
	}
}

