using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersGd2_null
{
    [Test]
    public void TestGd2Null()
	{
		gdImageStruct im;

		im = gd.gdImageCreateFromGd2(null);
		if (im != null)
		{
			gd.gdImageDestroy(im);
			Assert.Fail();
		}
		gd.gdImageGd2(im, null, 0, GlobalMembersGdtest.DefineConstants.GD2_FMT_RAW); // noop safely
	}
}

