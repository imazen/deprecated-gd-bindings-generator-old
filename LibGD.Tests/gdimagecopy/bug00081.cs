using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00081
{
    [Test]
    public void TestBug00081()
	{
		gdImageStruct im;
		gdImageStruct im2;
        string path = new string(new char[2048]);
		string file_exp = "bug00081_exp.png";

		im = gd.gdImageCreateTrueColor(5, 5);
		if (im == null)
		{
            Assert.Fail("can't create the src truecolor image\n");
		}

		gd.gdImageFilledRectangle(im, 0, 0, 49, 49, 0x00FFFFFF);
		gd.gdImageColorTransparent(im, 0xFFFFFF);
		gd.gdImageFilledRectangle(im, 1, 1, 4, 4, 0xFF00FF);

		im2 = gd.gdImageCreateTrueColor(20, 20);
		if (im2 == null)
		{
            gd.gdImageDestroy(im);
            Assert.Fail("can't create the dst truecolor image\n");
		}

		gd.gdImageCopy(im2, im, 2, 2, 0, 0, ((im).sx), ((im).sy));

		path = string.Format("{0}/gdimagecopy/{1}", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR, file_exp);
		if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (im2)) == 0)
        {
            gd.gdImageDestroy(im);
            gd.gdImageDestroy(im2);
            Assert.Fail("Reference image and destination differ\n");
        }

		gd.gdImageDestroy(im);
		gd.gdImageDestroy(im2);
	}
}

