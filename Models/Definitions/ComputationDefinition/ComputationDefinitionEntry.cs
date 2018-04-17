using System;
using System.Linq;

namespace Nand2TetrisAssembler
{
	public class ComputationDefinitionEntry : IDefinitionEntry
	{
		public string Operation { get; private set; }

		public int Code { get; private set; }

		public int[] Bits => Converter.IntToBitArray(Code, 7).ToArray();

		public ComputationDefinitionEntry(IDefinitionEntry spec)
		{
			Operation = spec.Operation;
			Code = spec.Code;
		}
	}
}