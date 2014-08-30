using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00186
{
    [Test]
    public void TestBug00186()
	{
		gdImageStruct im;
		gdImageStruct tile;
		int red;
		int green;
		int blue;
		int other;
		int i;
		int r = 0;

		im = gd.gdImageCreateTrueColor(100, 100);
		tile = gd.gdImageCreate(10, 10);
		red = gd.gdImageColorAllocate(tile, 0xFF, 0, 0);
		green = gd.gdImageColorAllocate(tile, 0, 0xFF, 0);
		blue = gd.gdImageColorAllocate(tile, 0, 0, 0xFF);
		other = gd.gdImageColorAllocate(tile, 0, 0, 0x2);
		gd.gdImageFilledRectangle(tile, 0, 0, 2, 10, red);
		gd.gdImageFilledRectangle(tile, 3, 0, 4, 10, green);
		gd.gdImageFilledRectangle(tile, 5, 0, 7, 10, blue);
		gd.gdImageFilledRectangle(tile, 8, 0, 9, 10, other);
		gd.gdImageColorTransparent(tile, blue);
		gd.gdImageSetTile(im, tile);
		for (i = 0; i < 100; i++)
		{
			gd.gdImageSetPixel(im, i, i, GlobalMembersGdtest.DefineConstants.gdTiled);
		}
		if (((gd.gdImageGetPixel(im, 9, 9)) & 0x0000FF) != 0x2)
		{
			r = 1;
		}
		gd.gdImageDestroy(tile);
		gd.gdImageDestroy(im);
        if (r != 0)
        {
            Assert.Fail("Error: {0}", r);
        }
	}
}

