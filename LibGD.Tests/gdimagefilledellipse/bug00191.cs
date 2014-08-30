using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00191
{
    [Test]
    public void TestBug00191()
	{
		gdImageStruct im;
		int error = 0;
		string path = new string(new char[1024]);

		im = gd.gdImageCreate(100, 100);
		gd.gdImageColorAllocate(im, 255, 255, 255);
		gd.gdImageSetThickness(im, 20);
		gd.gdImageFilledEllipse(im, 30, 50, 20, 20, gd.gdImageColorAllocate(im, 0, 0, 0));
		path = string.Format("{0}/gdimagefilledellipse/bug00191.png", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);
		if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (im)) == 0)
		{
			error = 1;
		}
        gd.gdImageDestroy(im);
        if (error != 0)
        {
            Assert.Fail("Error: {0}", error);
        }
	}
}

