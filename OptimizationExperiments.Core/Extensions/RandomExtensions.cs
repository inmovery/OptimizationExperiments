namespace OptimizationExperiments.Core.Extensions;

public static class RandomExtensions
{
	private static readonly Random Random = new();
	private const string Chars = "abcdefghijklmnopqrstuvwxyz-_.ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

	public static string RandomString(int length)
	{
		return new string(Enumerable.Repeat(Chars, length)
			.Select(str => str[Random.Next(str.Length)])
			.ToArray());
	}

	public static string RandomStringWithSpaces(int length)
	{
		var chars = string.Join(' ', Chars);
		return new string(Enumerable.Repeat(chars, length)
			.Select(str => str[Random.Next(str.Length)])
			.ToArray());
	}
}