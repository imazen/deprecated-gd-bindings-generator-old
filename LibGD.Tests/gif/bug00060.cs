using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00060
{
    [Test]
    public void TestBug00060()
	{
		gdImageStruct im;
		IntPtr fp;
		string path = new string(new char[1024]);

		path = string.Format("{0}/gif/bug00060.gif", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);
		fp = C.fopen(path, "rb");

		if (fp == IntPtr.Zero)
		{
            Assert.Fail("cannot open <{0}>\n", path);
		}

		im = gd.gdImageCreateFromGif(new _iobuf(fp));
		C.fclose(fp);
		gd.gdImageDestroy(im);
	}
}

