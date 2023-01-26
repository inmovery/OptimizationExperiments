namespace OptimizationExperiments.Benchmarks.String;

[Config(typeof(MemoryPerformanceConfig))]
public class TrimBenchmark
{
	private readonly string _source;
	private readonly string _copySource;

	public TrimBenchmark()
	{ 
		_source = " rp.inmovery@gmail.com  ";
		_copySource = new string(_source);
	}

	[GlobalCleanup]
	public void DisplayLog()
	{
		Console.WriteLine($"Used source: [{_copySource}]");
	}

	[Benchmark(Baseline = true)]
	public void TrimNative()
	{
		foreach (var _ in Enumerable.Range(0, 90_000))
		{
			var staticSource = _source;
			staticSource = staticSource.Trim();
		}
	}

	[Benchmark]
	public void TrimViaSpan()
	{
		foreach (var _ in Enumerable.Range(0, 90_000))
		{
			var staticSource = _source;
			staticSource = TrimViaSpanMethod(staticSource);
		}
	}

	[Benchmark]
	public void TrimViaBytes()
	{
		foreach (var _ in Enumerable.Range(0, 90_000))
		{
			var staticSource = _source;
			staticSource = staticSource.TrimViaBytes();
		}
	}

	[Benchmark]
	public void TrimUnsafe()
	{
		foreach (var _ in Enumerable.Range(0, 90_000))
		{
			var staticSource = _source;
			staticSource = staticSource.UnsafeTrimV2();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private StringValues TrimViaSpanMethod(string source)
	{
		return source.AsSpan().Trim().ToString();
	}
}