using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBmp_null
{
    [Test]
	public void TestBmpNull()
	{
        gdImageStruct im = gd.gdImageCreateFromBmp(null);
		if (im != null)
		{
			gd.gdImageDestroy(im);
            Assert.Fail("gdImageCreateFromBmp returns non-null when passed null.");
		}
		gd.gdImageBmp(im, null, 0); // noop safely
	}
}

