using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace OptimizationExperiments.Benchmarks;

public class Program
{
	public static void Main(string[] args)
	{
		#region Other

		//BenchmarkRunner.Run<IntroInProcessBenchmark>();
		BenchmarkRunner.Run<TrimToLowerEqualsBenchmark>();

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
		//BenchmarkRunner.Run<DefaultFeaturesOfSomeArrayAndListBenchmark>();

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
		//BenchmarkRunner.Run<StringComparisonsBenchmark>();

		#endregion

#if DEBUG
		var string1 = "\0roman_piskunov@bk.ru\0\0";
		var string2 = "\0\0\0\0\0\0roman_piskunov@bk.ru\0\0";

		Console.WriteLine(string1.AsSpan().UnsafeEqualsExceptWithEmptyCharacters(string2.AsSpan()));
		Console.WriteLine(string1.UnsafeEquals(string2));
		Console.WriteLine(string1.GetHashCode().Equals(string2.GetHashCode()));
		Console.WriteLine(string1.Equals(string2));
		Console.WriteLine(string.Compare(string1, string2, StringComparison.Ordinal) == 0);

		var collection = new StringDictionary();

		//var correctSource = "test";
		//var source1 = "   test   ";
		//var source2 = "   test ";

		//Console.WriteLine($"Было = [{source1}]");

		//Console.WriteLine($"Кол-во байт UnsafeToLower (до) = {Encoding.UTF8.GetByteCount(source1)}");
		//Console.WriteLine($"Длина UnsafeToLower (до) = {source1.Length}");

		//var test1 = source1.UnsafeTrimV2();

		//var test2 = source2.UnsafeTrim();

		//Console.WriteLine($"Кол-во байт UnsafeToLower (после) = {Encoding.UTF8.GetByteCount(source1)}");
		//Console.WriteLine($"Длина UnsafeToLower (после) = {source1.Length}");

		//Console.WriteLine($"Стало = [{source1}]");

		//Console.WriteLine($"Сравнение \"было\" и \"правильный вариант\": {source1.Equals(correctSource)}");
#endif
	}
}