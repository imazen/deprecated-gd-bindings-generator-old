using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersGd2_read
{
    [Test]
    public void TestGd2Read()
	{
		int error;
		gdImageStruct im;
		IntPtr fp;
		string path = new string(new char[1024]);

		path = string.Format("{0}/gd2/conv_test.gd2", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);

		fp = C.fopen(path, "rb");
		if (fp == IntPtr.Zero)
		{
			Console.Write("failed, cannot open file\n");
			Assert.Fail("failed, cannot open file\n");
		}

		im = gd.gdImageCreateFromGd2(new _iobuf(fp));
		C.fclose(fp);

		path = string.Format("{0}/gd2/conv_test_exp.png", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);
		if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (im)) == 0)
		{
			gd.gdImageDestroy(im);
            Assert.Fail();
		}
		else
		{
			if (im != null)
			{
				gd.gdImageDestroy(im);
			}
			else
			{
				Assert.Fail();
			}
		}
	}
}

