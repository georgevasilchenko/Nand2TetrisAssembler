using System.Collections;
using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
   public class SymbolsCollection : ISymbolsCollection, IEnumerable<ISymbolEntry>, ICollection<ISymbolEntry>
   {
      public ICollection<ISymbolEntry> Symbols { get; private set; }

      public int Count => ((ICollection<ISymbolEntry>)Symbols).Count;

      public bool IsReadOnly => ((ICollection<ISymbolEntry>)Symbols).IsReadOnly;

      IEnumerable<ISymbolEntry> ISymbolsCollection.Symbols => Symbols;

      public SymbolsCollection() => Symbols = new List<ISymbolEntry>();

      public SymbolsCollection(ISymbolsCollection spec)
      {
         Symbols = new List<ISymbolEntry>();
         foreach (var item in spec.Symbols)
         {
            Symbols.Add(new SymbolEntry(item));
         }
      }

      public IEnumerator<ISymbolEntry> GetEnumerator() => ((SymbolsCollection)this).Symbols.GetEnumerator();

      public void Add(ISymbolEntry item) => ((ICollection<ISymbolEntry>)Symbols).Add(item);

      public void Clear() => ((ICollection<ISymbolEntry>)Symbols).Clear();

      public bool Contains(ISymbolEntry item) => ((ICollection<ISymbolEntry>)Symbols).Contains(item);

      public void CopyTo(ISymbolEntry[] array, int arrayIndex) => ((ICollection<ISymbolEntry>)Symbols).CopyTo(array, arrayIndex);

      public bool Remove(ISymbolEntry item) => ((ICollection<ISymbolEntry>)Symbols).Remove(item);

      IEnumerator IEnumerable.GetEnumerator() => ((SymbolsCollection)this).Symbols.GetEnumerator();
   }
}