namespace Nand2TetrisAssembler
{
	public interface IArgumentOptions
	{
		string AssemblyFilePath { get; }
		string SymbolsCollectionPath { get; }
		string HackFilePath { get; }
	}
}