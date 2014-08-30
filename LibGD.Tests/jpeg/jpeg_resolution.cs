using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersJpeg_resolution
{
    [Test]
    public unsafe void TestJpeg_resolution()
	{
		gdImageStruct im;
		void* data;
		int size = 0;
		int red;

		im = gd.gdImageCreate(100, 100);
		gd.gdImageSetResolution(im, 72, 300);
		red = gd.gdImageColorAllocate(im, 0xFF, 0x00, 0x00);
		gd.gdImageFilledRectangle(im, 0, 0, 99, 99, red);
		data = gd.gdImageJpegPtr(im, &size, 10);
		gd.gdImageDestroy(im);

		im = gd.gdImageCreateFromJpegPtr(size, data);
		gd.gdFree(data);
        if (GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", ((im).res_x == 72) ? 1 : 0) == 0 ||
            GlobalMembersGdtest.gdTestAssert(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "assert failed in <%s:%i>\n", ((im).res_y == 300) ? 1 : 0) == 0)
		{
            GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "failed image resolution X (%d != 72) or Y (%d != 300)\n", (im).res_x, (im).res_y);
			gd.gdImageDestroy(im);
            Assert.Fail();
		}
		gd.gdImageDestroy(im);
	}
}

