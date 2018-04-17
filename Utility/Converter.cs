using System;
using System.Collections.Generic;
using System.Linq;

namespace Nand2TetrisAssembler
{
   /// <summary>Converter class.</summary>
   public static class Converter
   {
      /// <summary>Ints to bit array.</summary> <param name="number">The number.</param> <param
      /// name="wordLength">Length of the word.</param> <param name="toBase">To base.</param>
      /// <returns>A <see cref="IEnumerable{int}" /> value.</returns></returns>
      public static IEnumerable<int> IntToBitArray(int number, int wordLength = 16, int toBase = 2) => Convert.ToString(number, toBase)
            .PadLeft(wordLength, '0')
            .Select(c => int.Parse(c.ToString()))
            .Reverse();

      /// <summary>Bits the array to int.</summary>
      /// <param name="bits">The bits.</param>
      /// <returns>A <see cref="int" /> value.</returns>
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