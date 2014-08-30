using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00033
{
    [Test]
    public void TestBug00033()
	{
		gdImageStruct im;
		IntPtr fp;
		string path = new string(new char[1024]);

        //gd.gdSetErrorMethod(GlobalMembersGdtest.gdSilence);

		path = string.Format("{0}/png/bug00033.png", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);
		fp = C.fopen(path, "rb");
		if (fp == IntPtr.Zero)
		{
            Assert.Fail("failed, cannot open file <{0}>\n", path);
		}

		im = gd.gdImageCreateFromPng(new _iobuf(fp));
		C.fclose(fp);

		if (im != null)
		{
			gd.gdImageDestroy(im);
            Assert.Fail();
		}
	}
}

