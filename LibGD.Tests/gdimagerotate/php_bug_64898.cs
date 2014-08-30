using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersPhp_bug_64898
{
    [Test]
    public void TestPhp_bug_64898()
	{
		gdImageStruct im;
		gdImageStruct exp;
		string path = new string(new char[2048]);
		string file_im = "gdimagerotate/php_bug_64898.png";
		string file_exp = "gdimagerotate/php_bug_64898_exp.png";
		IntPtr fp;
		int color;

		path = string.Format("{0}/{1}", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR, file_im);

		fp = C.fopen(path, "rb");

		if (fp == IntPtr.Zero)
		{
			GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "opening PNG %s for reading failed.\n", path);
			Assert.Fail();
		}

		im = gd.gdImageCreateTrueColor(141, 200);

		if (im == null)
		{
			GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "loading %s failed.\n", path);
			Assert.Fail();
		}

		gd.gdImageFilledRectangle(im, 0, 0, 140, 199, 0x00ffffff);

	/*	Try default interpolation method, but any non-optimized fails */
	/*	gd.gdImageSetInterpolationMethod(im, GD_BICUBIC_FIXED); */

		exp = gd.gdImageRotateInterpolated(im, 45, 0x0);

		if (exp == null)
		{
            GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "rotating image failed.\n");
			gd.gdImageDestroy(im);
			Assert.Fail();
		}

		path = string.Format("{0}/{1}", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR, file_exp);

        if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (exp)) == 0)
		{
			Console.Write("comparing rotated image to {0} failed.\n", path);
			gd.gdImageDestroy(im);
			gd.gdImageDestroy(exp);
			Assert.Fail();
		}

		gd.gdImageDestroy(exp);
		gd.gdImageDestroy(im);
	}
}

