namespace OptimizationExperiments.Core.Extensions;

public static class Base64Extensions
{
    public static string? DecodeBase64(this string? base64Source)
    {
        if (string.IsNullOrEmpty(base64Source))
            return default;

        var encodedBytesCount = EstimateDecodedSize(base64Source.Length);
        Span<byte> decodedSource = stackalloc byte[encodedBytesCount];

        var isDecodingResult = Convert.TryFromBase64Chars(base64Source, decodedSource, out var bytesWritten);
        return isDecodingResult
            ? Encoding.UTF8.GetString(decodedSource.Slice(0, bytesWritten))
            : default;
    }

    public static string? EncodeToBase64(this string? utf8Source)
    {
        if (string.IsNullOrEmpty(utf8Source))
            return default;

        var bytesCount = Encoding.UTF8.GetByteCount(utf8Source);
        Span<byte> sourceAsSpan = stackalloc byte[bytesCount];
        Encoding.UTF8.GetBytes(utf8Source, sourceAsSpan);
        
        var encodedCharsCount = EstimateEncodedSize(sourceAsSpan.Length);
        Span<char> encodedBase64 = stackalloc char[encodedCharsCount];
        
        var isEncodingResult = Convert.TryToBase64Chars(sourceAsSpan, encodedBase64, out var bytesWritten);

        return isEncodingResult
            ? new string(encodedBase64.Slice(0, bytesWritten))
            : default;
    }

    private static int EstimateEncodedSize(int inputSize)
    {
        if (inputSize == 0)
            return 0;
        
        var encodedSize = (4 * inputSize / 3 + 3) & ~ 3;

        return encodedSize;
    }

    private static int EstimateDecodedSize(int inputSize)
    {
        if (inputSize == 0)
            return 0;

        var decodedSize = inputSize * 3 / 4;

        return decodedSize;
    }
}