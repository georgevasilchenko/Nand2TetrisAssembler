using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Nand2TetrisAssembler
{
   /// <summary>SymbolsCollection class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.ISymbolsCollection" />
   /// <seealso cref="System.Collections.Generic.IEnumerable{Nand2TetrisAssembler.ISymbolEntry}" />
   /// <seealso cref="System.Collections.Generic.ICollection{Nand2TetrisAssembler.ISymbolEntry}" />
   public class SymbolsCollection : ISymbolsCollection, IEnumerable<ISymbolEntry>, ICollection<ISymbolEntry>
   {
      /// <summary>Gets the symbols.</summary>
      /// <value>The symbols.</value>
      public ICollection<ISymbolEntry> Symbols { get; private set; }

      /// <summary>
      /// Gets the number of elements contained in the <see
      /// cref="T:System.Collections.Generic.ICollection`1" />.
      /// </summary>
      public int Count => ((ICollection<ISymbolEntry>)Symbols).Count;

      /// <summary>
      /// Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1"
      /// /> is read-only.
      /// </summary>
      public bool IsReadOnly => ((ICollection<ISymbolEntry>)Symbols).IsReadOnly;

      /// <summary>Gets the symbols.</summary>
      /// <value>The symbols.</value>
      IEnumerable<ISymbolEntry> ISymbolsCollection.Symbols => Symbols;

      /// <summary>Initializes a new instance of the <see cref="SymbolsCollection" /> class.</summary>
      public SymbolsCollection() => Symbols = new List<ISymbolEntry>();

      /// <summary>Initializes a new instance of the <see cref="SymbolsCollection" /> class.</summary>
      /// <param name="spec">The spec.</param>
      public SymbolsCollection(ISymbolsCollection spec)
      {
         Symbols = new List<ISymbolEntry>();
         foreach (var item in spec.Symbols)
         {
            Symbols.Add(new SymbolEntry(item));
         }
      }

      /// <summary>Returns an enumerator that iterates through the collection.</summary>
      /// <returns>An enumerator that can be used to iterate through the collection.</returns>
      public IEnumerator<ISymbolEntry> GetEnumerator() => ((SymbolsCollection)this).Symbols.GetEnumerator();

      /// <summary>
      /// Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1" />.
      /// </summary>
      /// <param name="item">
      /// The object to add to the <see cref="T:System.Collections.Generic.ICollection`1" />.
      /// </param>
      public void Add(ISymbolEntry item) => ((ICollection<ISymbolEntry>)Symbols).Add(item);

      /// <summary>
      /// Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1" />.
      /// </summary>
      public void Clear() => ((ICollection<ISymbolEntry>)Symbols).Clear();

      /// <summary>
      /// Determines whether the <see cref="T:System.Collections.Generic.ICollection`1" /> contains a
      /// specific value.
      /// </summary>
      /// <param name="item">
      /// The object to locate in the <see cref="T:System.Collections.Generic.ICollection`1" />.
      /// </param>
      /// <returns>
      /// <see langword="true" /> if <paramref name="item" /> is found in the <see
      /// cref="T:System.Collections.Generic.ICollection`1" />; otherwise, <see langword="false" />.
      /// </returns>
      public bool Contains(ISymbolEntry item) => ((ICollection<ISymbolEntry>)Symbols).Contains(item);

      /// <summary>
      /// Copies the elements of the <see cref="T:System.Collections.Generic.ICollection`1" /> to an
      /// <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.
      /// </summary>
      /// <param name="array">
      /// The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements
      /// copied from <see cref="T:System.Collections.Generic.ICollection`1" />. The <see
      /// cref="T:System.Array" /> must have zero-based indexing.
      /// </param>
      /// <param name="arrayIndex">
      /// The zero-based index in <paramref name="array" /> at which copying begins.
      /// </param>
      public void CopyTo(ISymbolEntry[] array, int arrayIndex) => ((ICollection<ISymbolEntry>)Symbols).CopyTo(array, arrayIndex);

      /// <summary>
      /// Removes the first occurrence of a specific object from the <see
      /// cref="T:System.Collections.Generic.ICollection`1" />.
      /// </summary>
      /// <param name="item">
      /// The object to remove from the <see cref="T:System.Collections.Generic.ICollection`1" />.
      /// </param>
      /// <returns>
      /// <see langword="true" /> if <paramref name="item" /> was successfully removed from the <see
      /// cref="T:System.Collections.Generic.ICollection`1" />; otherwise, <see langword="false" />.
      /// This method also returns <see langword="false" /> if <paramref name="item" /> is not found
      /// in the original <see cref="T:System.Collections.Generic.ICollection`1" />.
      /// </returns>
      public bool Remove(ISymbolEntry item) => ((ICollection<ISymbolEntry>)Symbols).Remove(item);

      /// <summary>Returns an enumerator that iterates through a collection.</summary>
      /// <returns>
      /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate
      /// through the collection.
      /// </returns>
      IEnumerator IEnumerable.GetEnumerator() => ((SymbolsCollection)this).Symbols.GetEnumerator();

      /// <summary>Determines whether [contains] [the specified key].</summary>
      /// <param name="key">The key.</param>
      /// <returns><c>true</c> if [contains] [the specified key]; otherwise, <c>false</c>.</returns>
      public bool Contains(string key) => Symbols.Any(o => o.Key == key);
   }
}