namespace OptimizationExperiments.Benchmarks;

public class Program
{
	public static void Main(string[] args)
	{
		#region Other

		//BenchmarkRunner.Run<IntroInProcess>();

		#endregion

		#region Arrays

		//BenchmarkRunner.Run<EmptyArraysBenchmark>();
		//BenchmarkRunner.Run<FilledArraysBenchmark>();
		//BenchmarkRunner.Run<GetIndexByValueBenchmark>();

		#endregion

		#region Collections

		BenchmarkRunner.Run<CreateEmptyStringCollectionsBenchmark>();

		#region Dictionaries

		//BenchmarkRunner.Run<DictionariesBenchmark>();

		#endregion

		#region List

		//BenchmarkRunner.Run<CreateListWithCapacityBenchmark>();

		#endregion

		#endregion

		#region Mappers

		//BenchmarkRunner.Run<MappersBenchmark>();

		#endregion

		#region StringValues

		//BenchmarkRunner.Run<ReturningStringValuesBenchmark>();
		//BenchmarkRunner.Run<StringValuesUsingConstBenchmark>();

		#endregion

		#region Enums

		//BenchmarkRunner.Run<EnumsBenchmark>();

		#endregion
	}
}