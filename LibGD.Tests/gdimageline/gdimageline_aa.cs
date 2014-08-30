using System;

public static class GlobalMembersGdimageline_aa
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

	#if _MSC_VER
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define snprintf _snprintf
	#define snprintf
	#endif

	public static int gen_image(string filename, int idx, int reverse_x, int DefineConstants.width, int height, int bgd)
	{
		double gradient = height / (DefineConstants.width * 2.0);
		int offset = idx * DefineConstants.width;
		int x1;
		int y1;
		int x2;
		int y2;
		int error = 0;

		gdImageStruct im = gd.gdImageCreateTrueColor(DefineConstants.width,height);
		if (bgd == 1)
		{
			gd.gdImageFilledRectangle(im,0,0,DefineConstants.width - 1,height - 1, (((0) << 24) + ((255) << 16) + ((255) << 8) + (255)));
		}
		else
		{
			gd.gdImageFilledRectangle(im,0,0,DefineConstants.width - 1,height - 1, (((0) << 24) + ((255) << 16) + ((255) << 8) + (0)));
		}

		gd.gdImageSetAntiAliased(im, (((0) << 24) + ((0) << 16) + ((0) << 8) + (0)));

		/*
		test for potential segfault (introduced with AA improvements, fixed
		with the same patch - but I didn't notice it until later).*/
		gd.gdImageLine(im,-1,-1,-1,-1,DefineConstants.gdAntiAliased);

		x1 = Math.Floor(reverse_x * -DefineConstants.width + 0.5);
		y1 = (offset - DefineConstants.width) * gradient + 0.5;

		x2 = Math.Floor(reverse_x * DefineConstants.width * 2 + 0.5);
		y2 = Math.Floor((offset + DefineConstants.width * 2) * gradient + 0.5);

		/* draw an AA line */
		gd.gdImageLine(im, x1, y1, x2, y2, DefineConstants.gdAntiAliased);

		gd.gdImageLine(im, 0, im.sy - 1, im.sx, im.sy - 1, 0x40FF0000);

	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
		if (GlobalMembersGdtest.gd.gdTestImageCompareToFile(__FILE__, __LINE__, null, (filename), (im)) == 0)
		{
	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
			(...) GlobalMembersGdtest._gd.gdTestErrorMsg(__FILE__, __LINE__, __VA_ARGS__)("gdAssertImageEqualsToFile failed: <%s>\n", filename);
			error = 1;
		}
		gd.gdImageDestroy(im);
		return error;
	}

	static int Main()
	{
		int error = 0;
		string path = new string(new char[1024]);

	#if snprintf_ConditionalDefinition1
		_snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_a_0_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#else
		snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_a_0_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#endif
		error |= GlobalMembersGdimageline_aa.gen_image(path, 0, 1, 10, 100, 1);

	#if snprintf_ConditionalDefinition1
		_snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_a_1_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#else
		snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_a_1_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#endif
		error |= GlobalMembersGdimageline_aa.gen_image(path, 1, 1, 10, 100, 2);

	#if snprintf_ConditionalDefinition1
		_snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_b_0_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#else
		snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_b_0_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#endif
		error |= GlobalMembersGdimageline_aa.gen_image(path, 2, -1, 10, 100, 1);
	#if snprintf_ConditionalDefinition1
		_snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_b_1_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#else
		snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_b_1_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#endif
		error |= GlobalMembersGdimageline_aa.gen_image(path, 1, -1, 10, 100, 2);

	#if snprintf_ConditionalDefinition1
		_snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_c_0_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#else
		snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_c_0_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#endif
		error |= GlobalMembersGdimageline_aa.gen_image(path, 0, 1, 100, 10, 1);
	#if snprintf_ConditionalDefinition1
		_snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_c_1_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#else
		snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_c_1_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#endif
		error |= GlobalMembersGdimageline_aa.gen_image(path, 1, 1, 100, 10, 2);

	#if snprintf_ConditionalDefinition1
		_snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_d_0_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#else
		snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_d_0_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#endif
		error |= GlobalMembersGdimageline_aa.gen_image(path, 2, -1, 100, 10, 1);
	#if snprintf_ConditionalDefinition1
		_snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_d_1_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#else
		snprintf(path, sizeof(sbyte) - 1, "%s/gdimageline/gdimageline_aa_d_1_exp.png", DefineConstants.GDTEST_TOP_DIR);
	#endif
		error |= GlobalMembersGdimageline_aa.gen_image(path, 1, -1, 100, 10, 2);

		return error;
	}
}

