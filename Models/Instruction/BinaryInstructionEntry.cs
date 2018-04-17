using System;
using System.Linq;

namespace Nand2TetrisAssembler
{
	public class BinaryInstructionEntry : IBinaryInstructionEntry
	{
		public int[] Code { get; private set; }

		public BinaryInstructionEntry(string bitsText)
		{
			Code = bitsText
				.Select(c => int.Parse(c.ToString()))
				.ToArray();
		}

		public BinaryInstructionEntry(int[] bits)
		{
			Code = bits;
		}

		public BinaryInstructionEntry(int number)
		{
			Code = Converter.IntToBitArray(number).ToArray();
		}

		public BinaryInstructionEntry(IBinaryInstructionEntry spec)
		{
			Code = spec.Code;
		}

		public override string ToString() => string.Join("", Code.Reverse());
	}
}