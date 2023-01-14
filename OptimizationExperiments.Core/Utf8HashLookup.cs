namespace OptimizationExperiments.Core;

public class Utf8HashLookup
{
    private int[] _buckets;
    private Slot[] _slots;
    private int _count;

    private const int HashCodeMask = 0x7fffffff;

    public Utf8HashLookup()
    {
        _buckets = new int[7];
        _slots = new Slot[7];
    }

    public void Add(string value)
    {
        var hashCode = GetKeyHashCode(value.AsSpan());

        if (_count == _slots.Length)
        {
            Resize();
        }

        var index = _count;
        _count++;

        var bucket = hashCode % _buckets.Length;
        _slots[index].HashCode = hashCode;
        _slots[index].Key = value;
        _slots[index].Value = value;
        _slots[index].Next = _buckets[bucket] - 1;
        _buckets[bucket] = index + 1;
    }

    public bool TryGetValue(ReadOnlySpan<byte> utf8, [MaybeNullWhen(false), AllowNull] out string value)
    {
        const int stackAllocThreshold = 128;

        char[]? pooled = null;
        var count = Encoding.UTF8.GetCharCount(utf8);
        var chars = count <= stackAllocThreshold ?
            stackalloc char[stackAllocThreshold] :
            (pooled = ArrayPool<char>.Shared.Rent(count));
        var encoded = Encoding.UTF8.GetChars(utf8, chars);
        var hasValue = TryGetValue(chars[..encoded], out value);
        if (pooled is not null)
        {
            ArrayPool<char>.Shared.Return(pooled);
        }

        return hasValue;
    }

    private bool TryGetValue(ReadOnlySpan<char> key, [MaybeNullWhen(false), AllowNull] out string value)
    {
        var hashCode = GetKeyHashCode(key);

        for (var i = _buckets[hashCode % _buckets.Length] - 1; i >= 0; i = _slots[i].Next)
        {
            if (_slots[i].HashCode == hashCode && key.Equals(_slots[i].Key, StringComparison.OrdinalIgnoreCase))
            {
                value = _slots[i].Value;
                return true;
            }
        }

        value = null;
        return false;
    }

    private static int GetKeyHashCode(ReadOnlySpan<char> key)
    {
        return HashCodeMask & string.GetHashCode(key, StringComparison.OrdinalIgnoreCase);
    }

    private void Resize()
    {
        var newSize = checked(_count * 2 + 1);
        var newBuckets = new int[newSize];
        var newSlots = new Slot[newSize];
        Array.Copy(_slots, newSlots, _count);
        for (var i = 0; i < _count; i++)
        {
            var bucket = newSlots[i].HashCode % newSize;
            newSlots[i].Next = newBuckets[bucket] - 1;
            newBuckets[bucket] = i + 1;
        }
        
        _buckets = newBuckets;
        _slots = newSlots;
    }

    private record struct Slot(int HashCode, int Next, string Key, string Value);
}