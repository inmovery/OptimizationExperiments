namespace OptimizationExperiments.Benchmarks.Collections.List;

[Config(typeof(MemoryPerformanceConfig))]
public class CreateListWithCapacityBenchmark
{
    [Benchmark(Baseline = true)]
    public void CreateListWithoutCapacity()
    {
        var addresses = new List<Address>
        {
            new(),
            new()
        };
    }

    [Benchmark]
    public void CreateListWithCapacity()
    {
        var addresses = new List<Address>(2)
        {
            new(),
            new()
        };
    }
}