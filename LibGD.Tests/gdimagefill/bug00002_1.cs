using System;
using System.IO;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00002_1
{
    private const string TMP_FN = "bug00002_1.png";

    [Test]
    public void TestBug00002_1()
	{
		gdImageStruct im;
		IntPtr fp;
		string path = new string(new char[1024]);

		im = gd.gdImageCreateTrueColor(100, 100);

		if (im == null)
		{
            GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "Cannot create image.\n");
			Assert.Fail();
		}

		gd.gdImageFill(im, 0, 0, 0xffffff);
		gd.gdImageFill(im, 0, 0, 0xffffff);

		fp = C.fopen(TMP_FN, "wb");
		if (fp == IntPtr.Zero)
		{
            GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "Cannot create image from <%s>\n", TMP_FN);
			gd.gdImageDestroy(im);
            Assert.Fail();
		}

		gd.gdImagePng(im,new _iobuf(fp));
		C.fclose(fp);

		path = string.Format("{0}/gdimagefill/bug00002_1_exp.png", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);
		if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (im)) == 0)
		{
			gd.gdImageDestroy(im);
            Assert.Fail();
		}

		gd.gdImageDestroy(im);

        File.Delete(TMP_FN);
	}
}

