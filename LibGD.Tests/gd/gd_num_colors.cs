using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersGd_num_colors
{
    [Test]
    public void TestGdNumColors()
	{
		gdImageStruct im;
		string path = new string(new char[1024]);
		IntPtr fp;

		path = string.Format("{0}/gd/crafted_num_colors.gd", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);

		fp = C.fopen(path, "rb");
		if (fp == IntPtr.Zero)
		{
            Assert.Fail();
		}
		im = gd.gdImageCreateFromGd(new _iobuf(fp));
		C.fclose(fp);
		if (im != null)
		{
			gd.gdImageDestroy(im);
            Assert.Fail();
		}
	}
}

