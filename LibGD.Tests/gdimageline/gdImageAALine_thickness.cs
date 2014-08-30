using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersGdImageAALine_thickness
{
    [Test]
    public void TestGdImageAALine_thickness()
	{
		gdImageStruct im;
		string path = new string(new char[2048]);
		string file_exp = "gdimageline/gdImageAALine_thickness_exp.png";

		im = gd.gdImageCreateTrueColor(100, 100);
		gd.gdImageFilledRectangle(im, 0, 0, 99, 99, gd.gdImageColorExactAlpha(im, 255, 255, 255, 0));

		gd.gdImageSetThickness(im, 5);
		gd.gdImageSetAntiAliased(im, gd.gdImageColorExactAlpha(im, 0, 0, 0, 0));
		gd.gdImageLine(im, 0,0, 99, 99, GlobalMembersGdtest.DefineConstants.gdAntiAliased);

		path = string.Format("{0}/{1}", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR, file_exp);

        if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (im)) == 0)
		{
            gd.gdImageDestroy(im);
			Assert.Fail("comparing rotated image to {0} failed.\n", path);
		}

		gd.gdImageDestroy(im);

	}
}

