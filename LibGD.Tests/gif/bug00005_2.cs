using LibGD;
using NUnit.Framework;

[TestFixture]
public class GlobalMembersBug00005_2
{
	internal byte[] gifdata = {71,73,70,56,55,97,20,1,110,
			0,247,0,0,247,247,247,255,251,255,231,231,231,214,211,214,239,235,239,
			206,203,206,173,20,0,222,219,222,24,69,173,24,73,181,16,52,132,16,60,
			148,198,24,0,181,178,181,247,243,247,140,16,0,198,190,189,189,186,189,
			24,77,198,231,227,231,239,239,239,198,195,198,247,243,239,189,190,189,
			198,199,198,8,81,8,206,207,206,8,36,99,33,89,214,214,36,8,214,215,214,
			24,81,206,156,158,156,239,186,0,222,223,222,0,101,0,214,174,0,99,150,
			239,49,101,214,74,125,231,8,60,165,181,182,181,156,154,156,115,162,239,
			222,223,231,57,113,222,107,12,0,0,125,8,255,207,0,189,182,189,173,166,
			173,165,162,165,231,73,49,41,81,181,255,117,99,189,150,0,90,138,239,165,
			166,165,16,69,181,173,170,173,198,158,0,173,174,173,247,105,82,231,60,
			33,253,253,253,239,89,66,99,211,99,222,48,24,90,203,90,181,36,16,132,
			170,247,249,249,249,148,121,0,16,150,24,181,142,0,132,105,0,99,81,0,41,
			73,148,173,134,0,189,44,24,107,44,33,49,182,57,165,130,0,173,199,247,
			206,60,41,165,190,239,173,170,165,198,215,255,189,227,189,99,121,164,
			107,211,115,247,134,115,255,239,8,90,105,124,140,32,16,148,65,49,132,
			134,148,247,150,132,148,146,140,115,121,140,198,146,140,165,166,173,189,
			207,239,206,213,214,41,65,107,132,125,115,217,215,203,234,234,234,123,
			77,66,239,242,247,148,174,222,203,206,214,74,97,148,132,154,214,222,219,
			214,247,251,255,123,134,173,165,134,123,23,64,154,140,146,148,57,186,66,
			181,178,173,165,170,173,24,162,33,107,105,107,66,195,74,218,229,255,82,
			109,173,198,199,206,156,101,90,123,101,82,73,85,115,59,89,147,123,219,
			132,132,146,181,247,223,90,231,235,239,206,174,165,89,129,214,214,182,
			181,165,182,214,210,210,210,247,186,173,222,227,231,57,97,181,247,166,
			156,148,158,181,231,231,239,194,194,195,181,182,189,217,217,217,181,69,
			49,255,247,255,247,247,255,198,117,107,214,219,231,214,219,221,225,225,
			225,173,150,140,206,199,198,132,117,57,33,170,41,181,186,198,244,244,
			244,156,134,66,181,195,222,255,235,231,231,228,222,206,235,206,231,219,
			222,173,178,181,247,215,41,181,162,99,168,167,167,90,117,90,181,166,140,
			255,203,198,115,142,206,192,191,191,239,231,231,170,146,49,247,215,206,
			189,158,16,255,247,132,241,241,241,255,255,247,206,211,231,185,184,185,
			181,89,74,25,57,127,222,203,140,239,199,41,13,55,146,206,195,165,214,
			101,90,255,239,49,222,203,198,165,174,189,231,235,255,206,174,41,222,
			186,66,12,50,133,201,201,201,255,243,181,178,177,178,181,170,165,239,
			247,239,255,243,239,255,255,239,156,211,165,255,247,247,180,179,178,247,
			231,214,140,203,140,239,227,148,222,239,222,165,164,163,173,142,16,239,
			235,231,255,251,222,214,215,222,247,247,239,10,45,119,90,170,99,25,77,
			189,140,174,140,222,215,214,162,160,160,123,150,123,146,148,154,66,142,
			66,22,74,190,41,93,49,24,121,33,154,153,153,197,196,193,157,154,153,166,
			163,160,215,212,209,3,26,76,11,34,87,148,147,149,42,62,109,152,155,165,
			43,98,218,155,153,151,155,182,242,145,172,230,154,155,159,209,221,243,
			247,235,247,133,133,139,184,181,176,24,46,97,243,244,246,255,255,255,44,
			0,0,0,0,20,1,110,0,0,8,255,0,255,9,28,72,176,160,193,131,8,19,42,92,200,
			176,161,195,135,16,35,74,156,72,177,162,197,139,24,51,106,220,200,177,
			163,199,143,32,67,138,28,73,178,164,201,147,40,83,170,92,201,178,165,
			203,151,48,99,202,156,73,179,166,205,155,56,115,234,220,201,179,167,207,
			159,64,131,10,29,74,180,168,81,154,136,190,41,253,70,132,136,22,45,133,
			162,22,194,114,180,170,213,151,156,204,141,120,241,34,73,168,62,66,158,
			106,9,75,245,170,217,133,153,140,93,49,51,165,138,219,42,83,204,92,49,
			54,231,236,193,0,0,48,233,213,218,245,43,212,168,66,250,68,193,19,205,
			153,221,179,20,116,85,41,113,194,4,7,9,9,18,232,152,28,57,129,4,14,38,
			20,25,49,147,233,48,94,11,4,38,16,168,144,97,107,146,40,78,11,85,139,
			198,186,90,181,178,135,137,226,221,196,72,145,227,15,184,63,64,78,128,
			162,183,111,223,146,117,124,48,81,98,138,49,179,1,28,8,56,160,161,64,1,
			116,165,95,236,193,211,52,154,62,76,177,171,78,114,211,130,195,7,14,224,
			193,75,255,144,160,163,55,130,38,132,224,252,249,3,135,80,147,5,11,80,
			32,184,204,225,196,138,43,86,147,11,240,128,33,70,10,232,35,140,224,21,
			30,120,84,147,138,0,22,0,144,221,80,186,196,226,29,110,225,237,38,31,33,
			89,72,82,9,6,26,168,225,129,28,28,14,0,136,36,89,16,2,95,13,152,181,80,
			2,126,71,129,118,64,5,13,244,0,93,116,123,12,166,197,1,44,16,160,224,
			130,63,109,162,200,120,16,122,183,219,121,89,148,1,65,5,16,64,112,193,
			145,69,14,137,161,28,34,28,32,74,22,35,154,208,130,125,126,24,21,0,5,34,
			176,40,131,43,25,192,136,71,31,90,164,82,227,141,56,234,132,151,33,8,
			160,96,89,110,227,241,134,64,144,41,52,32,103,4,116,214,105,231,5,69,98,
			48,128,8,128,100,161,192,2,53,76,137,67,21,157,17,165,220,0,41,108,217,
			229,86,95,17,81,8,1,20,56,64,102,153,56,29,208,132,2,10,200,103,217,143,
			40,16,162,130,156,13,164,144,39,6,164,146,58,100,157,49,248,119,164,6,
			114,84,66,136,2,8,152,255,112,2,14,43,84,57,84,0,251,37,202,101,116,95,
			9,81,136,3,120,81,154,19,94,19,192,177,193,6,127,34,96,153,155,89,88,33,
			231,5,21,96,56,192,1,7,136,96,237,1,26,14,208,28,4,254,197,217,64,12,24,
			142,177,193,2,144,204,90,130,25,183,98,201,98,26,139,190,208,107,33,216,
			9,155,19,104,44,12,48,200,177,201,78,86,195,29,161,66,160,193,180,19,32,
			8,105,130,160,81,0,218,181,26,96,112,65,139,45,70,160,1,24,200,6,90,66,
			113,66,1,96,193,1,16,52,192,46,175,96,193,43,47,78,42,42,156,199,189,
			200,198,87,131,10,162,22,224,129,104,145,254,19,64,0,46,199,236,50,0,22,
			19,32,128,28,3,84,16,129,156,50,52,128,193,29,17,155,88,66,21,62,189,
			236,50,150,25,111,204,104,199,147,126,252,146,209,120,9,48,192,5,59,204,
			0,2,201,10,52,33,195,5,42,215,40,233,66,80,31,189,92,1,25,91,145,195,
			214,226,42,80,195,9,19,79,1,84,114,44,96,208,0,24,237,190,27,175,211,52,
			29,74,181,10,124,223,255,155,117,4,123,18,240,181,68,120,133,54,64,198,
			85,231,16,65,23,17,179,77,113,209,14,28,32,247,29,117,119,236,0,222,53,
			133,220,192,12,124,131,192,184,2,89,8,222,52,225,14,16,112,64,1,41,88,
			61,67,15,104,140,107,2,14,19,219,218,19,0,19,20,208,0,229,48,130,165,
			133,5,152,215,164,220,138,155,131,48,67,30,116,16,82,67,41,26,93,57,118,
			10,57,204,144,3,208,27,196,10,251,10,133,238,132,215,233,41,136,209,238,
			30,186,243,222,251,76,250,1,111,197,14,128,159,178,201,38,28,209,139,65,
			234,32,200,224,247,218,19,27,209,19,177,168,107,159,123,88,163,127,239,
			82,114,166,235,44,234,0,4,216,8,212,126,87,129,30,88,77,12,199,90,192,
			235,86,80,2,217,233,132,118,168,83,193,246,116,103,24,253,129,175,116,
			204,193,64,1,0,152,63,140,232,205,10,237,123,159,137,86,32,63,235,65,48,
			5,18,188,159,22,42,104,193,153,28,140,90,19,160,64,7,47,2,183,245,89,13,
			98,174,163,213,125,120,162,28,13,196,32,133,91,153,78,88,255,88,216,66,
			23,18,224,136,51,164,33,6,11,168,2,16,180,78,109,38,50,130,17,234,114,
			16,0,240,65,4,120,225,3,11,60,192,135,46,34,4,106,212,112,68,36,194,176,
			133,45,132,33,18,142,160,134,68,148,19,193,237,225,97,136,63,217,198,50,
			110,113,136,58,214,241,22,203,216,6,52,72,98,10,88,140,177,140,101,12,
			131,35,106,241,12,1,210,76,36,81,211,64,240,62,167,64,28,24,161,86,8,
			153,0,31,48,240,15,8,240,225,0,22,136,1,31,12,134,144,89,132,65,24,52,8,
			101,40,127,240,131,33,144,50,8,97,168,133,67,162,214,70,47,57,229,26,5,
			97,68,44,98,17,135,90,74,81,138,111,129,203,20,118,201,203,43,248,161,
			13,31,209,134,47,126,1,131,98,194,32,4,200,76,102,8,126,113,136,91,236,
			177,35,169,248,100,16,70,73,202,33,116,160,3,67,24,2,13,124,16,9,83,240,
			4,102,87,90,81,213,210,144,192,181,145,144,104,7,145,36,4,2,144,134,28,
			76,224,31,23,224,195,93,0,64,6,107,254,64,148,165,236,64,17,246,201,255,
			128,107,254,192,6,170,100,8,0,4,208,202,32,82,71,11,176,140,217,149,36,
			177,128,76,169,105,60,37,50,215,196,38,134,131,19,88,116,86,70,184,66,
			245,44,114,10,100,32,179,152,200,36,1,9,120,96,139,146,222,224,6,60,32,
			65,8,96,112,136,109,104,36,21,194,200,230,61,105,144,207,34,60,225,166,
			69,48,64,63,181,185,5,53,242,132,118,138,228,220,19,17,16,69,35,28,199,
			32,26,224,3,1,26,112,201,119,90,242,32,169,184,196,78,171,217,129,39,
			240,130,12,137,88,68,34,200,112,137,125,242,212,155,10,233,97,12,64,224,
			198,87,202,44,88,19,160,67,67,227,51,31,204,152,139,129,37,168,168,99,
			30,3,209,19,24,149,34,201,241,133,74,149,41,82,91,176,34,24,159,200,144,
			26,130,193,138,108,40,129,7,43,61,196,51,35,2,78,10,104,162,3,12,48,37,
			85,159,160,137,172,106,128,24,159,72,132,38,114,138,77,26,132,1,172,53,
			129,217,204,164,118,1,25,56,17,89,210,147,34,186,12,162,177,127,8,143,0,
			148,204,129,60,11,66,140,39,255,48,160,159,216,132,236,37,154,113,6,78,
			208,8,17,109,64,68,34,190,80,4,42,252,192,7,176,80,200,64,7,16,1,32,118,
			229,160,9,197,139,114,2,102,129,62,101,225,186,116,128,132,4,164,116,
			209,22,56,230,15,113,96,4,35,36,241,135,182,158,160,10,84,132,200,41,
			142,33,82,190,242,128,21,16,56,131,7,6,48,45,22,76,2,75,175,200,198,13,
			72,0,131,97,44,131,34,226,160,194,109,177,105,77,125,6,226,2,103,72,48,
			181,30,1,220,3,144,193,11,197,61,110,114,135,69,129,21,153,205,111,11,
			224,0,173,140,128,206,130,16,160,80,162,13,86,65,82,241,4,157,226,22,
			178,129,16,5,145,134,228,28,149,33,226,17,129,48,0,21,104,16,4,71,36,
			100,185,99,109,87,18,14,138,138,129,76,87,91,27,164,47,171,36,161,172,
			203,152,192,49,18,128,68,49,6,112,138,89,12,236,13,229,149,18,36,31,162,
			6,91,164,116,175,125,125,133,145,144,84,129,22,79,139,0,106,160,133,19,
			248,203,133,91,72,100,17,69,184,237,137,25,80,4,79,108,121,255,72,16,32,
			213,6,15,208,134,79,124,65,198,52,142,196,3,107,215,0,25,48,210,156,82,
			188,156,68,44,118,9,3,232,244,154,144,229,197,183,184,76,36,57,31,0,198,
			50,14,130,15,108,124,144,67,69,128,172,209,217,177,83,80,209,216,45,22,
			64,97,17,136,65,3,46,64,135,100,141,103,60,58,248,3,215,228,252,175,3,
			32,136,14,177,98,27,138,24,162,6,148,94,89,164,36,176,133,226,34,16,231,
			82,193,217,209,7,32,197,152,97,80,102,176,129,243,31,139,48,244,128,33,
			203,102,79,48,58,206,43,150,115,147,238,76,5,73,235,153,38,33,6,0,1,166,
			182,131,180,41,32,1,81,156,50,67,178,77,207,7,60,224,208,215,164,194,
			168,53,248,175,230,232,12,79,16,208,16,113,183,137,220,42,74,237,210,58,
			230,177,64,146,131,165,109,249,103,110,152,90,0,2,116,16,153,84,167,128,
			215,165,234,242,156,181,81,222,22,192,110,214,9,81,131,126,121,112,235,
			145,190,2,90,210,202,150,187,35,0,111,109,129,66,10,100,54,115,67,62,97,
			104,19,171,153,1,110,255,134,64,1,254,165,241,156,113,188,72,30,40,0,20,
			188,80,109,110,230,164,194,5,244,182,244,86,176,130,213,62,36,57,7,240,
			130,185,15,157,77,50,204,57,96,4,176,214,0,200,230,31,135,205,224,1,79,
			144,180,13,64,235,227,123,99,218,52,250,222,183,182,39,0,100,12,148,97,
			173,69,30,79,13,122,112,1,118,107,43,97,120,170,0,198,0,197,54,113,27,
			132,118,180,80,2,74,113,45,82,248,22,128,70,162,57,162,0,4,192,117,166,
			167,32,5,111,104,198,18,156,16,2,46,20,219,32,80,11,0,137,149,125,114,6,
			104,194,57,129,59,98,192,248,190,116,110,249,231,13,79,47,194,54,109,64,
			233,208,226,124,110,200,130,213,2,87,224,182,159,59,160,13,117,112,129,
			234,207,221,89,181,67,74,82,52,163,151,203,229,4,8,54,60,128,10,62,176,
			65,24,246,173,245,123,59,87,211,66,232,241,64,94,182,117,230,192,33,89,
			155,26,143,36,156,67,35,190,55,233,211,23,56,184,6,224,208,200,18,76,
			241,46,14,96,133,20,228,94,241,99,64,192,3,53,74,208,255,141,10,183,28,
			13,64,192,91,128,0,197,18,110,64,108,46,252,119,158,0,8,196,185,77,126,
			219,75,0,98,101,71,28,156,116,199,118,126,57,97,192,246,81,103,3,0,101,
			19,112,195,34,16,131,41,8,80,31,60,215,97,227,134,65,80,160,122,46,96,
			110,69,208,1,52,48,38,5,17,123,82,131,56,162,144,6,46,240,4,52,32,128,
			201,149,109,86,167,99,168,17,124,136,7,0,20,48,11,197,128,124,18,144,27,
			89,160,50,175,39,41,178,231,63,16,0,6,106,227,56,165,71,16,201,17,12,82,
			224,4,135,69,119,36,144,8,43,51,56,5,129,23,203,133,56,217,195,4,32,71,
			108,195,128,16,52,147,8,67,71,127,12,208,12,156,48,1,68,168,131,52,115,
			111,13,176,3,49,144,122,52,151,123,91,112,55,50,81,128,160,23,112,245,
			81,2,43,192,128,11,97,49,181,35,8,16,24,129,58,53,4,226,160,92,164,213,
			34,98,224,2,95,104,3,91,112,129,190,71,130,68,96,130,111,71,1,197,130,
			124,185,193,1,162,112,10,54,130,133,203,85,64,183,227,58,104,255,184,2,
			192,52,124,14,48,1,180,208,131,115,183,87,200,192,9,8,178,134,22,112,
			111,59,96,54,76,176,126,133,119,120,4,97,49,143,240,5,243,183,108,12,
			192,11,154,40,104,9,1,55,220,102,54,80,0,117,65,32,128,157,55,134,3,229,
			67,7,248,39,28,224,112,214,247,16,203,117,1,61,32,6,130,240,128,112,200,
			0,52,16,9,133,116,23,234,210,0,32,52,139,1,104,3,19,38,16,203,133,111,
			153,86,130,194,119,129,181,131,6,132,136,27,138,96,129,136,23,57,114,
			195,57,17,163,67,83,0,53,218,22,1,72,96,137,41,149,76,193,176,137,227,
			102,1,181,195,60,101,32,8,131,71,102,195,176,88,51,67,0,205,16,133,39,
			214,1,137,208,50,13,40,57,155,147,3,108,224,2,154,167,135,91,64,117,49,
			1,65,23,144,54,2,183,93,22,181,2,192,40,0,65,197,55,42,144,6,108,240,
			128,15,208,79,158,197,144,212,120,111,57,80,6,179,152,144,54,112,109,33,
			57,0,63,228,135,128,88,138,88,162,7,1,55,31,223,241,1,110,144,136,243,
			180,109,84,255,131,64,55,72,66,70,112,35,218,22,108,235,232,4,251,181,
			87,199,16,67,192,136,147,86,80,143,76,128,4,60,208,126,214,144,109,4,0,
			99,254,136,104,84,128,73,171,68,59,83,35,3,6,137,135,213,182,5,156,87,
			19,16,180,56,37,51,31,82,98,34,15,161,55,50,128,145,159,210,0,117,128,
			138,6,224,79,91,48,141,251,134,115,61,144,3,15,88,92,185,103,3,203,248,
			15,213,120,117,93,81,130,176,161,117,245,2,52,166,6,30,38,112,6,135,244,
			69,23,99,59,132,73,84,214,183,2,44,64,141,19,128,1,75,176,142,63,152,76,
			190,96,147,13,113,37,89,178,57,105,176,148,55,48,138,77,56,16,160,81,1,
			66,119,110,184,85,116,9,242,115,4,16,55,73,233,134,180,168,144,153,115,
			111,198,82,152,142,161,8,171,132,65,253,97,54,86,195,133,52,178,8,154,
			224,5,68,55,105,227,71,59,114,67,146,231,86,109,54,224,3,1,197,151,219,
			214,92,44,25,152,46,115,49,26,0,145,9,120,100,138,160,153,78,56,153,101,
			184,115,43,160,11,206,41,2,175,255,80,153,62,216,142,200,164,6,233,229,
			16,185,232,153,161,168,4,100,198,5,62,165,109,44,224,9,17,136,154,216,
			68,74,196,144,68,149,38,53,41,160,7,176,153,144,94,153,10,23,52,143,220,
			152,44,223,1,30,184,153,155,229,215,31,91,216,51,42,87,35,14,86,104,135,
			246,145,2,97,145,49,96,151,231,22,128,62,176,8,3,81,141,191,7,152,23,
			184,109,16,224,109,9,208,139,45,16,7,210,32,80,22,154,54,222,233,54,180,
			115,6,117,64,158,251,245,81,191,48,9,250,249,118,56,185,3,159,121,143,
			78,41,153,103,16,8,245,25,135,167,36,0,233,217,16,193,216,3,255,137,123,
			94,121,139,79,35,143,5,192,58,127,178,0,9,112,160,31,16,11,16,161,31,19,
			32,2,27,71,39,101,231,98,136,0,156,57,213,79,63,176,5,106,208,6,44,112,
			1,200,105,0,209,136,146,125,25,157,5,193,70,15,137,47,177,118,2,140,208,
			16,108,36,150,176,114,134,67,147,11,166,147,126,50,186,87,48,224,11,55,
			138,120,21,6,1,58,26,138,195,70,108,135,192,151,21,255,86,0,7,57,116,
			157,69,3,154,48,7,131,202,123,225,4,1,170,0,155,145,38,128,187,55,134,
			88,242,51,49,41,28,224,241,1,113,64,56,218,38,0,34,16,115,239,150,36,
			255,210,96,92,101,114,87,213,159,66,167,166,31,168,123,90,247,156,31,
			250,135,129,25,0,78,10,122,168,37,43,56,240,6,70,90,59,35,131,128,189,
			56,49,85,16,140,234,135,4,66,9,168,190,64,17,22,32,2,73,131,168,77,73,
			108,171,192,151,247,198,145,172,55,83,137,48,17,1,208,6,24,147,169,112,
			24,141,91,224,61,45,1,53,141,58,6,49,57,165,163,234,6,20,17,123,20,176,
			28,49,71,54,44,182,65,44,16,92,192,169,9,188,208,85,95,32,8,179,234,129,
			185,215,169,206,201,92,185,42,4,187,234,164,121,0,61,162,135,3,56,0,158,
			2,85,59,48,153,44,189,104,81,165,0,65,13,176,4,127,186,82,48,160,6,208,
			26,174,203,234,4,136,101,173,124,201,103,218,90,4,218,20,4,65,64,12,29,
			139,169,143,170,166,181,40,128,149,74,18,1,32,162,175,2,31,50,255,25,30,
			62,135,87,0,240,99,219,82,175,46,166,32,203,165,49,67,7,176,62,32,176,
			218,166,146,5,187,171,205,120,90,209,3,172,232,3,54,253,102,131,127,50,
			165,101,105,6,210,32,57,57,16,138,204,138,88,43,245,11,218,176,178,170,
			240,177,33,11,3,171,208,13,224,138,1,50,80,178,39,235,3,167,0,182,45,
			235,129,2,104,3,230,186,63,71,91,6,235,218,130,222,97,2,147,144,17,159,
			17,26,204,81,0,141,166,65,3,80,133,173,153,51,242,151,161,244,102,180,
			125,120,141,186,170,141,5,228,103,229,52,43,14,171,16,225,84,0,53,59,
			112,7,106,2,2,32,142,89,75,173,26,251,11,174,120,165,14,16,55,97,75,158,
			99,187,10,22,80,168,118,89,159,69,240,3,82,71,1,222,42,142,105,59,174,
			155,231,3,1,244,15,180,193,75,114,113,5,188,219,187,188,187,187,14,132,
			17,64,87,157,81,90,100,51,153,160,2,228,0,178,215,28,142,118,45,5,32,10,
			182,199,122,137,123,171,72,235,166,195,7,84,155,131,64,65,131,3,200,3,
			54,166,3,147,54,255,219,130,222,40,13,20,144,149,76,16,138,82,112,186,
			49,171,131,72,147,3,24,139,4,135,165,177,168,91,190,165,85,178,174,235,
			3,229,122,165,224,52,186,24,128,161,210,155,123,182,43,16,143,240,42,
			109,229,139,60,199,64,21,213,2,10,76,37,201,131,115,151,18,190,120,75,
			147,31,65,124,161,145,170,243,53,45,56,131,182,167,249,150,52,22,4,108,
			186,184,166,1,162,165,200,159,86,195,56,227,210,139,238,74,185,218,166,
			6,199,39,112,201,39,1,21,155,163,130,224,185,197,116,8,27,101,122,113,
			163,2,149,41,5,51,90,76,191,208,137,204,181,186,17,216,186,62,128,191,
			120,197,191,119,8,169,247,107,3,192,162,32,4,112,124,100,105,31,183,196,
			24,222,101,152,82,22,188,222,106,58,134,80,188,145,33,190,31,48,185,2,
			164,117,228,55,121,56,83,1,117,16,133,29,224,186,65,192,161,212,184,109,
			43,201,184,6,91,132,133,186,3,125,19,49,175,19,186,132,58,11,134,96,179,
			4,87,112,127,96,1,64,28,1,59,48,195,149,25,154,53,188,190,195,135,115,
			49,255,202,172,61,12,3,200,144,139,49,160,10,7,57,196,199,85,180,239,
			138,37,128,0,164,74,140,178,54,0,0,202,115,49,151,146,128,14,71,66,60,
			23,11,127,0,9,53,144,202,36,242,29,43,112,84,20,193,70,151,219,197,185,
			209,2,136,236,173,158,172,188,130,120,56,168,104,159,51,213,156,71,11,
			157,112,44,157,188,90,59,99,213,68,34,164,134,23,104,1,21,208,4,190,161,
			44,147,1,195,52,35,162,135,10,154,26,187,168,89,124,56,203,202,195,206,
			250,15,22,138,164,171,71,196,150,124,205,16,176,203,134,150,198,161,20,
			6,115,144,116,204,33,7,140,35,165,245,1,59,56,224,6,64,182,114,9,118,6,
			111,80,10,140,80,10,55,188,153,71,163,199,92,204,35,184,145,194,40,161,
			28,243,57,149,167,116,187,3,11,204,33,220,184,69,40,162,156,19,66,39,
			124,2,16,87,16,185,240,6,53,208,204,205,44,9,54,130,130,30,32,140,98,
			112,190,75,224,158,53,92,164,14,113,40,23,107,153,230,25,2,79,185,31,73,
			243,205,53,39,176,87,106,177,27,60,85,63,255,176,8,115,192,127,120,186,
			0,219,53,37,39,10,1,28,167,65,154,184,151,22,161,109,5,240,30,46,124,
			106,120,123,0,41,65,44,103,224,150,38,70,96,154,0,149,4,107,189,46,179,
			191,243,168,58,49,160,174,177,86,5,120,44,16,140,112,209,240,17,31,190,
			65,7,53,226,50,145,115,1,32,4,210,75,200,82,181,60,178,103,224,9,59,124,
			153,200,116,10,87,114,166,207,168,122,145,102,196,166,58,1,48,58,149,50,
			149,10,3,181,34,59,243,57,121,90,150,113,112,1,162,134,39,119,23,67,93,
			125,165,41,232,39,2,167,44,47,28,7,109,125,17,22,48,9,158,224,143,59,
			213,1,139,32,213,10,253,151,12,93,132,139,201,60,171,83,0,146,32,122,
			108,51,5,126,48,9,147,64,27,138,80,30,97,13,31,127,98,8,106,176,185,71,
			35,78,178,117,190,76,185,82,171,80,203,188,122,0,111,64,10,204,42,119,
			237,21,2,200,144,9,223,42,57,175,185,122,0,107,3,251,60,110,224,250,6,
			228,140,110,29,32,12,117,97,177,59,64,216,215,105,81,110,64,54,165,255,
			178,65,34,176,185,149,141,23,20,192,80,145,253,194,151,49,0,149,93,17,
			40,216,212,169,184,108,84,32,0,165,232,198,126,121,26,161,29,162,30,192,
			34,73,153,2,226,0,147,53,32,43,143,184,2,56,208,2,31,144,0,178,141,41,
			10,0,7,101,240,9,7,96,163,211,201,103,32,240,209,237,201,219,221,32,17,
			124,122,0,121,128,4,140,124,101,200,20,12,51,3,225,119,56,196,155,135,
			208,21,121,0,253,248,222,136,214,173,216,202,92,144,107,172,190,200,8,
			77,50,45,213,34,2,140,93,17,188,250,6,239,49,112,149,113,106,58,16,7,
			171,121,18,223,138,8,242,87,114,106,6,89,100,48,41,191,156,180,9,241,59,
			114,211,3,61,16,1,114,80,106,255,189,97,70,80,2,45,32,1,40,128,224,104,
			0,7,119,144,7,16,192,65,189,135,40,86,51,195,76,48,108,238,183,70,2,192,
			13,172,48,220,151,72,2,199,176,183,255,112,40,236,51,201,52,39,105,205,
			121,150,2,240,163,154,125,91,84,128,8,251,102,58,131,29,122,9,136,131,
			169,75,1,20,112,68,175,255,135,200,217,38,2,144,32,31,58,158,124,58,0,9,
			7,176,222,239,74,79,37,39,133,29,32,7,103,117,180,57,22,204,202,213,63,
			59,147,2,71,130,6,128,18,110,113,32,9,116,48,6,170,126,7,32,96,5,162,82,
			219,161,139,130,7,128,214,17,14,210,161,201,5,214,48,104,19,160,142,219,
			103,107,184,22,12,55,66,190,89,25,225,204,157,103,186,30,1,179,42,133,
			137,64,69,156,201,34,218,125,134,61,87,132,151,35,98,131,70,0,127,224,
			232,143,222,38,9,32,10,218,73,18,52,67,6,151,222,120,12,112,228,177,62,
			130,158,78,135,7,192,92,114,146,2,161,172,167,56,240,45,102,211,60,61,
			224,229,3,128,32,162,181,111,189,202,57,159,169,132,252,53,12,235,27,0,
			173,173,125,189,78,113,41,133,12,54,57,204,79,106,53,124,160,122,117,
			110,3,176,203,154,44,192,11,243,71,127,188,112,240,159,247,236,109,151,
			179,26,49,11,89,32,31,125,220,199,193,97,8,70,137,18,150,206,120,141,
			119,9,44,128,199,109,122,238,148,219,168,49,96,54,220,8,40,178,255,114,
			2,45,96,8,13,112,54,174,174,114,154,104,1,247,94,117,135,243,208,132,
			172,4,133,151,235,185,41,92,61,200,125,4,111,11,159,64,132,71,248,208,
			143,170,121,53,54,110,251,219,6,153,29,238,183,85,4,75,63,126,88,82,0,
			121,128,241,104,168,241,24,97,237,106,82,112,149,17,28,89,0,230,20,241,
			12,176,176,190,179,32,12,226,126,114,69,176,8,221,206,233,32,128,14,1,2,
			218,113,60,110,251,113,1,121,32,181,238,44,37,38,96,8,17,32,42,26,116,0,
			53,206,140,157,201,57,42,192,6,160,217,95,46,181,153,14,160,1,217,224,
			131,39,85,249,55,144,8,246,158,200,34,96,59,15,253,128,94,0,176,62,37,
			80,0,240,9,57,117,233,37,247,10,240,40,16,209,202,245,140,52,232,95,207,
			17,220,0,9,32,47,25,149,145,38,127,80,0,143,64,68,140,133,108,194,224,8,
			55,74,79,182,213,120,166,79,6,35,63,223,42,9,2,1,98,26,141,34,157,95,52,
			186,5,160,7,70,221,86,101,233,6,233,94,45,49,52,183,246,54,53,61,208,68,
			139,255,191,148,77,57,154,95,4,78,115,112,0,180,96,249,150,255,10,155,
			48,247,164,149,150,124,227,249,79,240,79,41,106,108,81,101,250,37,87,7,
			162,113,239,205,222,0,94,31,237,25,145,11,110,64,30,0,145,64,160,14,129,
			2,17,160,128,164,108,2,174,35,255,28,62,132,24,81,226,191,0,255,22,21,
			161,18,6,214,179,136,1,28,16,35,67,133,193,72,146,6,76,158,172,195,137,
			0,0,137,1,4,28,192,64,110,196,204,17,47,246,68,193,131,101,98,75,0,22,
			42,213,64,129,64,168,4,14,45,78,224,56,99,129,194,82,7,59,37,90,152,160,
			161,193,12,21,32,100,128,98,34,133,71,136,67,208,156,62,60,64,75,201,88,
			178,99,95,157,153,64,97,162,5,17,5,166,170,152,145,131,141,11,47,79,126,
			216,48,245,213,33,177,75,39,253,26,168,163,70,128,131,138,14,3,80,56,80,
			33,79,151,13,27,20,44,144,96,2,71,9,51,122,45,59,228,166,136,160,4,9,6,
			133,30,68,241,103,157,28,10,13,47,79,12,0,64,245,63,98,69,12,48,24,18,
			196,198,255,150,45,154,132,253,232,64,114,228,95,148,7,88,168,149,136,
			233,0,132,112,233,104,214,124,145,100,143,150,211,185,220,36,64,64,48,1,
			231,162,39,226,56,0,48,135,229,233,127,0,8,36,158,106,85,84,154,37,72,
			182,174,90,230,212,129,47,91,55,200,58,145,226,36,219,171,2,7,40,52,149,
			152,235,123,133,240,59,98,4,114,225,129,39,98,115,196,41,0,200,112,237,
			175,7,188,168,163,62,236,10,163,136,2,17,20,99,172,49,5,16,168,193,168,
			202,184,155,232,145,56,58,227,172,32,161,236,88,160,196,44,40,57,128,33,
			14,121,178,160,197,127,196,249,226,1,147,116,99,32,183,221,20,124,96,65,
			79,222,56,96,37,136,60,248,198,28,115,210,121,129,166,12,142,156,41,185,
			61,116,210,11,128,88,164,43,72,7,162,76,104,65,151,21,33,2,64,0,15,32,
			152,106,134,30,0,105,6,20,36,148,32,33,132,85,110,217,198,171,0,44,160,
			198,151,99,120,112,207,9,248,164,144,130,20,43,0,241,192,71,212,178,220,
			178,129,28,188,124,35,135,24,139,232,32,182,72,255,106,49,37,53,10,106,
			33,163,47,191,114,124,224,139,28,240,20,96,187,135,214,156,112,177,198,
			44,196,208,4,35,44,229,16,0,93,98,225,64,74,17,71,44,81,129,38,192,88,
			199,62,32,174,236,200,2,2,4,152,96,130,44,235,240,34,71,222,78,130,20,
			82,47,2,185,211,131,74,33,236,46,26,227,140,60,50,217,12,144,219,227,
			154,175,8,200,2,133,129,10,74,64,202,15,220,128,245,82,7,4,24,128,63,25,
			100,104,160,128,1,94,161,69,138,27,120,40,243,151,95,144,121,19,78,37,
			232,68,34,94,82,196,168,164,130,1,6,251,202,35,45,185,252,182,129,55,60,
			240,228,139,25,97,251,129,6,42,68,98,128,87,72,191,168,163,222,123,241,
			131,8,83,10,55,232,167,226,13,122,233,20,135,42,252,152,195,178,0,8,48,
			35,142,22,62,248,160,51,207,16,40,113,129,199,224,104,229,147,20,129,
			120,53,91,135,84,19,64,4,15,6,24,224,128,73,52,168,3,138,94,127,206,49,
			64,47,216,80,193,97,124,47,245,8,19,1,194,33,135,28,87,158,134,218,149,
			52,255,200,9,39,156,106,80,113,106,19,72,164,165,246,51,161,106,136,195,
			141,82,204,240,163,141,43,83,211,178,130,20,122,232,33,5,12,88,152,32,
			24,86,196,26,235,6,187,223,149,34,94,36,64,153,87,15,135,39,176,96,39,8,
			245,237,118,237,182,223,158,32,145,64,4,222,181,215,161,235,240,219,94,
			91,81,99,171,130,29,64,0,163,139,65,228,217,192,27,199,16,152,242,132,
			18,140,152,194,140,43,78,191,194,140,42,220,136,229,4,14,72,54,217,179,
			84,21,160,157,144,59,248,81,166,147,81,96,150,249,210,44,69,24,160,128,
			10,134,23,183,2,79,2,97,3,10,229,151,87,158,141,52,64,136,220,3,192,35,
			246,238,165,3,14,40,224,130,30,64,224,158,123,25,98,208,64,207,157,184,
			1,170,218,83,83,46,17,5,41,57,160,18,135,21,170,184,34,147,203,2,208,
			215,131,236,27,104,160,94,13,88,160,245,147,68,88,153,27,45,72,49,64,82,
			212,65,12,42,208,67,219,240,4,56,80,57,165,126,24,136,0,254,26,0,129,1,
			76,0,17,44,88,4,25,52,193,139,255,47,116,176,131,108,8,68,29,160,215,54,
			201,137,47,98,22,96,1,6,122,48,14,22,178,176,28,119,232,2,33,154,176,0,
			105,113,134,100,55,196,33,103,98,7,29,161,204,142,118,10,32,4,24,100,16,
			1,119,76,96,119,189,235,200,182,14,112,134,236,69,80,130,107,147,1,8,
			196,48,69,49,112,175,12,57,248,158,189,6,3,42,125,97,111,120,92,178,66,
			92,196,8,46,12,244,168,129,15,97,65,249,160,212,67,149,53,193,141,110,4,
			141,64,36,240,1,19,156,192,8,87,56,35,79,190,163,129,10,68,192,143,16,
			168,128,6,6,240,136,71,176,128,27,76,188,64,10,84,161,135,43,238,32,15,
			23,168,15,1,28,32,191,211,172,233,59,221,242,99,4,32,128,1,113,17,242,
			17,156,176,31,4,42,177,200,111,57,18,146,121,194,142,224,28,48,129,2,
			196,64,6,227,192,7,11,119,176,139,64,106,64,20,134,248,131,12,105,136,2,
			94,122,237,51,40,72,217,15,127,136,134,65,140,65,12,173,96,134,50,236,
			115,132,152,33,49,98,74,196,36,254,174,216,61,106,206,255,224,138,89,
			212,192,4,36,217,18,11,188,100,0,124,244,227,5,36,136,191,71,70,242,140,
			31,219,26,2,186,134,178,5,172,42,7,110,27,192,25,0,81,12,67,100,129,16,
			7,73,0,251,90,80,130,41,228,49,34,0,160,192,4,14,160,129,2,64,0,144,21,
			192,64,66,49,80,129,11,56,81,6,59,192,31,4,196,165,77,179,93,9,0,171,28,
			40,4,15,186,73,225,49,52,130,15,77,96,10,32,89,65,19,114,147,0,246,107,
			64,10,118,176,210,29,200,96,23,178,40,128,7,78,113,10,17,216,82,18,245,
			132,131,12,103,104,135,94,8,147,118,104,32,102,23,140,217,138,86,76,67,
			22,141,48,98,51,157,217,17,239,28,192,126,16,196,95,75,165,138,69,252,
			213,139,71,218,204,163,162,190,227,1,13,116,213,171,94,21,215,1,182,248,
			207,110,208,65,1,210,90,35,48,225,160,2,44,198,0,2,255,146,233,44,180,
			113,10,64,208,97,134,53,168,163,251,174,224,177,139,78,0,120,5,40,232,
			240,134,151,201,24,252,241,173,30,224,31,196,96,133,182,9,200,33,120,
			255,5,61,104,31,35,16,131,6,24,246,95,218,12,156,199,182,197,9,75,20,64,
			25,178,216,69,104,35,32,11,89,172,163,2,202,168,0,32,148,161,1,119,104,
			0,181,160,101,36,8,94,88,142,122,196,227,128,112,105,197,44,97,42,14,1,
			80,0,0,74,93,170,68,104,38,208,199,106,212,160,195,227,100,206,4,48,86,
			193,1,84,0,179,90,46,116,103,53,43,192,89,160,129,169,121,67,137,212,41,
			34,96,102,97,7,84,141,193,5,18,138,208,133,106,64,14,90,162,67,137,32,
			113,148,18,84,193,159,212,163,192,5,157,10,86,192,214,247,95,34,208,102,
			73,23,155,26,232,94,15,103,245,5,240,101,171,251,94,158,224,98,13,107,
			152,64,39,14,48,128,70,104,224,19,148,128,64,4,82,192,15,102,228,33,15,
			204,96,219,52,26,48,13,102,236,192,10,173,120,40,51,68,204,140,93,68,
			160,2,141,176,132,54,71,193,76,224,6,151,39,14,144,21,11,68,32,130,235,
			249,70,4,112,163,85,139,8,252,79,213,88,183,39,63,78,13,0,136,69,63,7,
			64,235,49,66,49,255,8,10,86,149,135,240,138,55,161,29,189,64,132,53,9,
			73,17,92,160,9,10,168,129,232,70,7,28,203,92,52,198,19,128,155,140,113,
			60,96,23,35,13,198,212,149,241,140,225,134,95,2,172,36,59,30,235,72,0,
			128,112,81,0,224,130,2,4,56,176,0,58,161,96,6,23,128,18,159,56,109,5,40,
			97,218,10,144,150,120,26,240,192,1,58,177,6,10,172,152,119,101,230,142,
			106,122,162,148,165,244,88,53,29,131,52,83,119,118,229,5,108,23,58,53,0,
			65,12,2,153,179,26,115,181,171,24,128,192,5,26,58,89,225,161,1,203,90,
			94,1,166,231,7,227,158,220,71,210,214,205,116,75,104,61,233,251,248,56,
			53,217,42,12,16,88,12,51,97,31,193,216,71,24,133,172,160,75,43,22,88,
			162,19,44,224,196,1,68,208,9,1,172,129,0,163,0,192,176,31,157,107,110,
			67,122,77,44,40,6,237,58,45,37,29,212,160,12,35,213,230,82,238,76,128,
			52,131,178,0,78,132,40,4,202,176,129,5,64,98,50,163,235,118,190,245,189,
			111,126,247,123,177,124,186,131,99,255,58,61,29,9,72,66,162,34,112,51,
			245,176,67,0,191,14,0,170,223,138,0,99,154,176,207,21,148,96,175,254,
			198,120,198,53,190,113,103,42,10,123,96,16,248,116,62,64,135,79,220,203,
			183,249,2,232,119,178,183,61,25,4,252,213,43,88,129,17,56,62,115,154,
			215,220,230,221,225,86,5,198,32,240,57,154,224,2,98,125,51,95,17,163,
			129,8,244,64,5,42,112,53,2,246,105,132,21,88,233,230,79,135,122,212,93,
			172,180,236,129,252,49,68,81,132,28,8,144,89,238,28,6,123,111,65,3,189,
			37,3,243,42,72,221,236,103,71,187,94,82,195,202,20,184,28,50,28,136,195,
			74,100,205,157,109,121,192,114,72,167,119,150,97,142,173,180,247,221,
			239,102,95,187,91,64,16,118,200,152,192,13,210,216,177,97,34,230,17,86,
			54,96,240,143,201,80,9,98,158,248,191,87,222,242,249,6,64,227,101,48,8,
			199,224,149,239,176,162,25,209,85,32,238,200,76,38,14,151,71,125,234,
			251,157,121,183,228,192,234,8,48,193,233,101,150,165,110,141,225,200,
			145,49,138,236,85,191,255,123,222,79,93,0,173,228,30,231,23,192,129,19,
			84,244,108,124,178,242,237,217,103,120,138,244,222,249,207,95,17,218,60,
			112,129,63,169,160,243,38,96,196,236,5,32,135,44,104,215,90,31,224,64,
			101,136,5,125,242,151,63,86,41,148,42,200,23,144,33,63,0,155,0,134,8,
			138,167,57,163,136,110,152,223,254,247,55,204,182,6,224,202,33,238,28,
			50,39,104,191,232,35,128,88,240,26,243,17,136,82,192,191,4,44,63,143,
			115,11,47,41,0,179,130,140,22,152,2,14,201,133,82,128,132,83,249,37,67,
			176,0,197,82,192,14,84,61,194,209,158,6,136,1,53,208,131,25,34,10,28,
			152,2,14,140,136,110,120,4,55,104,1,9,32,8,175,225,37,20,200,2,17,224,
			50,15,196,193,212,251,54,162,139,168,5,235,62,20,152,163,22,192,1,35,
			168,2,211,73,29,70,96,157,22,120,29,147,97,163,148,161,131,135,201,193,
			40,212,65,196,40,168,63,242,0,109,16,5,56,160,33,130,195,161,46,44,25,
			30,242,33,66,0,1,151,209,47,41,52,67,180,243,58,225,113,43,255,72,154,0,
			1,168,171,25,10,138,130,208,33,29,2,67,149,89,0,56,0,131,6,208,34,202,
			59,195,62,164,57,180,169,41,201,2,36,243,210,146,91,250,131,26,168,1,
			161,224,26,207,112,35,56,24,131,59,176,2,81,147,30,174,243,195,74,4,60,
			231,178,187,40,251,35,192,26,0,174,194,0,81,40,134,155,50,4,58,32,69,48,
			184,131,3,186,162,72,172,128,73,180,196,86,68,59,154,89,48,53,84,53,63,
			106,50,90,76,169,30,8,163,63,137,11,83,18,151,163,113,197,95,140,58,69,
			105,172,224,25,44,9,115,162,6,144,1,61,40,165,135,2,23,77,154,168,74,1,
			198,104,148,58,254,178,158,255,242,168,201,74,129,108,100,178,40,3,44,
			196,202,47,62,148,198,112,244,55,213,152,21,26,115,42,156,65,71,116,244,
			0,233,249,70,112,20,199,119,236,54,8,185,53,165,104,179,233,98,56,2,80,
			55,10,192,53,120,228,199,202,147,180,95,235,199,128,20,200,129,36,200,
			142,107,190,230,27,191,130,84,200,124,57,200,133,116,200,135,132,200,
			129,172,136,194,152,200,8,136,180,200,139,196,200,128,0,59
};

    [Test]
    public unsafe void TestBug00005_2()
    {
        gdImageStruct im;
        fixed (void* gitPtr = this.gifdata)
        {
            if ((im = gd.gdImageCreateFromGifPtr(8994, gitPtr)) != null)
            {
                gd.gdImageDestroy(im);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}

