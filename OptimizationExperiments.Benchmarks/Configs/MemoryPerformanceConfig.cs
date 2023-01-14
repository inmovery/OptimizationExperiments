namespace OptimizationExperiments.Benchmarks.Configs;

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

        WithOptions(ConfigOptions.DisableOptimizationsValidator);

        AddColumnProvider(DefaultColumnProviders.Instance);
        AddLogger(ConsoleLogger.Default);

        HideColumns(StatisticColumn.Error, StatisticColumn.StdDev, StatisticColumn.Median, BaselineRatioColumn.RatioStdDev);

        AddColumn(StatisticColumn.Min, StatisticColumn.Max, StatisticColumn.OperationsPerSecond, new ParamsSummaryColumn());

        AddColumn(new CategoriesColumn());
        AddLogicalGroupRules(BenchmarkLogicalGroupRule.ByCategory);

        AddDiagnoser(MemoryDiagnoser.Default);

        AddValidator(ExecutionValidator.FailOnError);

        var job = new Job(Job.Default)
            .WithLaunchCount(1)
            .WithToolchain(InProcessNoEmitToolchain.Instance)
            .WithStrategy(RunStrategy.Monitoring);

        AddJob(job);
    }
}