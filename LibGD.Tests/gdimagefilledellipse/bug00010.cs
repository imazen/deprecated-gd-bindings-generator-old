using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00010
{
    [Test]
    public void Main()
	{
		gdImageStruct im;
		int error = 0;
		string path = new string(new char[1024]);

		im = gd.gdImageCreateTrueColor(100,100);
		gd.gdImageFilledEllipse(im, 50,50, 70, 90, 0x50FFFFFF);

		path = string.Format("{0}/gdimagefilledellipse/bug00010_exp.png", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);
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

