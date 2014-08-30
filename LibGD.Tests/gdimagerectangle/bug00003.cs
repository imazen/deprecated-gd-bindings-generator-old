using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00003
{
    [Test]
    public void TestBug00003()
	{
		gdImageStruct im;
		int c1;
		int c2;
		int c3;
		int c4;

		im = gd.gdImageCreateTrueColor(100,100);
		gd.gdImageRectangle(im, 2,2, 80,95, 0x50FFFFFF);
		c1 = gd.gdImageGetTrueColorPixel(im, 2, 2);
		c2 = gd.gdImageGetTrueColorPixel(im, 80, 95);
		c3 = gd.gdImageGetTrueColorPixel(im, 80, 2);
		c4 = gd.gdImageGetTrueColorPixel(im, 2, 95);

		gd.gdImageDestroy(im);
        if (0x005e5e5e != c1 || 0x005e5e5e != c2 || 0x005e5e5e != c3 || 0x005e5e5e != c4)
        {
            Assert.Fail();
        }
	}
}

