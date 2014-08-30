using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00007
{
    [Test]
    public void TestBug00007()
	{
		gdImageStruct dst_tc;
		gdImageStruct src;
		int c1;

		src = gd.gdImageCreate(5,5);
		gd.gdImageAlphaBlending(src, 0);

		gd.gdImageColorAllocate(src, 255,255,255); // allocate white for background color
		c1 = gd.gdImageColorAllocateAlpha(src, 255,0,0,70);

		gd.gdImageFilledRectangle(src, 0,0, 4,4, c1);

		dst_tc = gd.gdImageCreateTrueColor(5,5);
		gd.gdImageAlphaBlending(dst_tc, 0);
		gd.gdImageCopy(dst_tc, src, 0,0, 0,0, ((src).sx), ((src).sy));

		/* CuAssertImageEquals(tc, src, dst_tc); */

		/* Destroy it */
		gd.gdImageDestroy(dst_tc);
		gd.gdImageDestroy(src);
	}
}

