namespace OptimizationExperiments.Benchmarks.String;

[Config(typeof(MemoryPerformanceConfig))]
public class ToLowerBenchmark
{
	private readonly string _source;
	private readonly string _copySource;

	public ToLowerBenchmark()
	{
		_source = "rp.inmovery@gmail.com";
		_copySource = new string(_source);
	}

	[GlobalCleanup]
	public void DisplayLog()
	{
		Console.WriteLine($"Used source: [{_copySource}]");
	}

	[Benchmark(Baseline = true)]
	public void ToLowerNative()
	{
		foreach (var _ in Enumerable.Range(0, 90_000))
		{
			var staticSource = _source;
			staticSource = staticSource.ToLower();
		}
	}

	[Benchmark]
	public void ToLowerViaSpan()
	{
		foreach (var _ in Enumerable.Range(0, 90_000))
		{
			var staticSource = _source;
			staticSource = ToLowerViaSpanMethod(staticSource);
		}
	}

	[Benchmark]
	public void ToLowerUnsafe()
	{
		foreach (var _ in Enumerable.Range(0, 90_000))
		{
			var staticSource = _source;
			staticSource = staticSource.UnsafeToLower();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string ToLowerViaSpanMethod(string source)
	{
		var sourceAsSpan = source.AsSpan();

		Span<char> destination = stackalloc char[source.Length];
		sourceAsSpan.ToLower(destination, CultureInfo.CurrentCulture);

		return destination.ToString();
	}
}