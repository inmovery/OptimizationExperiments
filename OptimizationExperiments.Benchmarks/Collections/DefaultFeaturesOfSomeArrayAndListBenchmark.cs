namespace OptimizationExperiments.Benchmarks.Collections;

[Config(typeof(MemoryPerformanceConfig))]
public class DefaultFeaturesOfSomeArrayAndListBenchmark
{
	private const string SpecificNumber = "558855";
	private const int ItemsCount = 10000;

	[Benchmark]
	public void Array()
	{
		string[] array = { "1", "5", "4", "6" };

		// Add
		for (var i = 0; i < ItemsCount; i++)
		{
			array = array.Append($"{i}").ToArray();

		}

		array = array.Append(SpecificNumber).ToArray();

		for (var i = 0; i < ItemsCount; i++)
		{
			array = array.Append($"{i}").ToArray();
		}

		// Remove
		var removedIndex = System.Array.IndexOf(array, SpecificNumber);
		
		array = array[..removedIndex].Concat(array[1..2].ToList()).ToArray();
	}

	[Benchmark]
	public void ArrayList_WithCapacity()
	{
		var arrayList = new ArrayList(ItemsCount);

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
	public void List_WithCapacity()
	{
		var list = new List<string>(ItemsCount);

		// Add
		for (var i = 0; i < ItemsCount; i++)
		{
			list.Add($"{i}");
		}

		list.Add(SpecificNumber);

		for (var i = 0; i < ItemsCount; i++)
		{
			list.Add($"{i}");
		}

		// Remove
		list.Remove(SpecificNumber);
	}

	[Benchmark]
	public void LinkedList()
	{
		var linkedList = new LinkedList<string>();

		// Add
		for (var i = 0; i < ItemsCount; i++)
		{
			linkedList.AddFirst($"{i}");
		}

		linkedList.AddFirst(SpecificNumber);

		for (var i = 0; i < ItemsCount; i++)
		{
			linkedList.AddFirst($"{i}");
		}

		// Remove
		linkedList.Remove(SpecificNumber);
	}

	[Benchmark]
	public void HashSet_WithCapacity()
	{
		var hashSet = new HashSet<string>(ItemsCount);

		// Add
		for (var i = 0; i < ItemsCount; i++)
		{
			hashSet.Add($"{i}");
		}

		hashSet.Add(SpecificNumber);

		for (var i = 0; i < ItemsCount; i++)
		{
			hashSet.Add($"{i}");
		}

		// Remove
		hashSet.Remove(SpecificNumber);
	}

	[Benchmark]
	public void SortedSet()
	{
		var sortedSet = new SortedSet<string>();

		// Add
		for (var i = 0; i < ItemsCount; i++)
		{
			sortedSet.Add($"{i}");
		}

		sortedSet.Add(SpecificNumber);

		for (var i = 0; i < ItemsCount; i++)
		{
			sortedSet.Add($"{i}");
		}

		// Remove
		sortedSet.Remove(SpecificNumber);
	}

	[Benchmark]
	public void StringCollection()
	{
		var stringCollection = new StringCollection();

		// Add
		for (var i = 0; i < ItemsCount; i++)
		{
			stringCollection.Add($"{i}");
		}

		stringCollection.Add(SpecificNumber);

		for (var i = 0; i < ItemsCount; i++)
		{
			stringCollection.Add($"{i}");
		}

		// Remove
		stringCollection.Remove(SpecificNumber);
	}
}