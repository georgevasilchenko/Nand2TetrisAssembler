using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
	[XmlRoot("symbols-list")]
	public class SymbolsCollection : ISymbolsCollection, IEnumerable<ISymbolEntry>, ICollection<ISymbolEntry>
	{
		public ICollection<ISymbolEntry> Symbols { get; set; }

		public SymbolsCollection() => Symbols = new List<ISymbolEntry>();

		public SymbolsCollection(ISymbolsCollection spec)
		{
			Symbols = new List<ISymbolEntry>();
			foreach (var item in spec.Symbols)
			{
				Symbols.Add(new SymbolEntry(item));
			}
		}

		public int Count => ((ICollection<ISymbolEntry>)Symbols).Count;

		public bool IsReadOnly => ((ICollection<ISymbolEntry>)Symbols).IsReadOnly;

		public IEnumerator<ISymbolEntry> GetEnumerator() => ((SymbolsCollection)this).Symbols.GetEnumerator();

		public void Add(ISymbolEntry item) => ((ICollection<ISymbolEntry>)Symbols).Add(item);

		public void Clear() => ((ICollection<ISymbolEntry>)Symbols).Clear();

		public bool Contains(ISymbolEntry item) => ((ICollection<ISymbolEntry>)Symbols).Contains(item);

		public void CopyTo(ISymbolEntry[] array, int arrayIndex) => ((ICollection<ISymbolEntry>)Symbols).CopyTo(array, arrayIndex);

		public bool Remove(ISymbolEntry item) => ((ICollection<ISymbolEntry>)Symbols).Remove(item);

		IEnumerator IEnumerable.GetEnumerator() => ((SymbolsCollection)this).Symbols.GetEnumerator();

		IEnumerable<ISymbolEntry> ISymbolsCollection.Symbols => Symbols;
	}
}