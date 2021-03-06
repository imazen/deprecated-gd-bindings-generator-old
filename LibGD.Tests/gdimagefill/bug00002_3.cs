using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00002_3
{
    [Test]
    public void TestBug00002_3()
	{
		gdImageStruct im;
		gdImageStruct tile;
		int im_black;
		int tile_white;
		int tile_black;
		int x;
		int y;
		int error = 0;
		string path = new string(new char[1024]);

	/*	fputs("flag 0\n", stdout); */
		im = gd.gdImageCreate(150, 150);


		tile = gd.gdImageCreateTrueColor(36, 36);

		tile_white = gd.gdImageColorAllocate(tile,255,255,255);
		tile_black = gd.gdImageColorAllocate(tile,55,0,0);
		gd.gdImageColorAllocate(im,255,255,255); // allocate white for background color
		im_black = gd.gdImageColorAllocate(im,0,0,0);

		gd.gdImageFill(tile, 0,0, tile_white);
		gd.gdImageColorTransparent(tile, tile_black);
		gd.gdImageColorTransparent(im, im_black);

		/* create the dots pattern */
		for (x = 0; x < 36; x += 2)
		{
			for (y = 0; y < 36; y += 2)
			{
				gd.gdImageSetPixel(tile,x,y,tile_black);
			}
		}

		gd.gdImageSetTile(im,tile);
		gd.gdImageRectangle(im, 9,9,139,139, im_black);
		gd.gdImageLine(im, 9,9,139,139, im_black);
		gd.gdImageFill(im, 11,12, GlobalMembersGdtest.DefineConstants.gdTiled);


	/*	fputs("flag 1\n", stdout); */
		gd.gdImageFill(im, 0, 0, 0xffffff);
	/*	fputs("flag 2\n", stdout); */
		gd.gdImageFill(im, 0, 0, 0xffffff);
	/*	fputs("flag 3\n", stdout); */

		path = string.Format("{0}/gdimagefill/bug00002_3_exp.png", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);
		if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (im)) == 0)
		{
			error = 1;
		}

		/* Destroy it */
        gd.gdImageDestroy(im);
        if (error != 0)
        {
            Assert.Fail("Error: {0}", error);
        }
	}
}

