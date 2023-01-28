namespace OptimizationExperiments.Benchmarks;

public class Program
{
	public static void Main(string[] args)
	{
		#region Other

		//BenchmarkRunner.Run<IntroInProcessBenchmark>();

		#endregion

		#region Arrays

		//BenchmarkRunner.Run<EmptyArraysBenchmark>();
		//BenchmarkRunner.Run<FilledArraysBenchmark>();
		//BenchmarkRunner.Run<GetIndexByValueBenchmark>();

		#endregion

		#region Collections

		//BenchmarkRunner.Run<CreateEmptyStringCollectionsBenchmark>();
		//BenchmarkRunner.Run<ForBenchmark>();

		#region Dictionaries

		//BenchmarkRunner.Run<DictionariesBenchmark>();

		#endregion

		#region List

		//BenchmarkRunner.Run<CreateListWithCapacityBenchmark>();
		//BenchmarkRunner.Run<PassDifferentParametersBenchmark>();
		BenchmarkRunner.Run<DefaultFeaturesOfSomeArrayAndListBenchmark>();

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

		#region String

		//BenchmarkRunner.Run<ToLowerBenchmark>();
		//BenchmarkRunner.Run<TrimBenchmark>();

		#endregion

#if DEBUG
		var correctSource = "test";
		var source = " test ";

		Console.WriteLine($"Было = [{source}]");

		Console.WriteLine($"Кол-во байт UnsafeToLower (до) = {Encoding.UTF8.GetByteCount(source)}");
		Console.WriteLine($"Длина UnsafeToLower (до) = {source.Length}");

		source.UnsafeTrimV2();

		Console.WriteLine($"Кол-во байт UnsafeToLower (после) = {Encoding.UTF8.GetByteCount(source)}");
		Console.WriteLine($"Длина UnsafeToLower (после) = {source.Length}");

		Console.WriteLine($"Стало = [{source}]");

		Console.WriteLine($"Сравнение \"было\" и \"правильный вариант\": {source.Equals(correctSource)}");
#endif
	}
}