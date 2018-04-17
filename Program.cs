namespace Nand2TetrisAssembler
{
   /// <summary>Program class.</summary>
   internal class Program
   {
      /// <summary>The factory.</summary>
      public static IServiceFactory Factory = new ServiceFactory();

      /// <summary>Defines the entry point of the application.</summary>
      /// <param name="args">The arguments.</param>
      private static void Main(string[] args)
      {
         var argumentsService = Factory.CreateArgumentsService(args);
         var fileService = Factory.CreateFileService();
         var instructionService = default(IInstructionService);
         var bitsBuilderService = default(IBitsBuilderService);

         var argumentOptions = argumentsService.GetOptions();
         var symbolsCollection = fileService.GetSymbolsCollection();
         var instructionsCollection = fileService.GetInstructionsCollection(argumentOptions.AssemblyFilePath);
         var computationDefinitions = fileService.GetComputationDefinitionsCollection();
         var jumpsDefinitions = fileService.GetJumpDefinitionsCollection();
         var destinationDefinitions = fileService.GetDestinationDefinitionsCollection();

         bitsBuilderService = Factory.CreateBitsBuilderService(computationDefinitions, jumpsDefinitions, destinationDefinitions);
         instructionService = Factory.CreateInstructionService(instructionsCollection, symbolsCollection, bitsBuilderService);

         var hackInstructionsText = instructionService.Assemble();
         fileService.OutputHackFile(hackInstructionsText, argumentOptions.HackFilePath);
      }
   }
}