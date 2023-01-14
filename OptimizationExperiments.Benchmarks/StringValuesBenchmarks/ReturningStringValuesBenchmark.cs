namespace OptimizationExperiments.Benchmarks.StringValuesBenchmarks;

[Config(typeof(MemoryPerformanceConfig))]
public class ReturningStringValuesBenchmark
{
    [Benchmark(Baseline = true)]
    [BenchmarkCategory("Create string")]
    public string CreateStringAndReturnString()
    {
        var testString = "Test string";

        return testString;
    }

    [Benchmark]
    [BenchmarkCategory("Create string")]
    public StringValues CreateStringAndReturnStringValues()
    {
        var testString = "Test string";

        return testString;
    }
}