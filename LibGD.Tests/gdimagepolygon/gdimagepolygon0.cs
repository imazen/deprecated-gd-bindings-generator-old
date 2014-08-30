using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersGdimagepolygon0
{
    [Test]
    public void TestGdImagePolygon0()
	{
		gdImageStruct im;
		int white;
		int black;
		int r;

		im = gd.gdImageCreate(100, 100);
		if (im == null)
			Assert.Fail();
		white = gd.gdImageColorAllocate(im, 0xff, 0xff, 0xff);
		black = gd.gdImageColorAllocate(im, 0, 0, 0);
		gd.gdImageFilledRectangle(im, 0, 0, 99, 99, white);
		gd.gdImagePolygon(im, null, 0, black); // no effect
		gd.gdImagePolygon(im, null, -1, black); // no effect
		r = GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR + "/gdimagepolygon/gdimagepolygon0.png"), (im));
		gd.gdImageDestroy(im);
		if (r == 0)
			Assert.Fail();
	}
}

