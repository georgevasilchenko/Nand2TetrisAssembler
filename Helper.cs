using System.Linq;

namespace Nand2TetrisAssembler
{
   public static class Helper
   {
      public static string ConcatInstructions(IInstructionsCollection instructionsCollection)
                     => instructionsCollection.Instructions.Select(o => o.Value).Aggregate((a, b) => $"{a}\n{b}");

      public static string ConcatSymbols(ISymbolsCollection symbolsCollection)
                     => symbolsCollection.Symbols.Select(o => o.Value).Aggregate((a, b) => $"{a}\n{b}");
   }
}