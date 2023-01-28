namespace OptimizationExperiments.Benchmarks.Collections;

[Config(typeof(MemoryPerformanceConfig))]
public class PassDifferentParametersBenchmark
{
	private readonly IEnumerable<int> _enumerable = Enumerable.Range(0, 300_000);
	private readonly List<int> _list = Enumerable.Range(0, 300_000).ToList();

	[Benchmark(Baseline = true)]
	public void PassParameterAsEnumerable()
	{
		PassParameterAsEnumerable(_enumerable);
	}

	[Benchmark]
	public void PassParameterAsList()
	{
		PassParameterAsList(_list);
	}

	[Benchmark]
	public void PassParameterAsIList()
	{
		PassParameterAsIList(_list);
	}

	[Benchmark]
	public void PassParameterAsIReadOnlyList()
	{
		PassParameterAsIReadOnlyList(_list);
	}

	private void PassParameterAsEnumerable(IEnumerable<int> pass)
	{
		foreach (var variable in pass)
		{
		}
	}

	private void PassParameterAsList(List<int> pass)
	{
		foreach (var variable in pass)
		{
		}
	}

	private void PassParameterAsIList(IList<int> pass)
	{
		foreach (var variable in pass)
		{
		}
	}

	private void PassParameterAsIReadOnlyList(IReadOnlyList<int> pass)
	{
		foreach (var variable in pass)
		{
		}
	}
}