using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
	public class SymbolEntryDto : ISymbolEntry
	{
		[XmlAttribute(AttributeName = "key", Namespace = "")]
		public string Key { get; set; }

		[XmlAttribute(AttributeName = "value", Namespace = "")]
		public string Value { get; set; }
	}
}