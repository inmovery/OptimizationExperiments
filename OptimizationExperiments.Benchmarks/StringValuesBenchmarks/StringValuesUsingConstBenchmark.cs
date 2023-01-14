namespace OptimizationExperiments.Benchmarks.StringValuesBenchmarks;

[Config(typeof(MemoryPerformanceConfig))]
public class StringValuesUsingConstBenchmark
{
    private const string TestString = "Test string";

    [Benchmark]
    [BenchmarkCategory("Use const string")]
    public string TakeConstStringAndReturnString()
    {
        return TestString;
    }

    [Benchmark]
    [BenchmarkCategory("Use const string")]
    public StringValues TakeConstStringAndReturnStringValues()
    {
        return TestString;
    }
}