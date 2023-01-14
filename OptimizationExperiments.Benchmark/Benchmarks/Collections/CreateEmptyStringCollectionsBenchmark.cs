namespace OptimizationExperiments.Benchmark.Benchmarks.Collections;

[Config(typeof(MemoryPerformanceConfig))]
public class CreateEmptyStringCollectionsBenchmark
{
	[Benchmark(Baseline = true)]
	public void CreateEmptyArray()
	{
		var summary = Array.Empty<string>();
	}

	[Benchmark]
	public void CreateEmptyEnumerable()
	{
		var summary = Enumerable.Empty<string>();
	}
}