using System;
using LibGD;

public static class GlobalMembersGdimagestringft_bbox
{
	#if __cplusplus
	#endif
	#define GD_H
	#define GD_MAJOR_VERSION
	#define GD_MINOR_VERSION
	#define GD_RELEASE_VERSION
	#define GD_EXTRA_VERSION
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdXXX_VERSION_STR(mjr, mnr, rev, ext) mjr "." mnr "." rev ext
	#define GDXXX_VERSION_STR
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdXXX_STR(s) gd.gdXXX_SSTR(s)
	#define GDXXX_STR
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdXXX_SSTR(s) #s
	#define GDXXX_SSTR
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define GD_VERSION_STRING "GD_MAJOR_VERSION" "." "GD_MINOR_VERSION" "." "GD_RELEASE_VERSION" GD_EXTRA_VERSION
	#define GD_VERSION_STRING
	#if _WIN32 || CYGWIN || _WIN32_WCE
	#if BGDWIN32
	#if NONDLL
	#define BGD_EXPORT_DATA_PROT
	#else
	#if __GNUC__
	#define BGD_EXPORT_DATA_PROT
	#else
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_EXPORT_DATA_PROT __declspec(dllexport)
	#define BGD_EXPORT_DATA_PROT
	#endif
	#endif
	#else
	#if __GNUC__
	#define BGD_EXPORT_DATA_PROT
	#else
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_EXPORT_DATA_PROT __declspec(dllimport)
	#define BGD_EXPORT_DATA_PROT
	#endif
	#endif
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_STDCALL __stdcall
	#define BGD_STDCALL
	#define BGD_EXPORT_DATA_IMPL
	#else
	#if HAVE_VISIBILITY
	#define BGD_EXPORT_DATA_PROT
	#define BGD_EXPORT_DATA_IMPL
	#else
	#define BGD_EXPORT_DATA_PROT
	#define BGD_EXPORT_DATA_IMPL
	#endif
	#define BGD_STDCALL
	#endif
	#if BGD_EXPORT_DATA_PROT_ConditionalDefinition1
	#if BGD_STDCALL_ConditionalDefinition1
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_DECLARE (rt) rt __stdcall
	#define BGD_DECLARE
	#elif BGD_STDCALL_ConditionalDefinition2
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_DECLARE (rt) rt
	#define BGD_DECLARE
	#else
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_DECLARE (rt) rt BGD_STDCALLTangibleTempImmunity
	#define BGD_DECLARE
	#endif
	#elif BGD_EXPORT_DATA_PROT_ConditionalDefinition2
	#if BGD_STDCALL_ConditionalDefinition1
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_DECLARE (rt) rt __stdcall
	#define BGD_DECLARE
	#elif BGD_STDCALL_ConditionalDefinition2
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_DECLARE (rt) rt
	#define BGD_DECLARE
	#else
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_DECLARE (rt) rt BGD_STDCALLTangibleTempImmunity
	#define BGD_DECLARE
	#endif
	#elif BGD_EXPORT_DATA_PROT_ConditionalDefinition3
	#if BGD_STDCALL_ConditionalDefinition1
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_DECLARE (rt) __declspec(dllexport) rt __stdcall
	#define BGD_DECLARE
	#elif BGD_STDCALL_ConditionalDefinition2
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_DECLARE (rt) __declspec(dllexport) rt
	#define BGD_DECLARE
	#else
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_DECLARE (rt) __declspec(dllexport) rt BGD_STDCALLTangibleTempImmunity
	#define BGD_DECLARE
	#endif
	#elif BGD_EXPORT_DATA_PROT_ConditionalDefinition4
	#if BGD_STDCALL_ConditionalDefinition1
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_DECLARE (rt) __declspec(dllimport) rt __stdcall
	#define BGD_DECLARE
	#elif BGD_STDCALL_ConditionalDefinition2
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_DECLARE (rt) __declspec(dllimport) rt
	#define BGD_DECLARE
	#else
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_DECLARE (rt) __declspec(dllimport) rt BGD_STDCALLTangibleTempImmunity
	#define BGD_DECLARE
	#endif
	#else
	#if BGD_STDCALL_ConditionalDefinition1
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_DECLARE (rt) BGD_EXPORT_DATA_PROTTangibleTempImmunity rt __stdcall
	#define BGD_DECLARE
	#elif BGD_STDCALL_ConditionalDefinition2
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define BGD_DECLARE (rt) BGD_EXPORT_DATA_PROTTangibleTempImmunity rt
	#define BGD_DECLARE
	#else
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define Bgd.gd_DECLARE(rt) BGD_EXPORT_DATA_PROTTangibleTempImmunity rt BGD_STDCALLTangibleTempImmunity
	#define BGD_DECLARE
	#endif
	#endif
	#if __cplusplus
	#endif
	#if __cplusplus
	#endif
	#define GD_IO_H
	#if VMS
	#endif
	#if __cplusplus
	#endif
	#define gdMaxColors
	#define gdAlphaMax
	#define gdAlphaOpaque
	#define gdAlphaTransparent
	#define gdRedMax
	#define gdGreenMax
	#define gdBlueMax
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdTrueColorGetAlpha(c) (((c) & 0x7F000000) >> 24)
	#define gdTrueColorGetAlpha
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdTrueColorGetRed(c) (((c) & 0xFF0000) >> 16)
	#define gdTrueColorGetRed
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdTrueColorGetGreen(c) (((c) & 0x00FF00) >> 8)
	#define gdTrueColorGetGreen
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdTrueColorGetBlue(c) ((c) & 0x0000FF)
	#define gdTrueColorGetBlue
	#define gdEffectReplace
	#define gdEffectAlphaBlend
	#define gdEffectNormal
	#define gdEffectOverlay
	#define GD_TRUE
	#define GD_FALSE
	#define GD_EPSILON
	#define M_PI
	#define gdDashSize
	#define gdStyled
	#define gdBrushed
	#define gdStyledBrushed
	#define gdTiled
	#define gdTransparent
	#define gdAntiAliased
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gdImageCreatePalette gdImageCreate
	#define gdImageCreatePalette
	#define gdFTEX_LINESPACE
	#define gdFTEX_CHARMAP
	#define gdFTEX_RESOLUTION
	#define gdFTEX_DISABLE_KERNING
	#define gdFTEX_XSHOW
	#define gdFTEX_FONTPATHNAME
	#define gdFTEX_FONTCONFIG
	#define gdFTEX_RETURNFONTPATHNAME
	#define gdFTEX_Unicode
	#define gdFTEX_Shift_JIS
	#define gdFTEX_Big5
	#define gdFTEX_Adobe_Custom
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdTrueColor(r, g, b) (((r) << 16) + ((g) << 8) + (b))
	#define gdTrueColor
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdTrueColorAlpha(r, g, b, a) (((a) << 24) + ((r) << 16) + ((g) << 8) + (b))
	#define gdTrueColorAlpha
	#define gdArc
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gdPie gdArc
	#define gdPie
	#define gdChord
	#define gdNoFill
	#define gdEdged
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdImageTrueColor(im) ((im)->trueColor)
	#define gdImageTrueColor
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdImageSX(im) ((im)->sx)
	#define gdImageSX
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdImageSY(im) ((im)->sy)
	#define gdImageSY
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdImageColorsTotal(im) ((im)->colorsTotal)
	#define gdImageColorsTotal
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdImageRed(im, c) ((im)->trueColor ? (((c) & 0xFF0000) >> 16) : (im)->red[(c)])
	#define gdImageRed
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdImageGreen(im, c) ((im)->trueColor ? (((c) & 0x00FF00) >> 8) : (im)->green[(c)])
	#define gdImageGreen
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdImageBlue(im, c) ((im)->trueColor ? ((c) & 0x0000FF) : (im)->blue[(c)])
	#define gdImageBlue
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdImageAlpha(im, c) ((im)->trueColor ? (((c) & 0x7F000000) >> 24) : (im)->alpha[(c)])
	#define gdImageAlpha
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdImageGetTransparent(im) ((im)->transparent)
	#define gdImageGetTransparent
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdImageGetInterlaced(im) ((im)->interlace)
	#define gdImageGetInterlaced
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdImagePalettePixel(im, x, y) (im)->pixels[(y)][(x)]
	#define gdImagePalettePixel
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdImageTrueColorPixel(im, x, y) (im)->tpixels[(y)][(x)]
	#define gdImageTrueColorPixel
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdImageResolutionX(im) (im)->res_x
	#define gdImageResolutionX
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdImageResolutionY(im) (im)->res_y
	#define gdImageResolutionY
	#define GD2_CHUNKSIZE
	#define GD2_CHUNKSIZE_MIN
	#define GD2_CHUNKSIZE_MAX
	#define GD2_VERS
	#define GD2_ID
	#define GD2_FMT_RAW
	#define GD2_FMT_COMPRESSED
	#define GD_FLIP_HORINZONTAL
	#define GD_FLIP_VERTICAL
	#define GD_FLIP_BOTH
	#define GD_CMP_IMAGE
	#define GD_CMP_NUM_COLORS
	#define GD_CMP_COLOR
	#define GD_CMP_SIZE_X
	#define GD_CMP_SIZE_Y
	#define GD_CMP_TRANSPARENT
	#define GD_CMP_BACKGROUND
	#define GD_CMP_INTERLACE
	#define GD_CMP_TRUECOLOR
	#define GD_RESOLUTION
	#if __cplusplus
	#endif
	#if __cplusplus
	#endif
	#define GDFX_H
	#if __cplusplus
	#endif
	#if __cplusplus
	#endif
	#define GDTEST_TOP_DIR
	#define GDTEST_STRING_MAX
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdAssertImageEqualsToFile(ex,ac) gd.gdTestImageCompareToFile(__FILE__,__LINE__,NULL,(ex),(ac))
	#define gdAssertImageEqualsToFile
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdAssertImageFileEqualsMsg(ex,ac) gd.gdTestImageCompareFiles(__FILE__,__LINE__,(ms),(ex),(ac))
	#define gdAssertImageFileEqualsMsg
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdAssertImageEquals(tc,ex,ac) CuAssertImageEquals_LineMsg((tc),__FILE__,__LINE__,NULL,(ex),(ac))
	#define gdAssertImageEquals
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdAssertImageEqualsMsg(tc,ex,ac) CuAssertImageEquals_LineMsg((tc),__FILE__,__LINE__,(ms),(ex),(ac))
	#define gdAssertImageEqualsMsg
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdTestAssert(cond) _gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (cond))
	#define gdTestAssert
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define gd.gdTestErrorMsg(...) _gd.gdTestErrorMsg(__FILE__, __LINE__, __VA_ARGS__)
	#define gdTestErrorMsg

	#define PI
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define DELTA (PI/8)
	#define DELTA

	internal static int[,] EXPECT = {{498, 401, 630, 401, 630, 374, 498, 374}, {491, 364, 613, 313, 602, 288, 481, 338}, {470, 332, 563, 239, 544, 219, 451, 312}, {438, 310, 488, 189, 463, 178, 412, 300}, {401, 303, 401, 171, 374, 171, 374, 303}, {365, 310, 314, 188, 289, 199, 339, 320}, {334, 331, 241, 238, 221, 257, 314, 350}, {313, 362, 192, 312, 181, 337, 303, 388}, {306, 398, 174, 398, 174, 425, 306, 425}, {313, 433, 191, 484, 202, 509, 323, 459}, {333, 463, 240, 556, 259, 576, 352, 483}, {363, 484, 313, 605, 338, 616, 389, 494}, {398, 490, 398, 622, 425, 622, 425, 490}, {432, 483, 483, 605, 508, 594, 458, 473}, {461, 464, 554, 557, 574, 538, 481, 445}, {481, 435, 602, 485, 613, 460, 491, 409}};

	static int Main()
	{
		string path = new string(new char[2048]);
		gdImageStruct im;
		int black;
		double cos_t;
		double sin_t;
		int x;
		int y;
		int temp;
		int i;
		int j;
		int[] brect = new int[8];
		int error = 0;
		FILE fp;

		path = string.Format("{0}/freetype/DejaVuSans.ttf", GlobalMembersGdtest.DefineConstants.GDTEST_TOP_DIR);
		im = gd.gdImageCreate(800, 800);
		gd.gdImageColorAllocate(im, 0xFF, 0xFF, 0xFF); // allocate white for background color
		black = gd.gdImageColorAllocate(im, 0, 0, 0);
		cos_t = Math.Cos(Math.PI / 8);
		sin_t = Math.Sin(Math.PI / 8);
		x = 100;
		y = 0;
		for (i = 0; i < 16; i++)
		{
			if (gd.gdImageStringFT(im, brect, black, path, 24, Math.PI / 8 * i, 400 + x, 400 + y, "ABCDEF"))
			{
				error = 1;
				goto done;
			}
			for (j = 0; j < 8; j++)
			{
				if (brect[j] != EXPECT[i, j])
				{
					Console.Write("({0:D}, {1:D}) ({2:D}, {3:D}) ({4:D}, {5:D}) ({6:D}, {7:D}) expected, but ({8:D}, {9:D}) ({10:D}, {11:D}) ({12:D}, {13:D}) ({14:D}, {15:D})\n", EXPECT[i, 0], EXPECT[i, 1], EXPECT[i, 2], EXPECT[i, 3], EXPECT[i, 4], EXPECT[i, 5], EXPECT[i, 6], EXPECT[i, 7], brect[0], brect[1], brect[2], brect[3], brect[4], brect[5], brect[6], brect[7]);
					error = 1;
					goto done;
				}
			}
			gd.gdImagePolygon(im, (gdPoint)brect, 4, black);
			gd.gdImageFilledEllipse(im, brect[0], brect[1], 8, 8, black);
			temp = (int)(cos_t * x + sin_t * y);
			y = (int)(cos_t * y - sin_t * x);
			x = temp;
		}
		fp = fopen("gdimagestringft_bbox.png", "wb");
		if (fp == null)
		{
			error = 1;
			goto done;
		}
		gd.gdImagePng(im, fp);
		fclose(fp);
	done:
		gd.gdImageDestroy(im);
		return error;
	}
}

