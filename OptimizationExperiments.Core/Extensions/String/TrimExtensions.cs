namespace OptimizationExperiments.Core.Extensions.String;

public static class TrimExtensions
{
	public static unsafe StringValues UnsafeTrim(this string source)
	{
		// TODO: fix TrimEnd
		var len = source.Length;
		fixed (char* pStr = source)
		{
			var destinationIndex = 0;
			for (var i = 0; i < len; i++)
				if (!char.IsWhiteSpace(pStr[i]))
					pStr[destinationIndex++] = pStr[i];

			return new string(pStr, 0, destinationIndex);
		}
	}

	public static unsafe string UnsafeTrimV2(this string source)
	{
		fixed (char* pStr = source)
		{
			for (var ptr = pStr; *ptr != 0; ++ptr)
				*ptr = *ptr == 0x20 ? (char)(*ptr & '\0') : *ptr;

			// TODO: Replace('\0'.ToString(), string.Empty)

			return source;
		}
	}

	public static StringValues TrimViaBytes(this string source)
	{
		var bytes = MemoryMarshal.AsBytes(source.AsSpan());
		var result = MemoryMarshal.Cast<byte, char>(bytes.Trim());

		return result.ToString();
	}

	public static ReadOnlySpan<byte> Trim(this ReadOnlySpan<byte> span)
	{
		return span.TrimStart().TrimEnd();
	}

	public static ReadOnlySpan<byte> TrimStart(this ReadOnlySpan<byte> span)
	{
		for (var i = 0; i < span.Length; i++)
		{
			ref readonly var p = ref span.At(i);
			if (p != ' ' && p != '\t' && p != '\r' && p != '\n')
			{
				return span.SliceUnsafe(i, span.Length - i);
			}
		}

		return ReadOnlySpan<byte>.Empty;
	}

	public static ReadOnlySpan<byte> TrimEnd(this ReadOnlySpan<byte> span)
	{
		for (var i = span.Length - 1; i >= 0; i--)
		{
			ref readonly var p = ref span.At(i);
			if (p != ' ' && p != '\t' && p != '\r' && p != '\n')
			{
				return span.SliceUnsafe(0, i + 1);
			}
		}

		return span;
	}
}