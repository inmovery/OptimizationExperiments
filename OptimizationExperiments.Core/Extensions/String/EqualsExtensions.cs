namespace OptimizationExperiments.Core.Extensions.String;

public static class EqualsExtensions
{
	public static unsafe bool UnsafeEquals(this string firstString, string secondString)
	{
		if (firstString.Length != secondString.Length)
			return false;

		fixed (char* pFirstStr = firstString)
		{
			fixed (char* pSecondStr = secondString)
			{
				for (var i = 0; i < firstString.Length; i++)
					if (!pFirstStr[i].Equals(pSecondStr[i]))
						return false;

				return true;
			}
		}
	}

	public static unsafe bool UnsafeEquals(this ReadOnlySpan<char> firstString, ReadOnlySpan<char> secondString)
	{
		if (firstString.Length != secondString.Length)
			return false;

		fixed (char* pFirstStr = firstString)
		{
			fixed (char* pSecondStr = secondString)
			{
				for (var i = 0; i < firstString.Length; i++)
					if (!pFirstStr[i].Equals(pSecondStr[i]))
						return false;

				return true;
			}
		}
	}

	public static unsafe bool UnsafeEqualsExceptWithEmptyCharacters(this string firstString, string secondString)
	{
		fixed (char* pFirstStr = firstString)
		{
			fixed (char* pSecondStr = secondString)
			{
				var considerEndEmptyCharacters = false;

				var firstStringOffset = 0;
				var secondStringOffset = 0;
				for (var i = 0; i < firstString.Length; i++)
				{
					ref var firstArgumentBefore = ref pFirstStr[firstStringOffset + i];
					ref var secondArgumentBefore = ref pSecondStr[secondStringOffset + i];

					var isFirstEmptyCharacter = firstArgumentBefore == '\0';
					var isSecondEmptyCharacter = secondArgumentBefore == '\0';

					if (isFirstEmptyCharacter && isSecondEmptyCharacter && considerEndEmptyCharacters)
						return true;

					var needContinue = false;
					if (isFirstEmptyCharacter)
					{
						firstStringOffset++;
						needContinue = secondString.Length != i + 1;
					}

					if (isSecondEmptyCharacter)
					{
						secondStringOffset++;
						needContinue |= firstString.Length != i + 1;
					}

					if (needContinue)
					{
						i -= 1;
						continue;
					}

					considerEndEmptyCharacters = true;

					ref var firstArgumentAfter = ref pFirstStr[firstStringOffset + i];
					ref var secondArgumentAfter = ref pSecondStr[secondStringOffset + i];

					if (!firstArgumentAfter.Equals(secondArgumentAfter))
						return false;
				}

				return true;
			}
		}
	}

	public static unsafe bool UnsafeEqualsExceptWithEmptyCharacters(this ReadOnlySpan<char> firstString, ReadOnlySpan<char> secondString)
	{
		fixed (char* pFirstStr = firstString)
		{
			fixed (char* pSecondStr = secondString)
			{
				var considerEndEmptyCharacters = false;

				var firstStringOffset = 0;
				var secondStringOffset = 0;
				for (var i = 0; i < firstString.Length; i++)
				{
					ref var  firstArgumentBefore = ref pFirstStr[firstStringOffset + i];
					ref var secondArgumentBefore = ref pSecondStr[secondStringOffset + i];

					var isFirstEmptyCharacter = firstArgumentBefore == '\0';
					var isSecondEmptyCharacter = secondArgumentBefore == '\0';

					if (isFirstEmptyCharacter && isSecondEmptyCharacter && considerEndEmptyCharacters)
						return true;

					var needSkipCharacter = false;
					if (isFirstEmptyCharacter)
					{
						firstStringOffset++;
						needSkipCharacter = secondString.Length != i + 1;
					}

					if (isSecondEmptyCharacter)
					{
						secondStringOffset++;
						needSkipCharacter |= firstString.Length != i + 1;
					}

					if (needSkipCharacter)
					{
						i -= 1;
						continue;
					}

					considerEndEmptyCharacters = true;

					ref var firstArgumentAfter = ref pFirstStr[firstStringOffset + i];
					ref var secondArgumentAfter = ref pSecondStr[secondStringOffset + i];

					if (!firstArgumentAfter.Equals(secondArgumentAfter))
						return false;
				}

				return true;
			}
		}
	}
}