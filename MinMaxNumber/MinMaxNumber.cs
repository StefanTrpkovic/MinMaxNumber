using System;
using System.Linq;

namespace MinMaxNumberNamespace
{
	public class MinMaxNumber
	{
		public static string smallestNumber(String str)
		{
			char[] numbers = str.ToCharArray();

			if (!numbers.Contains('0'))
			{
				int smallestRightmostIndex = numbers.Length - 1;

				for (int i = numbers.Length - 2; i >= 0; i--)
				{
					if (numbers[i] < numbers[smallestRightmostIndex])
					{
						smallestRightmostIndex = i;
					}
				}

				int swapIndex = 0;
				if (smallestRightmostIndex != 0)
				{
					for (int i = 0; i < numbers.Length; i++)
					{
						if (numbers[i] != numbers[smallestRightmostIndex] && i < smallestRightmostIndex)
						{
							swapIndex = i;
							break;
						}
					}

					char temp = numbers[swapIndex];
					numbers[swapIndex] = numbers[smallestRightmostIndex];
					numbers[smallestRightmostIndex] = temp;
				}
			}
			else
			{
				char smallestDigit = '9';
				int smallestDigitIndex = 0;
				for (int i = numbers.Length - 1; i >= 0; i--)
				{
					if (numbers[i] < smallestDigit && numbers[i] != '0')
					{
						smallestDigit = numbers[i];
						smallestDigitIndex = i;
					}
				}

				if (smallestDigitIndex != 0)
				{
					char temp = numbers[0];
					numbers[0] = numbers[smallestDigitIndex];
					numbers[smallestDigitIndex] = temp;
				}
				else
				{
					int mostRightZeroIndex = numbers.Length - 1;
					for (int i = numbers.Length - 1; i > 0; i--)
					{
						if (numbers[i] == '0')
						{
							mostRightZeroIndex = i;
							break;
						}
					}

					for (int i = 1; i < numbers.Length; i++)
					{
						if (numbers[i] != '0' && mostRightZeroIndex > i)
						{
							char temp = numbers[i];
							numbers[i] = '0';
							numbers[mostRightZeroIndex] = temp;

							return (new string(numbers));
						}
					}


					int smallestDigitAfterZeroIndex = numbers.Length - 1;
					for (int i = numbers.Length - 2; i > mostRightZeroIndex; i--)
					{
						if (numbers[i] < numbers[smallestDigitAfterZeroIndex])
						{
							smallestDigitAfterZeroIndex = i;
						}
					}

					if (mostRightZeroIndex + 1 < numbers.Length)
					{
						char temp = numbers[mostRightZeroIndex + 1];
						numbers[mostRightZeroIndex + 1] = numbers[smallestDigitAfterZeroIndex];
						numbers[smallestDigitAfterZeroIndex] = temp;
					}
				}
			}

			return (new string(numbers));
		}

		public static string biggestNumber(String str)
		{
			char[] numbers = str.ToCharArray();

			char biggestNumber = '1';
			int biggestIndex = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] > biggestNumber)
				{
					biggestNumber = numbers[i];
					biggestIndex = i;
				}
			}

			if (biggestIndex != 0)
			{
				char temp = numbers[0];
				numbers[0] = numbers[biggestIndex];
				numbers[biggestIndex] = temp;
			}
			else
			{
				for (int i = 1; i < numbers.Length; i++)
				{
					char biggestNumberRight = numbers[i];
					int biggestIndexRight = i;
					for (int j = i + 1; j < numbers.Length; j++)
					{
						if (numbers[j] > biggestNumberRight)
						{
							char temp = numbers[biggestIndexRight];
							numbers[biggestIndexRight] = numbers[j];
							numbers[j] = temp;

							return (new string(numbers));
						}
					}
				}
			}

			return (new string(numbers));
		}

		public static void Main()
		{
			String num = "75632";
			Console.WriteLine("Smallest number: " + smallestNumber(num));
			Console.WriteLine("Biggest number: " + biggestNumber(num));
		}
	}
}