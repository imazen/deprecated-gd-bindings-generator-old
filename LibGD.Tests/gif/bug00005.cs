using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00005
{
    [Test]
    public void TestBug00005()
	{
		gdImageStruct im;
		string[] giffiles = {"bug00005_0.gif", "bug00005_1.gif", "bug00005_2.gif", "bug00005_3.gif"};
		int[] valid = {0, 0, 0, 0};
		string[] exp = {null, null, "bug00005_2_exp.png", null};
		const int files_cnt = 4;
		IntPtr fp;
		int i = 0;
		int error = 0;
		string path = new string(new char[1024]);

		for (i = 0; i < files_cnt; i++)
		{
			path = string.Format("{0}/gif/{1}", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR, giffiles[i]);

			fp = C.fopen(path, "rb");
			if (fp == IntPtr.Zero)
			{
				GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "<%s> Input file does not exist!\n", path);
				Assert.Fail();
			}

			im = gd.gdImageCreateFromGif(new _iobuf(fp));
			C.fclose(fp);

			if (valid[i] != 0)
			{
				if (im == null)
				{
					error = 1;
				}
				else
				{
					path = string.Format("{0}/gif/{1}", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR, exp[i]);
					if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (im)) == 0)
					{
						error = 1;
					}
					gd.gdImageDestroy(im);
				}
			}
			else
			{
				if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", (im == null) ? 1 : 0) == 0)
				{
					error = 1;
				}
			}
		}
        if (error != 0)
        {
            Assert.Fail("Error: {0}", error);
        }
	}
}

