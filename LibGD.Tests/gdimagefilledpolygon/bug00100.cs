using System;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00100
{
    [Test]
    public void TestBug00100()
	{
		gdPoint[] pointy = new gdPoint[5];
		gdPoint[] diamond = new gdPoint[4];
		int d;
		int x;
		int y;
		int top;
		int bot;
		int left;
		int right;
		int r;

		/*                              R    G    B */
		int white = (((10) << 24) + ((255) << 16) + ((255) << 8) + (255));
		int black = (((10) << 24) + ((0) << 16) + ((0) << 8) + (0));
		int red = (((10) << 24) + ((255) << 16) + ((0) << 8) + (0));
		int green = (((10) << 24) + ((0) << 16) + ((255) << 8) + (0));
		int blue = (((10) << 24) + ((0) << 16) + ((0) << 8) + (255));
		int yellow = (((10) << 24) + ((255) << 16) + ((255) << 8) + (0));
		int cyan = (((10) << 24) + ((0) << 16) + ((255) << 8) + (255));
		int magenta = (((10) << 24) + ((255) << 16) + ((0) << 8) + (255));
		int purple = (((10) << 24) + ((100) << 16) + ((0) << 8) + (100));

		gdImageStruct im = gd.gdImageCreateTrueColor(256, 256);
		if (im == null)
			Environment.Exit(1);

		gd.gdImageFilledRectangle(im, 0, 0, 256, 256, white);

		/* M (bridge) */
		top = 240;
		bot = 255;
		d = 30;
		x = 100;
		pointy[0].x = x;
		pointy[0].y = top;
		pointy[1].x = x + 2 * d;
		pointy[1].y = top;
		pointy[2].x = x + 2 * d;
		pointy[2].y = bot;
		pointy[3].x = x + d;
		pointy[3].y = (top + bot) / 2;
		pointy[4].x = x;
		pointy[4].y = bot;
		gd.gdImageFilledPolygon(im, pointy, 5, yellow);

		/* left-facing M not on baseline */
		top = 40;
		bot = 70;
		left = 120;
		right = 180;
		pointy[0].x = left;
		pointy[0].y = top;
		pointy[1].x = right;
		pointy[1].y = top;
		pointy[2].x = right;
		pointy[2].y = bot;
		pointy[3].x = left;
		pointy[3].y = bot;
		pointy[4].x = (left + right) / 2;
		pointy[4].y = (top + bot) / 2;
		gd.gdImageFilledPolygon(im, pointy, 5, purple);

		/* left-facing M on baseline */
		top = 240;
		bot = 270;
		left = 20;
		right = 80;
		pointy[0].x = left;
		pointy[0].y = top;
		pointy[1].x = right;
		pointy[1].y = top;
		pointy[2].x = right;
		pointy[2].y = bot;
		pointy[3].x = left;
		pointy[3].y = bot;
		pointy[4].x = (left + right) / 2;
		pointy[4].y = (top + bot) / 2;
		gd.gdImageFilledPolygon(im, pointy, 5, magenta);

		/* left-facing M on ceiling */
		top = -15;
		bot = 15;
		left = 20;
		right = 80;
		pointy[0].x = left;
		pointy[0].y = top;
		pointy[1].x = right;
		pointy[1].y = top;
		pointy[2].x = right;
		pointy[2].y = bot;
		pointy[3].x = left;
		pointy[3].y = bot;
		pointy[4].x = (left + right) / 2;
		pointy[4].y = (top + bot) / 2;
		gd.gdImageFilledPolygon(im, pointy, 5, blue);

		d = 30;
		x = 150;
		y = 150;
		diamond[0].x = x - d;
		diamond[0].y = y;
		diamond[1].x = x;
		diamond[1].y = y + d;
		diamond[2].x = x + d;
		diamond[2].y = y;
		diamond[3].x = x;
		diamond[3].y = y - d;
		gd.gdImageFilledPolygon(im, diamond, 4, green);

		x = 180;
		y = 225;
		diamond[0].x = x - d;
		diamond[0].y = y;
		diamond[1].x = x;
		diamond[1].y = y + d;
		diamond[2].x = x + d;
		diamond[2].y = y;
		diamond[3].x = x;
		diamond[3].y = y - d;
		gd.gdImageFilledPolygon(im, diamond, 4, red);

		x = 225;
		y = 255;
		diamond[0].x = x - d;
		diamond[0].y = y;
		diamond[1].x = x;
		diamond[1].y = y + d;
		diamond[2].x = x + d;
		diamond[2].y = y;
		diamond[3].x = x;
		diamond[3].y = y - d;
		gd.gdImageFilledPolygon(im, diamond, 4, cyan);

		/* M (bridge) not touching bottom boundary */
		top = 100;
		bot = 150;
		x = 30;
		pointy[0].x = x;
		pointy[0].y = top;
		pointy[1].x = x + 2 * d;
		pointy[1].y = top;
		pointy[2].x = x + 2 * d;
		pointy[2].y = bot;
		pointy[3].x = x + d;
		pointy[3].y = (top + bot) / 2;
		pointy[4].x = x;
		pointy[4].y = bot;
		gd.gdImageFilledPolygon(im, pointy, 5, black);

        r = GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR + "/gdimagefilledpolygon/bug00100.png"), (im));
		gd.gdImageDestroy(im);
		if (r == 0)
			Assert.Fail();
	}
}

