using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00111
{
    [Test]
    public void TestBug00111()
	{
		gdImageStruct im;
		int error = 0;
		string path = new string(new char[2048]);
		string file_exp = "bug00111_exp.png";

		im = gd.gdImageCreateTrueColor(10, 10);
		if (im == null)
		{
            Assert.Fail("can't get truecolor image\n");
		}

		gd.gdImageLine(im, 2, 2, 2, 2, 0xFFFFFF);
		gd.gdImageLine(im, 5, 5, 5, 5, 0xFFFFFF);

		gd.gdImageLine(im, 0, 0, 0, 0, 0xFFFFFF);

		path = string.Format("{0}/gdimageline/{1}", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR, file_exp);
		if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (im)) == 0)
		{
			error = 1;
			Console.Write("Reference image and destination differ\n");
		}

		gd.gdImageDestroy(im);

        if (error != 0)
        {
            Assert.Fail("Error: {0}", error);
        }
	}
}

