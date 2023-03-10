namespace OptimizationExperiments.Benchmarks.Configs;

public class ParamsSummaryColumn : IColumn
{
    public string Id => nameof(ParamsSummaryColumn);
    public string ColumnName => "Params";
    public bool IsDefault(Summary summary, BenchmarkCase benchmark) => false;
    public string GetValue(Summary summary, BenchmarkCase benchmark) => benchmark.Parameters.DisplayInfo;
    public bool IsAvailable(Summary summary) => true;
    public bool AlwaysShow => true;
    public ColumnCategory Category => ColumnCategory.Params;
    public int PriorityInCategory => 0;
    public override string ToString() => ColumnName;
    public bool IsNumeric => false;
    public UnitType UnitType => UnitType.Dimensionless;
    public string GetValue(Summary summary, BenchmarkCase benchmark, SummaryStyle style) => GetValue(summary, benchmark);
    public string Legend => "Summary of all parameter values";
}