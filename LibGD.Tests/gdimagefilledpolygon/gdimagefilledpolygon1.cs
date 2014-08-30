using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersGdimagefilledpolygon1
{
    [Test]
    public void TestGdImageFilledPolygon1()
	{
		gdImageStruct im;
		int white;
		int black;
		int r;
		gdPoint points;

		im = gd.gdImageCreate(100, 100);
		if (im == null)
			Environment.Exit(1);
		white = gd.gdImageColorAllocate(im, 0xff, 0xff, 0xff);
		black = gd.gdImageColorAllocate(im, 0, 0, 0);
		gd.gdImageFilledRectangle(im, 0, 0, 99, 99, white);
//C++ TO C# CONVERTER TODO TASK: The memory management function 'calloc' has no equivalent in C#:
		points = (gdPoint)calloc(3, sizeof(gdPoint));
		if (points == null)
		{
			gd.gdImageDestroy(im);
			Environment.Exit(1);
		}
		points[0].x = 10;
		points[0].y = 10;
		gd.gdImageFilledPolygon(im, points, 1, black);
	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
		r = GlobalMembersGdtest.gd.gdTestImageCompareToFile(__FILE__, __LINE__, null, (GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR "/gdimagefilledpolygon/gdimagefilledpolygon1.png"), (im));
//C++ TO C# CONVERTER TODO TASK: The memory management function 'free' has no equivalent in C#:
		free(points);
		gd.gdImageDestroy(im);
		if (r == 0)
			Environment.Exit(1);
	}
}

