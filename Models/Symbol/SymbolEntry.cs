using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
	public class SymbolEntry : ISymbolEntry
	{
		public SymbolEntry(ISymbolEntry spec)
		{
			Key = spec.Key;
			Value = spec.Value;
		}

		public string Key { get; private set; }

		public string Value { get; private set; }
	}
}