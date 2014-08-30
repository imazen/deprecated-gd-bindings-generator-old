using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersGd2_empty_file
{
    [Test]
    public void TestGd2EmptyFile()
	{
		gdImageStruct im;
		IntPtr fp;
		string path = new string(new char[1024]);

		path = string.Format("{0}/gd2/empty.gd2", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);

		fp = C.fopen(path, "rb");
		if (fp == IntPtr.Zero)
		{
			Assert.Fail("failed, cannot open file ({0})\n", path);
		}

		im = gd.gdImageCreateFromGd2(new _iobuf(fp));
		C.fclose(fp);

		if (im == null)
		{
			return;
		}
	    gd.gdImageDestroy(im);
	    Assert.Fail();
	}
}

