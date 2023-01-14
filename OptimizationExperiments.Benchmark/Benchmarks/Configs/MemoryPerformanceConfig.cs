namespace OptimizationExperiments.Benchmark.Benchmarks.Configs;

public class MemoryPerformanceConfig : ManualConfig
{
	public MemoryPerformanceConfig()
	{
		SummaryStyle = new SummaryStyle(
			CultureInfo.CurrentCulture,
			printUnitsInHeader: true,
			SizeUnit.B,
			TimeUnit.Nanosecond,
			ratioStyle: RatioStyle.Percentage);

		AddLogger(ConsoleLogger.Default);
		AddColumnProvider(DefaultColumnProviders.Instance);

		AddColumn(new CategoriesColumn());
		AddLogicalGroupRules(BenchmarkLogicalGroupRule.ByCategory);

		AddDiagnoser(MemoryDiagnoser.Default, new NativeMemoryProfiler());
		AddValidator(ExecutionValidator.FailOnError);

		var job = Job.Default
			.WithToolchain(InProcessNoEmitToolchain.Instance)
			.WithLaunchCount(1)
			.WithIterationCount(50)
			.WithStrategy(RunStrategy.Monitoring);

		AddJob(job);
	}
}