using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00088
{
    [Test]
    public void TestBug00088()
	{
		int error;
		gdImageStruct im;
		IntPtr fp;
		string path = new string(new char[1024]);
		string[] files = {"bug00088_1.png", "bug00088_2.png"};
		string[] files_exp = {"bug00088_1_exp.png", "bug00088_2_exp.png"};

		int i;
		int cnt = 2;
		error = 0;

		for (i = 0; i < cnt; i++)
		{

			path = string.Format("{0}/png/{1}", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR, files[i]);
			fp = C.fopen(path, "rb");
			if (fp == IntPtr.Zero)
			{
                Assert.Fail("failed, cannot open file <{0}>\n", path);
			}

			im = gd.gdImageCreateFromPng(new _iobuf(fp));
			C.fclose(fp);

			if (im == null)
			{
				error |= 1;
				continue;
			}

			path = string.Format("{0}/png/{1}", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR, files_exp[i]);
			if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (im)) == 0)
			{
				error |= 1;
			}
			gd.gdImageDestroy(im);
		}
        if (error != 0)
        {
            Assert.Fail("Error: {0}.", error);
        }
	}
}

