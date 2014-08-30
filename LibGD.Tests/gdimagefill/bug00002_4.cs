using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00002_4
{
    [Test]
    public void Main()
	{
		gdImageStruct im;
		int red;
		int blue;
		int white;
		int black;
		int error = 0;
		string path = new string(new char[1024]);

		im = gd.gdImageCreate(50,100);
		red = gd.gdImageColorAllocate(im, 255, 0, 0);
		blue = gd.gdImageColorAllocate(im, 0,0,255);
		white = gd.gdImageColorAllocate(im, 255,255,255);
		black = gd.gdImageColorAllocate(im, 0,0,0);
		gd.gdImageFill(im, 0,0, black);

		gd.gdImageLine(im, 20,20,180,20, white);
		gd.gdImageLine(im, 20,20,20,70, blue);
		gd.gdImageLine(im, 20,70,180,70, red);
		gd.gdImageLine(im, 180,20,180,45, white);
		gd.gdImageLine(im, 180,70,180,45, red);
		gd.gdImageLine(im, 20,20,100,45, blue);
		gd.gdImageLine(im, 20,70,100,45, blue);
		gd.gdImageLine(im, 100,45,180,45, red);

		gd.gdImageFill(im, 21,45, blue);
		gd.gdImageFill(im, 100,69, red);
		gd.gdImageFill(im, 100,21, white);

		path = string.Format("{0}/gdimagefill/bug00002_4_exp.png", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);
		if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (im)) == 0)
		{
			error = 1;
		}

		/* Destroy it */
        gd.gdImageDestroy(im);
        if (error != 0)
        {
            Assert.Fail("Error: {0}", error);
        }
	}
}

