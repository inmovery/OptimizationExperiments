namespace OptimizationExperiments.Benchmarks.Collections;

[Config(typeof(MemoryPerformanceConfig))]
public class CreateEmptyStringCollectionsBenchmark
{
    [Benchmark(Baseline = true)]
    public void CreateEmptyArray()
    {
        var summary = Array.Empty<string>();
        Consume(summary);
    }

    [Benchmark]
    public void CreateEmptyEnumerable()
    {
        var summary = Enumerable.Empty<string>();
        Consume(summary);
	}

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void Consume(object collection)
    {
    }
}