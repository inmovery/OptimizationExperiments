namespace OptimizationExperiments.Benchmark.Benchmarks.Mappers;

[Config(typeof(MemoryPerformanceConfig))]
public class MappersBenchmark
{
	private static readonly RequestData RequestData = GetConfiguredModel();

	private static readonly IMapper AutoMapper = new MapperConfiguration(configuration =>
	{
		configuration.AddProfile(new AutoMapperDefaultProfile());
	}).CreateMapper();

	private static readonly TypeAdapterConfig TypeAdapterConfig = GetTypeAdapterConfig();

	private static readonly MapsterMapper.IMapper MapsterMapper = new MapsterMapper.Mapper(TypeAdapterConfig);

	[Benchmark(Baseline = true)]
	public SummaryData NativeMapping()
	{
		return new SummaryData();
	}

	[Benchmark]
	public SummaryData AutoMapperMap()
	{
		return AutoMapper.Map<SummaryData>(RequestData);
	}

	[Benchmark]
	public SummaryData MapsterMap()
	{
		return MapsterMapper.Map<SummaryData>(RequestData);
	}

	[Benchmark]
	public SummaryData MapsterAdaptWithoutConfig()
	{
		return RequestData.Adapt<SummaryData>();
	}

	[Benchmark]
	public SummaryData MapsterAdaptWithConfig()
	{
		return RequestData.Adapt<SummaryData>(TypeAdapterConfig);
	}

	[Benchmark]
	public SummaryData MapsterAdaptToType()
	{
		return MapsterMapper.From(RequestData).AdaptToType<SummaryData>();
	}

	private static TypeAdapterConfig GetTypeAdapterConfig()
	{
		var config = TypeAdapterConfig.GlobalSettings;
		config.Scan(typeof(MapsterDefaultProfile).Assembly);

		return config;
	}

	private static RequestData GetConfiguredModel()
	{
		return default;
	}
}