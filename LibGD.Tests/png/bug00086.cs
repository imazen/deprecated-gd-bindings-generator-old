using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00086
{
    [Test]
    public unsafe void TestBug00086()
    {
        gdImageStruct im;

        //gd.gdSetErrorMethod(GlobalMembersGdtest.gdSilence);

        fixed (void* pngPtr = this.pngdata)
        {
            if ((im = gd.gdImageCreateFromPngPtr(93, pngPtr)) != null)
            {
                gd.gdImageDestroy(im);
                Assert.Fail();
            }
        }
    }

    /* PNG data */
	internal byte[] pngdata = {137,80,78,71,13,10,26,10,0,0, 0,13,73,72,68,82,0,0,0,120,0,0,0,131,8,6,0,0,0,70,49,223,8,0,0,0,6,98, 75,71,68,0,255,0,255,0,255,160,189,167,147,0,0,0,9,112,72,89,115,0,0,92, 70,0,0,92,70,1,20,148,67,65,0,0,0,9,118,112,65,103,0,0,0,120,0,0,0,131, 0,226,13,249,45};
}

