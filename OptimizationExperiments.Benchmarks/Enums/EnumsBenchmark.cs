namespace OptimizationExperiments.Benchmarks.Enums;

[Config(typeof(MemoryPerformanceConfig))]
public class EnumsBenchmark
{
    /// <summary>
    /// Convert Enum item to string using ToString overload method
    /// </summary>
    /// <remarks>28 ns | 24 bytes</remarks>
    [Benchmark]
    public string EnumToStringAsNative()
    {
        return Digits.One.ToString();
    }

    /// <summary>
    /// Convert Enum item to string using nameof and switch implementation
    /// </summary>
    /// <remarks>2 ns | 0 bytes</remarks>
    [Benchmark]
    public string EnumToStringAsFastOne()
    {
        return Digits.Two.FastToString();
    }
}