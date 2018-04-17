namespace Nand2TetrisAssembler
{
   /// <summary>IServiceFactory interface.</summary>
   public interface IServiceFactory
   {
      /// <summary>Creates the file service.</summary>
      /// <returns>A <see cref="IFileService" /> reference.</returns>
      IFileService CreateFileService();

      /// <summary>Creates the arguments service.</summary>
      /// <param name="arguments">The arguments.</param>
      /// <returns>A <see cref="IArgumentService" /> reference.</returns>
      IArgumentService CreateArgumentsService(string[] arguments);

      /// <summary>Creates the instruction service.</summary>
      /// <param name="instructionsCollection">The instructions collection.</param>
      /// <param name="symbolsCollection">The symbols collection.</param>
      /// <param name="bitsBuilderService">The bits builder service.</param>
      /// <returns>A <see cref="IInstructionService" /> reference.</returns>
      IInstructionService CreateInstructionService(
         IInstructionsCollection instructionsCollection,
         ISymbolsCollection symbolsCollection,
         IBitsBuilderService bitsBuilderService);

      /// <summary>Creates the bits builder service.</summary>
      /// <param name="computationDefinitionsCollection">The computation definitions collection.</param>
      /// <param name="jumpDefinitionsCollection">The jump definitions collection.</param>
      /// <param name="destinationDefinitionsCollection">The destination definitions collection.</param>
      /// <returns>A <see cref="IBitsBuilderService" /> reference.</returns>
      IBitsBuilderService CreateBitsBuilderService(
         IDefinitionsCollection computationDefinitionsCollection,
         IDefinitionsCollection jumpDefinitionsCollection,
         IDefinitionsCollection destinationDefinitionsCollection);
   }
}