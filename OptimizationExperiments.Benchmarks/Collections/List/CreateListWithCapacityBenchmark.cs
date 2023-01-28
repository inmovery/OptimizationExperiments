using System.ComponentModel;

namespace OptimizationExperiments.Benchmarks.Collections.List;

[Config(typeof(MemoryPerformanceConfig))]
public class CreateListWithCapacityBenchmark
{
    private const int Capacity = 100000;

	[Benchmark(Baseline = true)]
	[BenchmarkCategory("Create list")]
	public void CreateListWithoutCapacity()
    {
	    foreach (var _ in Enumerable.Range(0, 50000))
	    {
		    var addresses = new List<Address>
		    {
			    new(),
			    new()
		    };
		}
    }

    [Benchmark]
    [BenchmarkCategory("Create list")]
	public void CreateListWithCapacity()
    {
	    foreach (var _ in Enumerable.Range(0, 50000))
	    {
		    var addresses = new List<Address>(2)
		    {
			    new(),
			    new()
		    };
		}
    }

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("Add items")]
	public void AddItemsToListWithoutCapacity()
    {
	    var list = new List<int>();
	    for (var i = 0; i < Capacity; i++)
		    list.Add(i);
	}

    [Benchmark]
    [BenchmarkCategory("Add items")]
    public void AddItemsToListWithCapacity()
    {
	    var list = new List<int>(Capacity);
	    for (var i = 0; i < Capacity; i++)
		    list.Add(i);
	}
}