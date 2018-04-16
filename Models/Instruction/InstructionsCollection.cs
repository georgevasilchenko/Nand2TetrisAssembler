using System.Collections;
using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
   public class InstructionsCollection : IInstructionsCollection, IEnumerable<IInstructionEntry>, IList<IInstructionEntry>
   {
      public List<IInstructionEntry> Instructions { get; private set; }

      IEnumerable<IInstructionEntry> IInstructionsCollection.Instructions => Instructions;

      public int Count => ((IList<IInstructionEntry>)Instructions).Count;

      public bool IsReadOnly => ((IList<IInstructionEntry>)Instructions).IsReadOnly;

      public InstructionsCollection() => Instructions = new List<IInstructionEntry>();

      public InstructionsCollection(string[] instructionsTextLines)
         : this()
      {
         foreach (var instructionTextLine in instructionsTextLines)
         {
            Instructions.Add(new InstructionEntry(instructionTextLine));
         }
      }

      public InstructionsCollection(IInstructionsCollection instructionsCollection)
         : this()
      {
         foreach (var instructionSpec in instructionsCollection.Instructions)
         {
            Instructions.Add(new InstructionEntry(instructionSpec));
         }
      }

      public IInstructionEntry this[int index] { get => ((IList<IInstructionEntry>)Instructions)[index]; set => ((IList<IInstructionEntry>)Instructions)[index] = value; }

      public IEnumerator<IInstructionEntry> GetEnumerator() => Instructions.GetEnumerator();

      IEnumerator IEnumerable.GetEnumerator() => Instructions.GetEnumerator();

      public int IndexOf(IInstructionEntry item) => ((IList<IInstructionEntry>)Instructions).IndexOf(item);

      public void Insert(int index, IInstructionEntry item) => ((IList<IInstructionEntry>)Instructions).Insert(index, item);

      public void RemoveAt(int index) => ((IList<IInstructionEntry>)Instructions).RemoveAt(index);

      public void Add(IInstructionEntry item) => ((IList<IInstructionEntry>)Instructions).Add(item);

      public void Clear() => ((IList<IInstructionEntry>)Instructions).Clear();

      public bool Contains(IInstructionEntry item) => ((IList<IInstructionEntry>)Instructions).Contains(item);

      public void CopyTo(IInstructionEntry[] array, int arrayIndex) => ((IList<IInstructionEntry>)Instructions).CopyTo(array, arrayIndex);

      public bool Remove(IInstructionEntry item) => ((IList<IInstructionEntry>)Instructions).Remove(item);
   }
}