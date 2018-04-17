namespace Nand2TetrisAssembler
{
	public class ServiceFactory : IServiceFactory
	{
		public IArgumentService CreateArgumentsService(string[] arguments) => new ArgumentService(arguments);

		public IBitsBuilderService CreateBitsBuilderService(
			IDefinitionsCollection computationDefinitionsCollection,
			IDefinitionsCollection jumpDefinitionsCollection,
			IDefinitionsCollection destinationDefinitionsCollection)
			=> new BitsBuilderService(computationDefinitionsCollection, jumpDefinitionsCollection, destinationDefinitionsCollection);

		public IFileService CreateFileService() => new FileService();

		public IInstructionService CreateInstructionService(
			IInstructionsCollection instructionsCollection,
			ISymbolsCollection symbolsCollection,
			IBitsBuilderService bitsBuilderService)
			=> new InstructionService(instructionsCollection, symbolsCollection, bitsBuilderService);
	}
}