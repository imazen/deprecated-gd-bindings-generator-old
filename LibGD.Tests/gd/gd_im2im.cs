using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersGd_im2im
{
    [Test]
    public unsafe void TestGd_im2im()
	{
		gdImageStruct src;
		gdImageStruct dst;
		int r;
		int g;
		int b;
		void* p;
		int size = 0;
		int status = 0;
		GlobalMembersGdtest.CuTestImageResult result = new GlobalMembersGdtest.CuTestImageResult(0, 0);

		src = gd.gdImageCreate(100, 100);
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

        OutputGd(src, "src");
		p = gd.gdImageGdPtr(src, &size);
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

		dst = gd.gdImageCreateFromGdPtr(size, p);
		if (dst == null)
		{
			status = 1;
			Console.Write("could not create dst\n");
			goto door1;
		}
        OutputGd(dst, "dst");
		GlobalMembersGdtest.gdTestImageDiff(src, dst, null, result);
		if (result.pixels_changed > 0)
		{
			status = 1;
			Console.Write("pixels changed: {0:D}\n", result.pixels_changed);
		}
		gd.gdImageDestroy(dst);
	door1:
		gd.gdFree(p);
	door0:
		gd.gdImageDestroy(src);
        Assert.AreEqual(0, status);
	}

    private static void OutputGd(gdImageStruct input, string name)
    {
        do
        {
            var fp = C.fopen(string.Format("gd_im2im_{0}.gd", name), "wb");
            if (fp != IntPtr.Zero)
            {
                gd.gdImageGd(input, new _iobuf(fp));
                C.fclose(fp);
            }
        } while (false);
    }
}

