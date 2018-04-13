namespace Nand2TetrisAssembler
{
	internal class Program
	{
		public static IServiceFactory Factory = new ServiceFactory();

		private static void Main(string[] args)
		{
			// Services
			var argumentsService = Factory.CreateArgumentsService(args);
			var fileService = Factory.CreateFileService();

			var arguments = argumentsService.GetOptions();
			var symbols = fileService.GetSymbolsCollection(arguments.SymbolsCollectionPath);
			var instructions = fileService.GetInstructionsCollection(arguments.AssemblyFilePath);
		}
	}
}