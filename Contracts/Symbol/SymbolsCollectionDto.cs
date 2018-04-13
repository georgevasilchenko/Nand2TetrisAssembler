using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
	[XmlRoot("symbols-list")]
	public class SymbolsCollectionDto : ISymbolsCollection
	{
		[XmlElement("symbol")]
		public List<SymbolEntryDto> Symbols { get; set; }

		IEnumerable<ISymbolEntry> ISymbolsCollection.Symbols => Symbols;

		public SymbolsCollectionDto() => Symbols = new List<SymbolEntryDto>();
	}
}