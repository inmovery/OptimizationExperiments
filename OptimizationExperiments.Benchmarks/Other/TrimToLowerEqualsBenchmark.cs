namespace OptimizationExperiments.Benchmarks.Other;

[Config(typeof(MemoryPerformanceConfig))]
public class TrimToLowerEqualsBenchmark
{
	private readonly string _source;
	private readonly string _copySource;

	private const string ComparableSource = "roman_piskunov@bk.ru";

	public TrimToLowerEqualsBenchmark()
	{
		_source = " rOman_piskUnoV@bk.rU  ";
		_copySource = new string(_source);
	}

	[GlobalCleanup]
	public void DisplayLog()
	{
		Console.WriteLine($"Used source: [{_copySource}]");
	}

	[Benchmark(Baseline = true)]
	public void Native()
	{
		foreach (var _ in Enumerable.Range(0, 90_000))
		{
			var staticSource = new string(_source);
			var summaryValidation = staticSource.Trim().ToLower().Equals(ComparableSource);
		}
	}

	[Benchmark]
	public void Optimized()
	{
		foreach (var _ in Enumerable.Range(0, 90_000))
		{
			var staticSource = new string(_source);
			var summaryValidation = staticSource.UnsafeTrimV2().UnsafeToLower().AsSpan().UnsafeEqualsExceptWithEmptyCharacters(ComparableSource.AsSpan());
		}
	}
}