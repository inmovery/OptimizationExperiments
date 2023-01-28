namespace OptimizationExperiments.Benchmarks.Collections;

[Config(typeof(MemoryPerformanceConfig))]
public class ForBenchmark
{
	private readonly List<int> _list = Enumerable.Range(0, 100000).ToList();

	[Benchmark(Baseline = true)]
	public void ForNative()
	{
		for (var i = 0; i < _list.Count; i++)
			_list.Equals(0);
	}

	[Benchmark]
	public void ForEach()
	{
		foreach (var item in _list)
			item.Equals(0);
	}

	[Benchmark]
	public void ForEachLinq()
	{
		_list.ForEach((item) => item.Equals(0));
	}
}