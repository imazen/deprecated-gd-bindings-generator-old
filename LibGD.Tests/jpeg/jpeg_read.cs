using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersJpeg_read
{
    [Test]
    public void TestJpeg_read()
	{
		gdImageStruct im;
		IntPtr fp;
		string path = new string(new char[1024]);

		path = string.Format("{0}/jpeg/conv_test.jpeg", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);
		fp = C.fopen(path, "rb");
		if (fp == IntPtr.Zero)
		{
			GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "failed, cannot open file: %s\n", path);
            Assert.Fail();
		}

		im = gd.gdImageCreateFromJpeg(new _iobuf(fp));
		C.fclose(fp);

		if (im == null)
		{
			GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "gdImageCreateFromJpeg failed.\n");
            Assert.Fail();
		}
		path = string.Format("{0}/jpeg/conv_test_exp.png", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);
		if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (im)) == 0)
		{
			GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "gdAssertImageEqualsToFile failed: <%s>.\n", path);
			gd.gdImageDestroy(im);
            Assert.Fail();
		}
	}
}

