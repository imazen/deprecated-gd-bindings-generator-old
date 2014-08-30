using LibGD;

public static class GlobalMembersGdTrivialResize
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

	/* Test gd.gdImageScale() with bicubic interpolation on a simple
	 * all-white image. */

	public static gdImageStruct mkwhite(int x, int y)
	{
		gdImageStruct im;

		im = gd.gdImageCreateTrueColor(x, y);
		gd.gdImageFilledRectangle(im, 0, 0, x - 1, y - 1, gd.gdImageColorExactAlpha(im, 255, 255, 255, 0));

	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
		GlobalMembersGdtest._gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (im != null));

		gd.gdImageSetInterpolationMethod(im, gdInterpolationMethod.GD_BICUBIC); // FP interp'n

		return im;
	} // mkwhite


	/* Fill with almost-black. */
	public static void mkblack(gdImageStruct ptr)
	{
		gd.gdImageFilledRectangle(ptr, 0, 0, ptr.sx - 1, ptr.sy - 1, gd.gdImageColorExactAlpha(ptr, 2, 2, 2, 0));
	} // mkblack


	#define CLOSE_ENOUGH

	public static void scaletest(int x, int y, int nx, int ny)
	{
		gdImageStruct im;
		gdImageStruct imref;
		gdImageStruct tmp;
		gdImageStruct same;

		imref = GlobalMembersGdnametest.mkwhite(x, y);
		im = GlobalMembersGdnametest.mkwhite(x, y);
		tmp = gd.gdImageScale(im, nx, ny);
		same = gd.gdImageScale(tmp, x, y);

		/* Test the result to insure that it's close enough to the
		 * original. */
	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
		GlobalMembersGdtest._gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (GlobalMembersGdtest.gd.gdMaxPixelDiff(im, same) < DefineConstants.CLOSE_ENOUGH));

		/* Modify the original and test for a change again.  (I.e. test
		 * for accidentally shared memory.) */
		GlobalMembersGdCopyBlurred.mkblack(tmp);
	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
		GlobalMembersGdtest._gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (GlobalMembersGdtest.gd.gdMaxPixelDiff(imref, same) < DefineConstants.CLOSE_ENOUGH));

		gd.gdImageDestroy(im);
		gd.gdImageDestroy(tmp);
		gd.gdImageDestroy(same);
	} // scaletest

	public static void do_test(int x, int y, int nx, int ny)
	{
		gdImageStruct im;
		gdImageStruct imref;
		gdImageStruct tmp;
		gdImageStruct same;
		gdImageStruct same2;

		im = GlobalMembersGdnametest.mkwhite(x, y);
		imref = GlobalMembersGdnametest.mkwhite(x, y);

		same = gd.gdImageScale(im, x, y);

		/* Trivial resize should be a straight copy. */
	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
		GlobalMembersGdtest._gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (im != same));
	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
		GlobalMembersGdtest._gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (GlobalMembersGdtest.gd.gdMaxPixelDiff(im, same) == 0));
	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
		GlobalMembersGdtest._gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (GlobalMembersGdtest.gd.gdMaxPixelDiff(imref, same) == 0));

		/* Ensure that modifying im doesn't modify same (i.e. see if we
		 * can catch them accidentally sharing the same pixel buffer.) */
		GlobalMembersGdCopyBlurred.mkblack(im);
	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
		GlobalMembersGdtest._gd.gdTestAssert(__FILE__, __LINE__, "assert failed in <%s:%i>\n", (GlobalMembersGdtest.gd.gdMaxPixelDiff(imref, same) == 0));

		gd.gdImageDestroy(same);
		gd.gdImageDestroy(im);

		/* Scale horizontally, vertically and both. */
		GlobalMembersGdTrivialResize.scaletest(x, y, nx, y);
		GlobalMembersGdTrivialResize.scaletest(x, y, x, ny);
		GlobalMembersGdTrivialResize.scaletest(x, y, nx, ny);
	}

	static int Main(string[] args)
	{

		GlobalMembersGdnametest.do_test(300, 300, 600, 600);
		GlobalMembersGdnametest.do_test(3200, 2133, 640, 427);

		return GlobalMembersGdtest.gd.gdNumFailures();
	}
}

