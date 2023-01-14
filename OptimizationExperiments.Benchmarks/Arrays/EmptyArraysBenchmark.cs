namespace OptimizationExperiments.Benchmarks.Arrays;

[Config(typeof(MemoryPerformanceConfig))]
public class EmptyArraysBenchmark
{
    [Benchmark(Baseline = true)]
    public string[] ReturnEmptyArray()
    {
        return Array.Empty<string>();
    }

    [Benchmark]
    public StringValues ReturnStringValuesFromEmptyArray()
    {
        return new StringValues(new List<string>().ToArray());
    }

    [Benchmark]
    public List<string> ReturnEmptyList()
    {
        return new List<string>();
    }

    [Benchmark]
    public IList<string> ReturnEmptyListInterface()
    {
        return new List<string>();
    }

    [Benchmark]
    public IReadOnlyList<string> ReturnEmptyReadOnlyListInterface()
    {
        return new List<string>();
    }

    [Benchmark]
    public HashSet<string> ReturnEmptyHashSet()
    {
        return new HashSet<string>();
    }

    [Benchmark]
    public LinkedList<string> ReturnEmptyLinkedList()
    {
        return new LinkedList<string>();
    }

    [Benchmark]
    public ICollection<string> ReturnEmptySortedSet()
    {
        return new SortedSet<string>();
    }

    [Benchmark]
    public StringValues ReturnStringValues()
    {
        return StringValues.Empty;
    }
}