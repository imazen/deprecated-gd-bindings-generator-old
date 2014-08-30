using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersJpeg_null
{
    [Test]
    public void TestJpeg_null()
	{
		gdImageStruct im;

		im = gd.gdImageCreateFromJpeg(null);
		if (im != null)
		{
			gd.gdImageDestroy(im);
			Assert.Fail();
		}
		gd.gdImageJpeg(im, null, 100); // noop safely
	}
}

