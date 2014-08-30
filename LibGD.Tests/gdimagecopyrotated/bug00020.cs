using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00020
{
    private const int WIDTH = 50;

    [Test]
    public void TestBug00020()
	{
		gdImageStruct im;
		gdImageStruct im2;
		int error = 0;
		string path = new string(new char[1024]);

		path = string.Format("{0}/gdimagecopyrotated/bug00020_exp.png", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);

        im = gd.gdImageCreateTrueColor(WIDTH, WIDTH);
		gd.gdImageFilledRectangle(im, 0,0, WIDTH, WIDTH, 0xFF0000);
		gd.gdImageColorTransparent(im, 0xFF0000);
		gd.gdImageFilledEllipse(im, WIDTH / 2, WIDTH / 2, WIDTH - 20, WIDTH - 10, 0x50FFFFFF);

		im2 = gd.gdImageCreateTrueColor(WIDTH, WIDTH);

		gd.gdImageCopyRotated(im2, im, WIDTH / 2, WIDTH / 2, 0,0, WIDTH, WIDTH, 60);

        if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (im2)) == 0)
		{
			error = 1;
		}

		gd.gdImageDestroy(im2);
        gd.gdImageDestroy(im);
        if (error != 0)
        {
            Assert.Fail("Error: {0}", error);
        }
	}
}

