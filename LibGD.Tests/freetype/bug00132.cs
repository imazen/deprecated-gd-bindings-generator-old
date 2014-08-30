using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00132
{
    [Test]
    public unsafe void TestBug00132()
    {
		gdImageStruct im;
		int error = 0;
		string path = new string(new char[2048]);
		string file_exp = "bug00132_exp.png";
		sbyte* ret = null;

		im = gd.gdImageCreateTrueColor(50, 30);

		if (im == null)
		{
            Assert.Fail("can't get truecolor image\n");
		}

		gd.gdImageAlphaBlending(im, 0);
		gd.gdImageFilledRectangle(im, 0, 0, 200, 200, (((127) << 24) + ((0) << 16) + ((0) << 8) + (0)));

		path = Path.Combine(GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR, "freetype", "DejaVuSans.ttf");

        byte[] fontlistBytes = Encoding.ASCII.GetBytes(path);
        byte[] bytes = Encoding.ASCII.GetBytes("&thetasym; &theta;");
        fixed (byte* f = fontlistBytes)
        {
            fixed (byte* b = bytes)
            {
                ret = gd.gdImageStringFT(im, null, -0xFFFFFF, (sbyte*) f, 14.0, 0.0, 10, 20, (sbyte*) b);
                if (ret != null)
                {
                    error = 1;
                    Assert.Fail("{0}\n", new string(ret));
                }
                else
                {
                    path = Path.Combine(GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR, "freetype", file_exp);
                    if (GlobalMembersGdtest.gdTestImageCompareToFile(GlobalMembersGdtest.__FILE__, GlobalMembersGdtest.__LINE__, null, (path), (im)) == 0)
                    {
                        error = 1;
                        Assert.Fail("Reference image and destination differ\n");
                    }
                }
                gd.gdImageDestroy(im);
                if (error != 0)
                {
                    Assert.Fail("Error: {0}", error);
                }
            }
        }
	}
}

