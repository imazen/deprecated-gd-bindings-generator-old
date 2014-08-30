using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersJpeg_im2im
{
    [Test]
    public void TestJpeg_im2im()
	{
		gdImageStruct src;
		gdImageStruct dst;
		int r;
		int g;
		int b;
		object p;
		int size = 0;
		int status = 0;
	#if false
	//	CuTestImageResult result = {0, 0};
	#endif

		src = gd.gdImageCreateTrueColor(100, 100);
		if (src == null)
		{
            Assert.Fail("could not create src\n");
		}
		r = gd.gdImageColorAllocate(src, 0xFF, 0, 0);
		g = gd.gdImageColorAllocate(src, 0, 0xFF, 0);
		b = gd.gdImageColorAllocate(src, 0, 0, 0xFF);
		gd.gdImageFilledRectangle(src, 0, 0, 99, 99, r);
		gd.gdImageRectangle(src, 20, 20, 79, 79, g);
		gd.gdImageEllipse(src, 70, 25, 30, 20, b);

	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define OUTPUT_JPEG(name) do { FILE *fp; fp = fopen("jpeg_im2im_" #name ".jpeg", "wb"); if (fp) { gd.gdImageJpeg(name, fp, 100); fclose(fp); } } while (0)
	#define OUTPUT_JPEG

		do
		{
			FILE fp;
			fp = fopen("jpeg_im2im_" "src" ".jpeg", "wb");
			if (fp != null)
			{
				gd.gdImageJpeg(src, fp, 100);
				fclose(fp);
			}
		} while (0);
		p = gd.gdImageJpegPtr(src, size, 100);
		if (p == null)
		{
			status = 1;
			Console.Write("p is null\n");
			goto door0;
		}
		if (size <= 0)
		{
			status = 1;
			Console.Write("size is non-positive\n");
			goto door1;
		}

		dst = gd.gdImageCreateFromJpegPtr(size, p);
		if (dst == null)
		{
			status = 1;
			Console.Write("could not create dst\n");
			goto door1;
		}
		do
		{
			FILE fp;
			fp = fopen("jpeg_im2im_" "dst" ".jpeg", "wb");
			if (fp != null)
			{
				gd.gdImageJpeg(dst, fp, 100);
				fclose(fp);
			}
		} while (0);
	#if false
	//	gd.gdTestImageDiff(src, dst, NULL, &result);
	//	if (result.pixels_changed > 0) {
	//		status = 1;
	//		printf("pixels changed: %d\n", result.pixels_changed);
	//	}
	#endif
		gd.gdImageDestroy(dst);
	door1:
		gd.gdFree(p);
	door0:
		gd.gdImageDestroy(src);
		return status;
	}
}

