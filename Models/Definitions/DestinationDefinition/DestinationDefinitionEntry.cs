﻿using System;
using System.Linq;

namespace Nand2TetrisAssembler
{
	public class DestinationDefinitionEntry : IDefinitionEntry
	{
		public string Operation { get; private set; }

		public int Code { get; private set; }

		public int[] Bits
		{
			get
			{
				var text = Convert.ToString(Code, 2);

				var bits = text.PadLeft(3, '0')
								 .Select(c => int.Parse(c.ToString()))
								 .ToArray();

				return bits;
			}
		}

		public DestinationDefinitionEntry(IDefinitionEntry spec)
		{
			Operation = spec.Operation;
			Code = spec.Code;
		}
	}
}