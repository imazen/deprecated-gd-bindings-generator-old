using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00079
{
    [Test]
    public void TestBug00079()
	{
		gdImageStruct im;
        string path = new string(new char[1024]);


		im = gd.gdImageCreateTrueColor(300, 300);
		gd.gdImageFilledRectangle(im, 0,0, 299,299, 0xFFFFFF);

		gd.gdImageSetAntiAliased(im, 0x000000);
		gd.gdImageArc(im, 300, 300, 600,600, 0, 360, GlobalMembersGdtest.DefineConstants.gdAntiAliased);

		path = string.Format("{0}/gdimagearc/bug00079_exp.png", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);
		if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (im)) == 0)
		{
            Assert.Fail("{0} failed\n", path);
		}

		gd.gdImageDestroy(im);
	}
}

