using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00106_gdimagefilledrectangle
{
    [Test]
    public void TestBug00106_gdimagefilledrectangle()
	{
		gdImageStruct im;
		int c1;
		int c2;
		int c3;
		int c4;

		im = gd.gdImageCreateTrueColor(10,10);
		if (im == null)
		{
			Assert.Fail();
		}

		gd.gdImageFilledRectangle(im, 1,1, 1,1, 0x50FFFFFF);
		c1 = gd.gdImageGetTrueColorPixel(im, 1, 1);
		c2 = gd.gdImageGetTrueColorPixel(im, 2, 1);
		c3 = gd.gdImageGetTrueColorPixel(im, 1, 2);
		c4 = gd.gdImageGetTrueColorPixel(im, 2, 2);
		gd.gdImageDestroy(im);
        if (0x005e5e5e != c1 || 0x0 != c2 || 0x0 != c3 || 0x0 != c4)
        {
            Assert.Fail();
        }
	}
}

