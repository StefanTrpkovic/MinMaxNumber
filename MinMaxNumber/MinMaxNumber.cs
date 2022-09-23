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
				int swapIndex = 0;

				for (int i = numbers.Length - 2; i >= 0; i--)
				{
					if (numbers[i] < numbers[smallestRightmostIndex])
					{
						smallestRightmostIndex = i;
					}
				}

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

			}

			return (new string(numbers));
		}

		public static void Main()
		{
			String num = "112";
			Console.Write("Smallest number: " + smallestNumber(num));
		}
	}
}