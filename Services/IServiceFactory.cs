namespace Nand2TetrisAssembler
{
	public interface IServiceFactory
	{
		IFileService CreateFileService();

		IArgumentService CreateArgumentsService(string[] arguments);

		IInstructionService CreateInstructionService(
			IInstructionsCollection instructionsCollection,
			ISymbolsCollection symbolsCollection,
			IBitsBuilderService bitsBuilderService);

		IBitsBuilderService CreateBitsBuilderService(
			IDefinitionsCollection computationDefinitionsCollection,
			IDefinitionsCollection jumpDefinitionsCollection,
			IDefinitionsCollection destinationDefinitionsCollection);
	}
}