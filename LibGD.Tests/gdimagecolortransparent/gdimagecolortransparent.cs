using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersGdimagecolortransparent
{
    [Test]
    public void TestGdImageColorTransparent()
	{
		gdImageStruct im;
		int error = 0;
		int pos;

		pos = GlobalMembersGdtest.DefineConstants.gdMaxColors;

		im = gd.gdImageCreate(1,1);

		gd.gdImageColorTransparent(im, pos);

		if (im.transparent == pos)
		{
			error = -1;
		}

		pos = -2;

		gd.gdImageColorTransparent(im, pos);

		if (im.transparent == pos)
		{
			error = -1;
		}

		gd.gdImageDestroy(im);

        if (error != 0)
        {
            Assert.Fail("Error: {0}", error);
        }
	}
}

