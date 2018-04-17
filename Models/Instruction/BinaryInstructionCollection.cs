using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Nand2TetrisAssembler
{
   /// <summary>BinaryInstructionCollection class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IBinaryInstructionCollection" />
   /// <seealso cref="System.Collections.Generic.IList{Nand2TetrisAssembler.IBinaryInstructionEntry}" />
   /// <seealso cref="System.Collections.Generic.IEnumerable{Nand2TetrisAssembler.IBinaryInstructionEntry}" />
   public class BinaryInstructionCollection : IBinaryInstructionCollection, IList<IBinaryInstructionEntry>, IEnumerable<IBinaryInstructionEntry>
   {
      /// <summary>Gets the instructions.</summary>
      /// <value>The instructions.</value>
      public List<IBinaryInstructionEntry> Instructions { get; private set; }

      /// <summary>
      /// Gets the number of elements contained in the <see
      /// cref="T:System.Collections.Generic.ICollection`1" />.
      /// </summary>
      public int Count => ((IList<IBinaryInstructionEntry>)Instructions).Count;

      /// <summary>
      /// Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1"
      /// /> is read-only.
      /// </summary>
      public bool IsReadOnly => ((IList<IBinaryInstructionEntry>)Instructions).IsReadOnly;

      /// <summary>Gets the instructions.</summary>
      /// <value>The instructions.</value>
      IEnumerable<IBinaryInstructionEntry> IBinaryInstructionCollection.Instructions => Instructions;

      /// <summary>
      /// Initializes a new instance of the <see cref="BinaryInstructionCollection" /> class.
      /// </summary>
      public BinaryInstructionCollection() => Instructions = new List<IBinaryInstructionEntry>();

      /// <summary>Gets or sets the <see cref="IBinaryInstructionEntry" /> at the specified index.</summary>
      /// <value>The <see cref="IBinaryInstructionEntry" />.</value>
      /// <param name="index">The index.</param>
      /// <returns></returns>
      public IBinaryInstructionEntry this[int index] { get => ((IList<IBinaryInstructionEntry>)Instructions)[index]; set => ((IList<IBinaryInstructionEntry>)Instructions)[index] = value; }

      /// <summary>
      /// Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1" />.
      /// </summary>
      /// <param name="item">
      /// The object to add to the <see cref="T:System.Collections.Generic.ICollection`1" />.
      /// </param>
      public void Add(IBinaryInstructionEntry item) => ((IList<IBinaryInstructionEntry>)Instructions).Add(item);

      /// <summary>
      /// Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1" />.
      /// </summary>
      public void Clear() => ((IList<IBinaryInstructionEntry>)Instructions).Clear();

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
      public bool Contains(IBinaryInstructionEntry item) => ((IList<IBinaryInstructionEntry>)Instructions).Contains(item);

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
      public void CopyTo(IBinaryInstructionEntry[] array, int arrayIndex) => ((IList<IBinaryInstructionEntry>)Instructions).CopyTo(array, arrayIndex);

      /// <summary>Returns an enumerator that iterates through the collection.</summary>
      /// <returns>An enumerator that can be used to iterate through the collection.</returns>
      public IEnumerator<IBinaryInstructionEntry> GetEnumerator() => ((IList<IBinaryInstructionEntry>)Instructions).GetEnumerator();

      /// <summary>
      /// Determines the index of a specific item in the <see
      /// cref="T:System.Collections.Generic.IList`1" />.
      /// </summary>
      /// <param name="item">
      /// The object to locate in the <see cref="T:System.Collections.Generic.IList`1" />.
      /// </param>
      /// <returns>The index of <paramref name="item" /> if found in the list; otherwise, -1.</returns>
      public int IndexOf(IBinaryInstructionEntry item) => ((IList<IBinaryInstructionEntry>)Instructions).IndexOf(item);

      /// <summary>
      /// Inserts an item to the <see cref="T:System.Collections.Generic.IList`1" /> at the specified index.
      /// </summary>
      /// <param name="index">
      /// The zero-based index at which <paramref name="item" /> should be inserted.
      /// </param>
      /// <param name="item">
      /// The object to insert into the <see cref="T:System.Collections.Generic.IList`1" />.
      /// </param>
      public void Insert(int index, IBinaryInstructionEntry item) => ((IList<IBinaryInstructionEntry>)Instructions).Insert(index, item);

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
      public bool Remove(IBinaryInstructionEntry item) => ((IList<IBinaryInstructionEntry>)Instructions).Remove(item);

      /// <summary>
      /// Removes the <see cref="T:System.Collections.Generic.IList`1" /> item at the specified index.
      /// </summary>
      /// <param name="index">The zero-based index of the item to remove.</param>
      public void RemoveAt(int index) => ((IList<IBinaryInstructionEntry>)Instructions).RemoveAt(index);

      /// <summary>Returns an enumerator that iterates through a collection.</summary>
      /// <returns>
      /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate
      /// through the collection.
      /// </returns>
      IEnumerator IEnumerable.GetEnumerator() => ((IList<IBinaryInstructionEntry>)Instructions).GetEnumerator();

      /// <summary>Gets the instructions lines text.</summary>
      /// <returns>A <see cref="string" /> reference.</returns>
      public string[] GetInstructionsLinesText()
      {
         var result = new List<string>();

         foreach (var instruction in Instructions)
         {
            result.Add(instruction.ToString());
         }

         return result.ToArray();
      }

      /// <summary>Gets the instructions text.</summary>
      /// <returns>A <see cref="string" /> reference.</returns>
      public string GetInstructionsText()
      {
         var result = new StringBuilder();

         foreach (var instruction in Instructions)
         {
            result.AppendLine(instruction.ToString());
         }

         return result.ToString();
      }
   }
}