namespace OptimizationExperiments.Benchmarks.Collections;

[Config(typeof(MemoryPerformanceConfig))]
public class DefaultFeaturesOfSomeArrayAndListBenchmark
{
	private const int SpecificNumber = 558855;
	private const int ItemsCount = 10000;

	[Benchmark]
	public void Array()
	{
		int[] array = { 1, 5, 4, 6 };

		// Add
		for (var i = 0; i < ItemsCount; i++)
		{
			array = array.Append(i).ToArray();

		}

		array = array.Append(SpecificNumber).ToArray();

		for (var i = 0; i < ItemsCount; i++)
		{
			array = array.Append(i).ToArray();
		}

		// Remove
		var removedIndex = System.Array.IndexOf(array, SpecificNumber);
		
		array = array[..removedIndex].Concat(array[1..2].ToList()).ToArray();
	}

	[Benchmark]
	public void ArrayList()
	{
		var arrayList = new ArrayList();

		// Add
		for (var i = 0; i < ItemsCount; i++)
		{
			arrayList.Add(i);

		}

		arrayList.Add(SpecificNumber);

		for (var i = 0; i < ItemsCount; i++)
		{
			arrayList.Add(i);
		}

		// Remove
		arrayList.Remove(SpecificNumber);
	}

	[Benchmark(Baseline = true)]
	public void List()
	{
		var list = new List<int>();

		// Add
		for (var i = 0; i < ItemsCount; i++)
		{
			list.Add(i);
		}

		list.Add(SpecificNumber);

		for (var i = 0; i < ItemsCount; i++)
		{
			list.Add(i);
		}

		// Remove
		list.Remove(SpecificNumber);
	}

	[Benchmark]
	public void LinkedList()
	{
		var linkedList = new LinkedList<int>();

		// Add
		for (var i = 0; i < ItemsCount; i++)
		{
			linkedList.AddFirst(i);
		}

		linkedList.AddFirst(SpecificNumber);

		for (var i = 0; i < ItemsCount; i++)
		{
			linkedList.AddFirst(i);
		}

		// Remove
		linkedList.Remove(SpecificNumber);
	}

	[Benchmark]
	public void HashSet()
	{
		var hashSet = new HashSet<int>();

		// Add
		for (var i = 0; i < ItemsCount; i++)
		{
			hashSet.Add(i);
		}

		hashSet.Add(SpecificNumber);

		for (var i = 0; i < ItemsCount; i++)
		{
			hashSet.Add(i);
		}

		// Remove
		hashSet.Remove(SpecificNumber);
	}

	[Benchmark]
	public void SortedSet()
	{
		var sortedSet = new SortedSet<int>();

		// Add
		for (var i = 0; i < ItemsCount; i++)
		{
			sortedSet.Add(i);
		}

		sortedSet.Add(SpecificNumber);

		for (var i = 0; i < ItemsCount; i++)
		{
			sortedSet.Add(i);
		}

		// Remove
		sortedSet.Remove(SpecificNumber);
	}
}