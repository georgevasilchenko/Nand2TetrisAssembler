using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
	public interface ISymbolsCollection
	{
		IEnumerable<ISymbolEntry> Symbols { get; }

		void Add(ISymbolEntry entry);

		bool Contains(string key);
	}
}