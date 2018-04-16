using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

			var lines = File.ReadAllLines(@"C:\Users\admin\Documents\GitHub\Nand2TetrisAssembler\Rect.asm");

			var helper = new Helper();
			var instructionsLines = helper.CleanCommentsAndWhiteSpace(lines);

			helper.ExtractLabels(instructionsLines);
			helper.ExtractVariables(instructionsLines);
		}
	}
}