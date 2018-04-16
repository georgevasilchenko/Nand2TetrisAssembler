namespace Nand2TetrisAssembler
{
	public interface IDefinitionEntry
	{
		string Operation { get; }
		int Code { get; }

		int[] Bits { get; }
	}
}