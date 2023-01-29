namespace OptimizationExperiments.Core.Extensions.String;

public static class TrimExtensions
{
	private static readonly char[] EmptyCharacter = { '\0' };

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsWhiteSpace(this char ch)
	{
		switch (ch)
		{
			case '\u0009':
			case '\u000A':
			case '\u000B':
			case '\u000C':
			case '\u000D':
			case '\u0020':
			case '\u0085':
			case '\u00A0':
			case '\u1680':
			case '\u2000':
			case '\u2001':
			case '\u2002':
			case '\u2003':
			case '\u2004':
			case '\u2005':
			case '\u2006':
			case '\u2007':
			case '\u2008':
			case '\u2009':
			case '\u200A':
			case '\u2028':
			case '\u2029':
			case '\u202F':
			case '\u205F':
			case '\u3000':
				return true;
			default:
				return false;
		}
	}

	public static unsafe StringValues UnsafeTrim(this string source)
	{
		fixed (char* pStr = source)
		{
			var destinationIndex = 0;
			for (var ptr = pStr; *ptr != 0; ++ptr)
				if (!(*ptr).IsWhiteSpace())
					pStr[destinationIndex++] = *ptr;

			return new string(pStr, 0, destinationIndex);
		}
	}

	public static unsafe string UnsafeTrimV2(this string source)
	{
		fixed (char* pStr = source)
		{
			for (var ptr = pStr; *ptr != 0; ++ptr)
			{
				// TODO: Marshal.ZeroFreeGlobalAllocAnsi((IntPtr)ptr);

				*ptr = (*ptr).IsWhiteSpace() ? (char)(*ptr & '\0') : *ptr;
			}

			// TODO: Replace('\0'.ToString(), string.Empty)

			return source;
		}
	}

	public static StringValues TrimViaBytes(this string source)
	{
		var bytes = MemoryMarshal.AsBytes(source.AsSpan());

		return Encoding.ASCII.GetString(bytes.Trim());
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