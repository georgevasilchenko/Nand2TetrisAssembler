using System.Linq;

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
			var bitsBuilderService = default(IBitsBuilderService);

			var argumentOptions = argumentsService.GetOptions();
			var symbolsCollection = fileService.GetSymbolsCollection();
			var instructionsCollection = fileService.GetInstructionsCollection(argumentOptions.AssemblyFilePath);
			var computationDefinitions = fileService.GetComputationDefinitionsCollection();
			var jumpsDefinitions = fileService.GetJumpDefinitionsCollection();
			var destinationDefinitions = fileService.GetDestinationDefinitionsCollection();

			bitsBuilderService = Factory.CreateBitsBuilderService(computationDefinitions, jumpsDefinitions, destinationDefinitions);
			instructionService = Factory.CreateInstructionService(instructionsCollection, symbolsCollection, bitsBuilderService);
			instructionService.Assemble();

			// Debug
			var symText = Helper.ConcatSymbols(symbolsCollection);
			var instrText = Helper.ConcatInstructions(instructionsCollection);
			var x = Converter.IntToBitArray(65535);
			var y = Converter.BitArrayToInt(x.ToArray());
		}
	}
}