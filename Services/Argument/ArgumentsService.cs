using System;

namespace Nand2TetrisAssembler
{
	public class ArgumentService : IArgumentService
	{
		private readonly string[] _arguments;

		public ArgumentService(string[] arguments)
		{
			_arguments = arguments;
		}

		public IArgumentOptions GetOptions()
		{
			var options = new ArgumentOptions();
			CommandLine.Parser.Default.ParseArguments(() => options, _arguments);
			return options;
		}
	}
}