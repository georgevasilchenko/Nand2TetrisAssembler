using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
	public interface IDefinitionsCollection
	{
		IEnumerable<IDefinitionEntry> Definitions { get; }
	}
}