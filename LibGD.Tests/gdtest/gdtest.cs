using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using LibGD;

public static class GlobalMembersGdtest
{
    internal static partial class DefineConstants
    {
        public const int GD_H = 1;
        public const int GD_MAJOR_VERSION = 2;
        public const int GD_MINOR_VERSION = 1;
        public const int GD_RELEASE_VERSION = 1;
        public const string GD_EXTRA_VERSION = "-dev";
        public const int GD_IO_H = 1;
        public const int gdMaxColors = 256;
        public const int gdAlphaMax = 127;
        public const int gdAlphaOpaque = 0;
        public const int gdAlphaTransparent = 127;
        public const int gdRedMax = 255;
        public const int gdGreenMax = 255;
        public const int gdBlueMax = 255;
        public const int gdEffectReplace = 0;
        public const int gdEffectAlphaBlend = 1;
        public const int gdEffectNormal = 2;
        public const int gdEffectOverlay = 3;
        public const int GD_TRUE = 1;
        public const int GD_FALSE = 0;
        public const double GD_EPSILON = 1e-6;
        public const double M_PI = 3.14159265358979323846;
        public const int gdDashSize = 4;
        public const int gdStyled = -2;
        public const int gdBrushed = -3;
        public const int gdStyledBrushed = -4;
        public const int gdTiled = -5;
        public const int gdTransparent = -6;
        public const int gdAntiAliased = -7;
        public const int gdFTEX_LINESPACE = 1;
        public const int gdFTEX_CHARMAP = 2;
        public const int gdFTEX_RESOLUTION = 4;
        public const int gdFTEX_DISABLE_KERNING = 8;
        public const int gdFTEX_XSHOW = 16;
        public const int gdFTEX_FONTPATHNAME = 32;
        public const int gdFTEX_FONTCONFIG = 64;
        public const int gdFTEX_RETURNFONTPATHNAME = 128;
        public const int gdFTEX_Unicode = 0;
        public const int gdFTEX_Shift_JIS = 1;
        public const int gdFTEX_Big5 = 2;
        public const int gdFTEX_Adobe_Custom = 3;
        public const int gdArc = 0;
        public const int gdChord = 1;
        public const int gdNoFill = 2;
        public const int gdEdged = 4;
        public const int GD2_CHUNKSIZE = 128;
        public const int GD2_CHUNKSIZE_MIN = 64;
        public const int GD2_CHUNKSIZE_MAX = 4096;
        public const int GD2_VERS = 2;
        public const string GD2_ID = "gd2";
        public const int GD2_FMT_RAW = 1;
        public const int GD2_FMT_COMPRESSED = 2;
        public const int GD_FLIP_HORINZONTAL = 1;
        public const int GD_FLIP_VERTICAL = 2;
        public const int GD_FLIP_BOTH = 3;
        public const int GD_CMP_IMAGE = 1;
        public const int GD_CMP_NUM_COLORS = 2;
        public const int GD_CMP_COLOR = 4;
        public const int GD_CMP_SIZE_X = 8;
        public const int GD_CMP_SIZE_Y = 16;
        public const int GD_CMP_TRANSPARENT = 32;
        public const int GD_CMP_BACKGROUND = 64;
        public const int GD_CMP_INTERLACE = 128;
        public const int GD_CMP_TRUECOLOR = 256;
        public const int GD_RESOLUTION = 96;
        public const int GDFX_H = 1;
        public static readonly string GDTEST_TOP_DIR = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);
        public const int GDTEST_STRING_MAX = 1024;
    }

    public struct CuTestImageResult
    {
        public CuTestImageResult(uint pixelsChanged, uint maxDiff)
        {
            this.pixels_changed = pixelsChanged;
            this.max_diff = maxDiff;
        }

        public uint pixels_changed;
        public uint max_diff;
    };

	/* Internal versions of assert functions -- use the public versions */
	public static gdImageStruct gdTestImageFromPng(string filename)
	{
		gdImageStruct image;

		IntPtr fp;

		fp = C.fopen(filename, "rb");

		if (fp == IntPtr.Zero)
		{
			return null;
		}
		image = gd.gdImageCreateFromPng(new _iobuf(fp));
		C.fclose(fp);
		return image;
	}

/* Compare two buffers, returning the number of pixels that are
 * different and the maximum difference of any single color channel in
 * result_ret.
 *
 * This function should be rewritten to compare all formats supported by
 * cairo_format_t instead of taking a mask as a parameter.
 */

	public static void gdTestImageDiff(gdImageStruct buf_a, gdImageStruct buf_b, gdImageStruct buf_diff, CuTestImageResult result_ret)
	{
		int x;
		int y;
		int c1;
		int c2;

		for (y = 0; y < ((buf_a).sy); y++)
		{
			for (x = 0; x < ((buf_a).sx); x++)
			{
				c1 = gd.gdImageGetTrueColorPixel(buf_a, x, y);
				c2 = gd.gdImageGetTrueColorPixel(buf_b, x, y);

				/* check if the pixels are the same */
				if (c1 != c2)
				{
					int r1;
					int b1;
					int g1;
					int a1;
					int r2;
					int b2;
					int g2;
					int a2;
					uint diff_a;
					uint diff_r;
					uint diff_g;
					uint diff_b;

					a1 = (((c1) & 0x7F000000) >> 24);
					a2 = (((c2) & 0x7F000000) >> 24);
					diff_a = (uint) Math.Abs(a1 - a2);
					diff_a *= 4; // emphasize

					if (diff_a != 0)
					{
						diff_a += 128; // make sure it's visible
					}
					if (diff_a > DefineConstants.gdAlphaMax)
					{
						diff_a = DefineConstants.gdAlphaMax / 2;
					}

					r1 = (((c1) & 0xFF0000) >> 16);
					r2 = (((c2) & 0xFF0000) >> 16);
					diff_r = (uint) Math.Abs(r1 - r2);
					// diff_r *= 4;  // emphasize
					if (diff_r != 0)
					{
						diff_r += DefineConstants.gdRedMax / 2; // make sure it's visible
					}
					if (diff_r > 255)
					{
						diff_r = 255;
					}

					g1 = (((c1) & 0x00FF00) >> 8);
					g2 = (((c2) & 0x00FF00) >> 8);
					diff_g = (uint) Math.Abs(g1 - g2);

					diff_g *= 4; // emphasize
					if (diff_g != 0)
					{
						diff_g += DefineConstants.gdGreenMax / 2; // make sure it's visible
					}
					if (diff_g > 255)
					{
						diff_g = 255;
					}

					b1 = ((c1) & 0x0000FF);
					b2 = ((c2) & 0x0000FF);
					diff_b = (uint) Math.Abs(b1 - b2);
					diff_b *= 4; // emphasize
					if (diff_b != 0)
					{
						diff_b += DefineConstants.gdBlueMax / 2; // make sure it's visible
					}
					if (diff_b > 255)
					{
						diff_b = 255;
					}

					result_ret.pixels_changed++;
					if (buf_diff != null)
						gd.gdImageSetPixel(buf_diff, x,y, (int) (((diff_a) << 24) + ((diff_r) << 16) + ((diff_g) << 8) + (diff_b)));
				}
				else
				{
					if (buf_diff != null)
						gd.gdImageSetPixel(buf_diff, x,y, (((0) << 24) + ((255) << 16) + ((255) << 8) + (255)));
				}
			}
		}
	}

	public static int gdTestImageCompareToImage(string file, uint line, string message, gdImageStruct expected, gdImageStruct actual)
	{
		uint width_a;
		uint height_a;
		uint width_b;
		uint height_b;
		gdImageStruct surface_diff = null;
	    CuTestImageResult result = new CuTestImageResult {max_diff = 0, pixels_changed = 0};

		if (actual == null)
		{
			GlobalMembersGdtest.gdTestErrorMsg(file, line, "Image is NULL\n");
			goto fail;
		}

		width_a = (uint) ((expected).sx);
		height_a = (uint) ((expected).sy);
		width_b = (uint) ((actual).sx);
		height_b = (uint) ((actual).sy);

		if (width_a != width_b || height_a != height_b)
		{
			GlobalMembersGdtest.gdTestErrorMsg(file, line, "Image size mismatch: (%ux%u) vs. (%ux%u)\n       for %s vs. buffer\n", width_a, height_a, width_b, height_b, file);
			goto fail;
		}

		surface_diff = gd.gdImageCreateTrueColor((int) width_a, (int) height_a);

		GlobalMembersGdtest.gdTestImageDiff(expected, actual, surface_diff, result);
		if (result.pixels_changed > 0)
		{
			string file_diff = new string(new char[255]);
			string file_out = new string(new char[1024]);
			IntPtr fp;
			int len;
			int p;

			GlobalMembersGdtest.gdTestErrorMsg(file, line, "Total pixels changed: %d with a maximum channel difference of %d.\n", result.pixels_changed, result.max_diff);

			p = len = file.Length;
			p--;

			/* Use only the filename (and store it in the bld dir not the src dir
			 */
			while (p > 0 && (file[p] != '/' && file[p] != '\\'))
			{
				p--;
			}
			file_diff = string.Format("{0}_{1:D}_diff.png", file + p + 1, line);
			file_out = string.Format("{0}_{1:D}_out.png", file + p + 1, line);

			fp = C.fopen(file_diff, "wb");
			if (fp == IntPtr.Zero)
				goto fail;
			gd.gdImagePng(surface_diff, new _iobuf(fp));
			C.fclose(fp);

			fp = C.fopen(file_out, "wb");
			if (fp == IntPtr.Zero)
				goto fail;
			gd.gdImagePng(actual, new _iobuf(fp));
			C.fclose(fp);
		}
		else
		{
			if (surface_diff != null)
			{
				gd.gdImageDestroy(surface_diff);
			}
			return 1;
		}

	fail:
		if (surface_diff != null)
		{
			gd.gdImageDestroy(surface_diff);
		}
		return 0;
	}

	public static int gdTestImageCompareToFile(string file, uint line, string message, string expected_file, gdImageStruct actual)
	{
		gdImageStruct expected;
		int res = 1;

		expected = GlobalMembersGdtest.gdTestImageFromPng(expected_file);

		if (expected == null)
		{
			GlobalMembersGdtest.gdTestErrorMsg(file, line, "Cannot open PNG <%s>", expected_file);
			res = 0;
		}
		else
		{
			res = GlobalMembersGdtest.gdTestImageCompareToImage(file, line, message, expected, actual);
			gd.gdImageDestroy(expected);
		}
		return res;
	}

/* Return the largest difference between two corresponding pixels and
 * channels. */

	public static uint gdMaxPixelDiff(gdImageStruct a, gdImageStruct b)
	{
		int diff = 0;
		int x;
		int y;

		if (a == null || b == null || a.sx != b.sx || a.sy != b.sy)
			return uint.MaxValue;

		for (x = 0; x < a.sx; x++)
		{
			for (y = 0; y < a.sy; y++)
			{
				int c1;
				int c2;

				c1 = gd.gdImageGetTrueColorPixel(a, x, y);
				c2 = gd.gdImageGetTrueColorPixel(b, x, y);
				if (c1 == c2)
					continue;

				diff = GlobalMembersGdtest.max(diff, Math.Abs((((c1) & 0x7F000000) >> 24) - (((c2) & 0x7F000000) >> 24)));
				diff = GlobalMembersGdtest.max(diff, Math.Abs((((c1) & 0xFF0000) >> 16) - (((c2) & 0xFF0000) >> 16)));
				diff = GlobalMembersGdtest.max(diff, Math.Abs((((c1) & 0x00FF00) >> 8) - (((c2) & 0x00FF00) >> 8)));
				diff = GlobalMembersGdtest.max(diff, Math.Abs(((c1) & 0x0000FF) - ((c2) & 0x0000FF)));
			} // for
		} // for

		return (uint) diff;
	}

	public static int gdTestAssert(string file, uint line, string message, int condition)
	{
		if (condition != 0)
			return 1;
		GlobalMembersGdtest.gdTestErrorMsg(file, line, "%s", message);

		++failureCount;

		return 0;
	}

	public static int gdTestErrorMsg(string file, uint line, string format, params object[] LegacyParamArray)
	{
	//	va_list args;
		string output_buf = new string(new char[DefineConstants.GDTEST_STRING_MAX]);

	    //	va_start(args, format);
	//	va_end(args);
        Console.WriteLine("{0}:{1}: {2}", file, line, output_buf);

		++failureCount;

		return 0;
	}

	public static void gdSilence(int priority, string format, object args)
	{
	}

	public static int gdNumFailures()
	{
		return failureCount;
	}



	internal static int max(int a, int b)
	{
	    return Math.Max(a, b);
	}


	internal static int failureCount = 0;

    public static string __FILE__
    {
        get
        {
            StackTrace stackTrace = new StackTrace(new StackFrame(true));
            StackFrame stackFrame = stackTrace.GetFrame(0);
            return stackFrame.GetFileName();
        }
    }

    public static uint __LINE__
    {
        get
        {
            StackTrace stackTrace = new StackTrace(new StackFrame(true));
            StackFrame stackFrame = stackTrace.GetFrame(0);
            return (uint) stackFrame.GetFileLineNumber();
        }
    }
}