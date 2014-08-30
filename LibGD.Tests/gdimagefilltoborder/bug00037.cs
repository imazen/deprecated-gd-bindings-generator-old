using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00037
{
    [Test]
    public void TestBug00037()
	{
		gdImageStruct im;
		int bordercolor;
		int color;

		im = gd.gdImageCreateTrueColor(100, 100);

		gd.gdImageAlphaBlending(im, 1);
		gd.gdImageSaveAlpha(im, 1);
		bordercolor = gd.gdImageColorAllocateAlpha(im, 0, 0, 0, 2);
		color = gd.gdImageColorAllocateAlpha(im, 0, 0, 0, 1);

		gd.gdImageFillToBorder(im, 5, 5, bordercolor, color);

		color = gd.gdImageGetPixel(im, 5, 5);

		gd.gdImageDestroy(im);
        if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__,
                                             "assert failed in <%s:%i>\n", (color == 0x1000000) ? 1 : 0) == 0)
        {
            Assert.Fail("c: {0:X}, expected {1:X}\n", color, 0x1000000);
        }
	}
}

