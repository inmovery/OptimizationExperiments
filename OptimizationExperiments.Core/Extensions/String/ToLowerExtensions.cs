namespace OptimizationExperiments.Core.Extensions.String;

public static class ToLowerExtensions
{
	public static unsafe StringValues UnsafeToLower(this string asciiString)
	{
		fixed (char* pStr = asciiString)
		{
			for (var ptr = pStr; *ptr != 0; ++ptr)
				*ptr = *ptr > 0x40 && *ptr < 0x5b ? (char)(*ptr | 0x60) : *ptr;

			return asciiString;
		}
	}
}