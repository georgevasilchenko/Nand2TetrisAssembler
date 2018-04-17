namespace Nand2TetrisAssembler
{
   /// <summary>IBitsBuilderService interface.</summary>
   public interface IBitsBuilderService
   {
      /// <summary>Builds the binary instruction collection.</summary>
      /// <param name="instructionsCollection">The instructions collection.</param>
      /// <param name="symbolsCollection">The symbols collection.</param>
      /// <returns></returns>
      IBinaryInstructionCollection BuildBinaryInstructionCollection(IInstructionsCollection instructionsCollection, ISymbolsCollection symbolsCollection);
   }
}