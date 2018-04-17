using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Nand2TetrisAssembler
{
	public static class Converter
	{
		public static IEnumerable<int> IntToBitArray(int number, int wordLength = 16, int toBase = 2)
		{
			return Convert.ToString(number, toBase)
				.PadLeft(wordLength, '0')
				.Select(c => int.Parse(c.ToString()))
				.Reverse();
		}

		public static int BitArrayToInt(int[] bits)
		{
			var sum = 0;

			for (var i = 0; i < bits.Length; i++)
			{
				if (bits[i] == 1)
				{
					sum += bits[i] * (int)Math.Pow(2, i);
				}
			}

			return sum;
		}
	}
}