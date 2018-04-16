namespace Nand2TetrisAssembler
{
   internal class Program
   {
      public static IServiceFactory Factory = new ServiceFactory();

      private static void Main(string[] args)
      {
         var argumentsService = Factory.CreateArgumentsService(args);
         var fileService = Factory.CreateFileService();
         var instructionService = default(IInstructionService);

         var argumentOptions = argumentsService.GetOptions();
         var symbolsCollection = fileService.GetSymbolsCollection();
         var instructionsCollection = fileService.GetInstructionsCollection(argumentOptions.AssemblyFilePath);
         var computationDefinitions = fileService.GetComputationDefinitionsCollection();
         var jumsDefinitions = fileService.GetJumpDefinitionsCollection();
         var destinationDefinitions = fileService.GetDestinationDefinitionsCollection();

         instructionService = Factory.CreateInstructionService(instructionsCollection, symbolsCollection);
         /*instructionsCollection = */
         instructionService.Assemble();

         // Debug
         var symText = Helper.ConcatSymbols(symbolsCollection);
         var instrText = Helper.ConcatInstructions(instructionsCollection);
      }
   }
}