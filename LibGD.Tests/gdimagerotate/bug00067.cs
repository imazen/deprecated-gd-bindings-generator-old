using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00067
{
    [Test]
    public void TestBug00067()
	{
		gdImageStruct im;
		gdImageStruct exp;
		string path = new string(new char[2048]);
		string file_im = "gdimagerotate/remirh128.jpg";
		string file_exp = "gdimagerotate/bug00067";
		IntPtr fp;
		int color;
		int error = 0;
		int angle;

		path = string.Format("{0}/{1}", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR, file_im);

		fp = C.fopen(path, "rb");

		if (fp == IntPtr.Zero)
		{
			GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "opening Jpeg %s for reading failed.\n", path);
			Assert.Fail();
		}

		im = gd.gdImageCreateFromJpeg(new _iobuf(fp));

		C.fclose(fp);

		if (im == null)
		{
			GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "loading %s failed.\n", path);
			Assert.Fail();
		}

		color = gd.gdImageColorAllocate(im, 0, 0, 0);

		if (color < 0)
		{
			GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "allocation color from image failed.\n");
			gd.gdImageDestroy(im);
			Assert.Fail();
		}

		for (angle = 0; angle <= 180; angle += 15)
		{

			exp = gd.gdImageRotateInterpolated(im, angle, color);

			if (exp == null)
			{
				GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "rotating image failed for %03d.\n", angle);
				gd.gdImageDestroy(im);
				Assert.Fail();
			}

			path = string.Format("{0}/{1}_{2:D3}_exp.png", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR, file_exp, angle);

			if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (exp)) == 0)
			{
                GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "comparing rotated image to %s failed.\n", path);
				error += 1;
			}

			gd.gdImageDestroy(exp);
		}

		gd.gdImageDestroy(im);

        if (error != 0)
        {
            Assert.Fail("Error: {0}", error);
        }
	}
}

