using System.Collections;
using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
	public class InstructionsCollection : IInstructionsCollection, IEnumerable<IInstructionEntry>, ICollection<IInstructionEntry>
	{
		public ICollection<IInstructionEntry> Instructions { get; set; }

		public InstructionsCollection() => Instructions = new List<IInstructionEntry>();

		public InstructionsCollection(string[] instructionsTextLines)
			: this()
		{
		}

		public void Add(IInstructionEntry item)
		{
			Instructions.Add(item);
		}

		public IEnumerator<IInstructionEntry> GetEnumerator() => Instructions.GetEnumerator();

		public void Clear() => Instructions.Clear();

		public bool Contains(IInstructionEntry item) => Instructions.Contains(item);

		public void CopyTo(IInstructionEntry[] array, int arrayIndex) => Instructions.CopyTo(array, arrayIndex);

		public bool Remove(IInstructionEntry item) => Instructions.Remove(item);

		public int Count => Instructions.Count;

		public bool IsReadOnly => Instructions.IsReadOnly;

		IEnumerator IEnumerable.GetEnumerator() => Instructions.GetEnumerator();

		IEnumerable<IInstructionEntry> IInstructionsCollection.Instructions => Instructions;
	}
}