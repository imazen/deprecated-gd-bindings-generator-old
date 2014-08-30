using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00181
{
    [Test]
    public void TestBug00181()
	{
		gdImageStruct im;
		gdImageStruct im2;
		gdImageStruct im3;
		IntPtr fp;
		int black;
		int trans;
		int error = 0;

		/* GIFEncode */
		im = gd.gdImageCreate(100, 100);
		if (im == null)
		{
			GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "Cannot create image.\n");
			Assert.Fail();
		}
		im.interlace = 1;
		fp = C.fopen("bug00181.gif", "wb");
		if (fp == IntPtr.Zero)
		{
			GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "Cannot open <%s> for writing.\n", "bug00181.gif");
			Assert.Fail();
		}
		gd.gdImageGif(im, new _iobuf(fp));
		gd.gdImageDestroy(im);
		C.fclose(fp);

		fp = C.fopen("bug00181.gif", "rb");
		if (fp == IntPtr.Zero)
		{
			GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "Cannot open <%s> for reading.\n", "bug00181.gif");
			Assert.Fail();
		}
		im = gd.gdImageCreateFromGif(new _iobuf(fp));
		C.fclose(fp);
		if (im == null)
		{
			GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "Cannot create image from <%s>\n", "bug00181.gif");
			Assert.Fail();
		}
		error = im.interlace == 0 ? 1 : 0;
		gd.gdImageDestroy(im);

		if (error != 0)
			Assert.Fail();

		/* GIFAnimEncode */
		im = gd.gdImageCreate(100, 100);
		im.interlace = 1;
		gd.gdImageColorAllocate(im, 255, 255, 255); // allocate white for background color
		black = gd.gdImageColorAllocate(im, 0, 0, 0);
		trans = gd.gdImageColorAllocate(im, 1, 1, 1);
		gd.gdImageRectangle(im, 0, 0, 10, 10, black);
		fp = C.fopen("bug00181a.gif", "wb");
		if (fp == IntPtr.Zero)
		{
			GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "Cannot open <%s> for writing.\n", "bug00181a.gif");
			Assert.Fail();
		}
		gd.gdImageGifAnimBegin(im, new _iobuf(fp), 1, 3);
		gd.gdImageGifAnimAdd(im, new _iobuf(fp), 0, 0, 0, 100, 1, null);
		im2 = gd.gdImageCreate(100, 100);
		im2.interlace = 1;
		gd.gdImageColorAllocate(im2, 255, 255, 255);
		gd.gdImagePaletteCopy(im2, im);
		gd.gdImageRectangle(im2, 0, 0, 15, 15, black);
		gd.gdImageColorTransparent(im2, trans);
		gd.gdImageGifAnimAdd(im2, new _iobuf(fp), 0, 0, 0, 100, 1, im);
		im3 = gd.gdImageCreate(100, 100);
		im3.interlace = 1;
		gd.gdImageColorAllocate(im3, 255, 255, 255);
		gd.gdImagePaletteCopy(im3, im);
		gd.gdImageRectangle(im3, 0, 0, 15, 20, black);
		gd.gdImageColorTransparent(im3, trans);
		gd.gdImageGifAnimAdd(im3, new _iobuf(fp), 0, 0, 0, 100, 1, im2);
		gd.gdImageGifAnimEnd(new _iobuf(fp));
		C.fclose(fp);
		gd.gdImageDestroy(im);
		gd.gdImageDestroy(im2);
		gd.gdImageDestroy(im3);

		fp = C.fopen("bug00181a.gif", "rb");
		if (fp == IntPtr.Zero)
		{
			GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "Cannot open <%s> for reading.\n", "bug00181a.gif");
			Assert.Fail();
		}
		im = gd.gdImageCreateFromGif(new _iobuf(fp));
		C.fclose(fp);
		if (im == null)
		{
            GlobalMembersGdtest.gdTestErrorMsg(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, "Cannot create image from <%s>\n", "bug00181a.gif");
			Assert.Fail();
		}
		error = im.interlace == 0 ? 1 : 0;
		gd.gdImageDestroy(im);

        if (error != 0)
        {
            Assert.Fail();
        }
	}
}

