namespace OptimizationExperiments.Core.Extensions;

public static class EnumExtensions
{
	public static string FastToString(this Digits digits)
	{
		return digits switch
		{
			Digits.One => nameof(Digits.One),
			Digits.Two => nameof(Digits.Two),
			Digits.Three => nameof(Digits.Three),
			Digits.Four => nameof(Digits.Four),
			Digits.Five => nameof(Digits.Five),
			Digits.Six => nameof(Digits.Six),
			Digits.Seven => nameof(Digits.Seven),
			Digits.Eight => nameof(Digits.Eight),
			Digits.Nine => nameof(Digits.Nine),
			Digits.Ten => nameof(Digits.Ten),
			_ => throw new ArgumentOutOfRangeException(nameof(digits), digits, null)
		};
	}
}