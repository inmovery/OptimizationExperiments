namespace OptimizationExperiments.Benchmarks.Collections;

[Config(typeof(MemoryPerformanceConfig))]
public class StringComparisonsBenchmark
{
	private const int ItemsCount = 90_000;
	private readonly string _firstComparableString = "roman_piskunov@bk.ru";
	private readonly string _secondComparableString = "roman_piskunov@bk.ru";

	private readonly StringValues _firstComparableStringStruct = "roman_piskunov@bk.ru";
	private readonly StringValues _secondComparableStringStruct = "roman_piskunov@bk.ru";

	[Benchmark(Baseline = true)]
	public void CompareViaEquals()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var summary = _firstComparableString.Equals(_secondComparableString);
		}
	}

	[Benchmark]
	public void CompareViaHashCode()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var summary = _firstComparableString.GetHashCode().Equals(_secondComparableString.GetHashCode());
		}
	}

	[Benchmark]
	public void CompareViaUnsafeEquals()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var summary = _firstComparableString.UnsafeEquals(_secondComparableString);
		}
	}

	[Benchmark]
	public void CompareViaUnsafeEqualsExceptEmptyCharacter()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var summary = _firstComparableString.UnsafeEqualsExceptWithEmptyCharacters(_secondComparableString);
		}
	}

	[Benchmark]
	public void CompareViaEquals_StringValues()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var summary = _firstComparableString.Equals(_secondComparableString);
		}
	}

	[Benchmark]
	public void CompareViaSequenceEqual()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var summary = _firstComparableString.SequenceEqual(_secondComparableString);
		}
	}

	[Benchmark]
	public void CompareViaReadOnlyMemory()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var summary = _firstComparableString.AsMemory().Equals(_secondComparableString.AsMemory());
		}
	}

	[Benchmark]
	public void CompareViaReadOnlySpan()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var summary = _firstComparableString.AsSpan() == _secondComparableString.AsSpan();
		}
	}

	[Benchmark]
	public void CompareViaReadOnlySpan_And_UnsafeEqualsExceptEmptyCharacter()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var summary = _firstComparableString.AsSpan().UnsafeEqualsExceptWithEmptyCharacters(_secondComparableString.AsSpan());
		}
	}

	[Benchmark]
	public void CompareViaStringCompare()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var summary = string.Compare(_firstComparableString, _secondComparableString, StringComparison.Ordinal) == 0;
		}
	}

	[Benchmark]
	public void CompareViaStringCompare_StringValues()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var summary = string.Compare(_firstComparableStringStruct, _secondComparableStringStruct, StringComparison.Ordinal) == 0;
		}
	}

	[Benchmark]
	public void CompareViaStringCompareOrdinal()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var summary = string.CompareOrdinal(_firstComparableString, _secondComparableString) == 0;
		}
	}

	[Benchmark]
	public void CompareViaStringCompareOrdinal_StringValues()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var summary = string.CompareOrdinal(_firstComparableStringStruct, _secondComparableStringStruct) == 0;
		}
	}

	[Benchmark]
	public void CompareViaBytesAndEquals()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var firstStringBytes = Encoding.ASCII.GetBytes(_firstComparableString);
			var secondStringBytes = Encoding.ASCII.GetBytes(_secondComparableString);
			var summary = firstStringBytes.Equals(secondStringBytes);
		}
	}

	[Benchmark]
	public void CompareViaBytesAndEquals_StringValues()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var firstStringBytes = Encoding.ASCII.GetBytes(_firstComparableStringStruct);
			var secondStringBytes = Encoding.ASCII.GetBytes(_secondComparableStringStruct);
			var summary = firstStringBytes.Equals(secondStringBytes);
		}
	}

	[Benchmark]
	public void CompareViaBytesAndSequenceEqual()
	{
		foreach (var _ in Enumerable.Range(0, ItemsCount))
		{
			var firstStringBytes = Encoding.ASCII.GetBytes(_firstComparableString);
			var secondStringBytes = Encoding.ASCII.GetBytes(_secondComparableString);
			var summary = firstStringBytes.SequenceEqual(secondStringBytes);
		}
	}
}