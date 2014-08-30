using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00011
{
    [Test]
    public void TestBug00011()
	{
		gdImageStruct im;
		IntPtr fp;
		string path = new string(new char[2048]);

		path = string.Format("{0}/png/emptyfile", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);
		fp = C.fopen(path, "rb");
		if (fp == IntPtr.Zero)
		{
			Assert.Fail("failed, cannot open file: {0}\n", path);
		}
		im = gd.gdImageCreateFromPng(new _iobuf(fp));
		C.fclose(fp);

	    if (im != null)
	    {
	        Assert.Fail();
	    }
	}
}

