using System.Linq;

namespace Nand2TetrisAssembler
{
   /// <summary>Helper class.</summary>
   public static class Helper
   {
      /// <summary>Concats the instructions.</summary>
      /// <param name="instructionsCollection">The instructions collection.</param>
      /// <returns>A <see cref="string" /> reference.</returns>
      public static string ConcatInstructions(IInstructionsCollection instructionsCollection)
                     => instructionsCollection.Instructions.Select(o => o.Value).Aggregate((a, b) => $"{a}\n{b}");

      /// <summary>Concats the symbols.</summary>
      /// <param name="symbolsCollection">The symbols collection.</param>
      /// <returns>A <see cref="string" /> reference.</returns>
      public static string ConcatSymbols(ISymbolsCollection symbolsCollection)
                     => symbolsCollection.Symbols.Select(o => o.Value).Aggregate((a, b) => $"{a}\n{b}");
   }
}