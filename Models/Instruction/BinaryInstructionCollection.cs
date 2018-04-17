using System;
using System.Collections;
using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
	public class BinaryInstructionCollection : IBinaryInstructionCollection, IList<IBinaryInstructionEntry>, IEnumerable<IBinaryInstructionEntry>
	{
		public IBinaryInstructionEntry this[int index] { get => ((IList<IBinaryInstructionEntry>)Instructions)[index]; set => ((IList<IBinaryInstructionEntry>)Instructions)[index] = value; }

		public List<IBinaryInstructionEntry> Instructions { get; private set; }

		public BinaryInstructionCollection()
		{
			Instructions = new List<IBinaryInstructionEntry>();
		}

		public int Count => ((IList<IBinaryInstructionEntry>)Instructions).Count;

		public bool IsReadOnly => ((IList<IBinaryInstructionEntry>)Instructions).IsReadOnly;

		public void Add(IBinaryInstructionEntry item) => ((IList<IBinaryInstructionEntry>)Instructions).Add(item);

		public void Clear() => ((IList<IBinaryInstructionEntry>)Instructions).Clear();

		public bool Contains(IBinaryInstructionEntry item) => ((IList<IBinaryInstructionEntry>)Instructions).Contains(item);

		public void CopyTo(IBinaryInstructionEntry[] array, int arrayIndex) => ((IList<IBinaryInstructionEntry>)Instructions).CopyTo(array, arrayIndex);

		public IEnumerator<IBinaryInstructionEntry> GetEnumerator() => ((IList<IBinaryInstructionEntry>)Instructions).GetEnumerator();

		public int IndexOf(IBinaryInstructionEntry item) => ((IList<IBinaryInstructionEntry>)Instructions).IndexOf(item);

		public void Insert(int index, IBinaryInstructionEntry item) => ((IList<IBinaryInstructionEntry>)Instructions).Insert(index, item);

		public bool Remove(IBinaryInstructionEntry item) => ((IList<IBinaryInstructionEntry>)Instructions).Remove(item);

		public void RemoveAt(int index) => ((IList<IBinaryInstructionEntry>)Instructions).RemoveAt(index);

		IEnumerator IEnumerable.GetEnumerator() => ((IList<IBinaryInstructionEntry>)Instructions).GetEnumerator();

		IEnumerable<IBinaryInstructionEntry> IBinaryInstructionCollection.Instructions => Instructions;
	}
}