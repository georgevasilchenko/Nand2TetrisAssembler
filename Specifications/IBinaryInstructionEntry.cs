namespace Nand2TetrisAssembler
{
	public interface IBinaryInstructionEntry
	{
		int[] Code { get; }

		string ToString();
	}
}