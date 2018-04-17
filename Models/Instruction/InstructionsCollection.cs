using System.Collections;
using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
   /// <summary>InstructionsCollection class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IInstructionsCollection" />
   /// <seealso cref="System.Collections.Generic.IEnumerable{Nand2TetrisAssembler.IInstructionEntry}" />
   /// <seealso cref="System.Collections.Generic.IList{Nand2TetrisAssembler.IInstructionEntry}" />
   public class InstructionsCollection : IInstructionsCollection, IEnumerable<IInstructionEntry>, IList<IInstructionEntry>
   {
      /// <summary>Gets the instructions.</summary>
      /// <value>The instructions.</value>
      public List<IInstructionEntry> Instructions { get; private set; }

      /// <summary>Gets the instructions.</summary>
      /// <value>The instructions.</value>
      IEnumerable<IInstructionEntry> IInstructionsCollection.Instructions => Instructions;

      /// <summary>
      /// Gets the number of elements contained in the <see
      /// cref="T:System.Collections.Generic.ICollection`1" />.
      /// </summary>
      public int Count => ((IList<IInstructionEntry>)Instructions).Count;

      /// <summary>
      /// Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1"
      /// /> is read-only.
      /// </summary>
      public bool IsReadOnly => ((IList<IInstructionEntry>)Instructions).IsReadOnly;

      /// <summary>Initializes a new instance of the <see cref="InstructionsCollection" /> class.</summary>
      public InstructionsCollection() => Instructions = new List<IInstructionEntry>();

      /// <summary>Initializes a new instance of the <see cref="InstructionsCollection" /> class.</summary>
      /// <param name="instructionsTextLines">The instructions text lines.</param>
      public InstructionsCollection(string[] instructionsTextLines)
         : this()
      {
         foreach (var instructionTextLine in instructionsTextLines)
         {
            Instructions.Add(new InstructionEntry(instructionTextLine));
         }
      }

      /// <summary>Initializes a new instance of the <see cref="InstructionsCollection" /> class.</summary>
      /// <param name="instructionsCollection">The instructions collection.</param>
      public InstructionsCollection(IEnumerable<IInstructionEntry> instructionsCollection)
         : this()
      {
         foreach (var instruction in instructionsCollection)
         {
            Instructions.Add(new InstructionEntry(instruction));
         }
      }

      /// <summary>Initializes a new instance of the <see cref="InstructionsCollection" /> class.</summary>
      /// <param name="instructionsCollection">The instructions collection.</param>
      public InstructionsCollection(IInstructionsCollection instructionsCollection)
         : this()
      {
         foreach (var instructionSpec in instructionsCollection.Instructions)
         {
            Instructions.Add(new InstructionEntry(instructionSpec));
         }
      }

      /// <summary>Gets or sets the <see cref="IInstructionEntry" /> at the specified index.</summary>
      /// <value>The <see cref="IInstructionEntry" />.</value>
      /// <param name="index">The index.</param>
      /// <returns></returns>
      public IInstructionEntry this[int index] { get => ((IList<IInstructionEntry>)Instructions)[index]; set => ((IList<IInstructionEntry>)Instructions)[index] = value; }

      /// <summary>Returns an enumerator that iterates through the collection.</summary>
      /// <returns>An enumerator that can be used to iterate through the collection.</returns>
      public IEnumerator<IInstructionEntry> GetEnumerator() => Instructions.GetEnumerator();

      /// <summary>Returns an enumerator that iterates through a collection.</summary>
      /// <returns>
      /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate
      /// through the collection.
      /// </returns>
      IEnumerator IEnumerable.GetEnumerator() => Instructions.GetEnumerator();

      /// <summary>
      /// Determines the index of a specific item in the <see
      /// cref="T:System.Collections.Generic.IList`1" />.
      /// </summary>
      /// <param name="item">
      /// The object to locate in the <see cref="T:System.Collections.Generic.IList`1" />.
      /// </param>
      /// <returns>The index of <paramref name="item" /> if found in the list; otherwise, -1.</returns>
      public int IndexOf(IInstructionEntry item) => ((IList<IInstructionEntry>)Instructions).IndexOf(item);

      /// <summary>
      /// Inserts an item to the <see cref="T:System.Collections.Generic.IList`1" /> at the specified index.
      /// </summary>
      /// <param name="index">
      /// The zero-based index at which <paramref name="item" /> should be inserted.
      /// </param>
      /// <param name="item">
      /// The object to insert into the <see cref="T:System.Collections.Generic.IList`1" />.
      /// </param>
      public void Insert(int index, IInstructionEntry item) => ((IList<IInstructionEntry>)Instructions).Insert(index, item);

      /// <summary>Removes at.</summary>
      /// <param name="index">The index.</param>
      public void RemoveAt(int index) => ((IList<IInstructionEntry>)Instructions).RemoveAt(index);

      /// <summary>
      /// Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1" />.
      /// </summary>
      /// <param name="item">
      /// The object to add to the <see cref="T:System.Collections.Generic.ICollection`1" />.
      /// </param>
      public void Add(IInstructionEntry item) => ((IList<IInstructionEntry>)Instructions).Add(item);

      /// <summary>
      /// Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1" />.
      /// </summary>
      public void Clear() => ((IList<IInstructionEntry>)Instructions).Clear();

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
      public bool Contains(IInstructionEntry item) => ((IList<IInstructionEntry>)Instructions).Contains(item);

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
      public void CopyTo(IInstructionEntry[] array, int arrayIndex) => ((IList<IInstructionEntry>)Instructions).CopyTo(array, arrayIndex);

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
      public bool Remove(IInstructionEntry item) => ((IList<IInstructionEntry>)Instructions).Remove(item);
   }
}