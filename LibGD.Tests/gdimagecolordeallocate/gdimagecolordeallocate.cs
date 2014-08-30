using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersGdimagecolordeallocate
{
    [Test]
    public void TestGdImageColorDeallocate()
	{
		gdImageStruct im;
		int c;

		im = gd.gdImageCreate(1, 1);
		/* test for deallocating a color */
		c = gd.gdImageColorAllocate(im, 255, 255, 255);
		if (c < 0)
		{
			gd.gdImageDestroy(im);
			Assert.Fail();
		}
		gd.gdImageColorDeallocate(im, c);
		if (im.open[c] == 0)
		{
			gd.gdImageDestroy(im);
			Assert.Fail();
		}

		/* just see whether it is OK with out-of-bounds values */
		gd.gdImageColorDeallocate(im, GlobalMembersGdtest.DefineConstants.gdMaxColors);
		gd.gdImageColorDeallocate(im, -1);
		gd.gdImageDestroy(im);
	}
}

