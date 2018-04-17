namespace Nand2TetrisAssembler
{
   /// <summary>ServiceFactory class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IServiceFactory" />
   public class ServiceFactory : IServiceFactory
   {
      /// <summary>Creates the arguments service.</summary>
      /// <param name="arguments">The arguments.</param>
      /// <returns>A <see cref="IArgumentService" /> reference.</returns>
      public IArgumentService CreateArgumentsService(string[] arguments) => new ArgumentService(arguments);

      /// <summary>Creates the bits builder service.</summary>
      /// <param name="computationDefinitionsCollection">The computation definitions collection.</param>
      /// <param name="jumpDefinitionsCollection">The jump definitions collection.</param>
      /// <param name="destinationDefinitionsCollection">The destination definitions collection.</param>
      /// <returns>A <see cref="IBitsBuilderService" /> reference.</returns>
      public IBitsBuilderService CreateBitsBuilderService(
         IDefinitionsCollection computationDefinitionsCollection,
         IDefinitionsCollection jumpDefinitionsCollection,
         IDefinitionsCollection destinationDefinitionsCollection)
         => new BitsBuilderService(computationDefinitionsCollection, jumpDefinitionsCollection, destinationDefinitionsCollection);

      /// <summary>Creates the file service.</summary>
      /// <returns>A <see cref="IFileService" /> reference.</returns>
      public IFileService CreateFileService() => new FileService();

      /// <summary>Creates the instruction service.</summary>
      /// <param name="instructionsCollection">The instructions collection.</param>
      /// <param name="symbolsCollection">The symbols collection.</param>
      /// <param name="bitsBuilderService">The bits builder service.</param>
      /// <returns>A <see cref="IInstructionService" /> reference.</returns>
      public IInstructionService CreateInstructionService(
         IInstructionsCollection instructionsCollection,
         ISymbolsCollection symbolsCollection,
         IBitsBuilderService bitsBuilderService)
         => new InstructionService(instructionsCollection, symbolsCollection, bitsBuilderService);
   }
}