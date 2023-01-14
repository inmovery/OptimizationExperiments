namespace OptimizationExperiments.Benchmarks.Arrays;

[Config(typeof(MemoryPerformanceConfig))]
public class GetIndexByValueBenchmark
{
    /// <summary>
    /// Get array index by value using IndexOf method (Span implementation)
    /// </summary>
    /// <remarks>15 ns | 40 bytes</remarks>
    [Benchmark]
    public int GetIndexByIndexOf()
    {
        var array = new[] { 1, 2, 3 };
        return Array.IndexOf(array, 2);
    }

    /// <summary>
    /// Get array index by value using BinarySearch method (without Span)
    /// </summary>
    /// <remarks>11 ns | 40 bytes</remarks>
    [Benchmark]
    public int GetIndexByBinarySearch()
    {
        var array = new[] { 1, 2, 3 };
        return Array.BinarySearch(array, 2);
    }
}