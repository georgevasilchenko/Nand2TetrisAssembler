using System;

namespace Nand2TetrisAssembler
{
	public class ServiceFactory : IServiceFactory
	{
		public IArgumentService CreateArgumentsService(string[] arguments) => new ArgumentService(arguments);

		public IFileService CreateFileService() => new FileService();
	}
}