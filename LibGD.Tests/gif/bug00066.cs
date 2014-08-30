using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00066
{
    [Test]
    public void TestBug00066()
	{
		gdImageStruct im;
		IntPtr fp;
		string path = new string(new char[1024]);
		int error = 0;

		path = string.Format("{0}/gif/bug00066.gif", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);
		fp = C.fopen(path, "rb");

		if (fp == IntPtr.Zero)
		{
            Assert.Fail("cannot open <{0}>\n", path);
		}

		im = gd.gdImageCreateFromGif(new _iobuf(fp));
		C.fclose(fp);

		path = string.Format("{0}/gif/bug00066_exp.png", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);
		if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (im)) == 0)
		{
            Assert.Fail();
		}
		gd.gdImageDestroy(im);
	}
}

