namespace OptimizationExperiments.Core.Extensions;

public static class CollectionExtensions
{
    public static string? GetValue(this Dictionary<string, string?> dictionary, string? key)
    {
        return key is null
            ? default
            : CollectionsMarshal.GetValueRefOrAddDefault(dictionary, key, out _);
    }

    public static string? GetValue(this Dictionary<StringValues, StringValues> dictionary, StringValues key)
    {
	    return CollectionsMarshal.GetValueRefOrAddDefault(dictionary, key, out _);
    }
}