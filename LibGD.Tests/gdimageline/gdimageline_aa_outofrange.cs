using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersGdimageline_aa_outofrange
{
    [Test]
    public void TestGdImageLine_aa_outofrange()
	{
		gdImageStruct im;

		im = gd.gdImageCreateTrueColor(300, 300);

		gd.gdImageSetAntiAliased(im, (((0) << 24) + ((255) << 16) + ((255) << 8) + (255)));

		gd.gdImageLine(im, -1, -1, -1, -1, GlobalMembersGdtest.DefineConstants.gdAntiAliased);
		gd.gdImageLine(im, 299, 299, 0, 299, GlobalMembersGdtest.DefineConstants.gdAntiAliased);
		gd.gdImageLine(im, 1,1, 50, 50, GlobalMembersGdtest.DefineConstants.gdAntiAliased);

		/* Test for segfaults, if we reach this point, the test worked */
	}
}

