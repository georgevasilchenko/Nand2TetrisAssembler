using System;
using System.Linq;

namespace Nand2TetrisAssembler
{
	public class JumpDefinitionEntry : IDefinitionEntry
	{
		public string Operation { get; private set; }

		public int Code { get; private set; }

		public int[] Bits => Converter.IntToBitArray(Code, 3).ToArray();

		public JumpDefinitionEntry(IDefinitionEntry spec)
		{
			Operation = spec.Operation;
			Code = spec.Code;
		}
	}
}