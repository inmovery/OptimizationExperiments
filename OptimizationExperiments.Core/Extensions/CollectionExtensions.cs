namespace OptimizationExperiments.Core.Extensions;

public static class CollectionExtensions
{
    public static TValue? GetValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey? key) where TKey : notnull
    {
	    if (key is null)
		    return default;

	    ref var value = ref CollectionsMarshal.GetValueRefOrAddDefault(dictionary, key, out _);

        return Unsafe.IsNullRef(ref value) ? default : value;
    }
}