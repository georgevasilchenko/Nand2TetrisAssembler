using System;
using System.Collections.Generic;
using System.Linq;

namespace Nand2TetrisAssembler
{
	public class BitsBuilderService : IBitsBuilderService
	{
		private readonly IDefinitionsCollection _computationDefinitionsCollection;
		private readonly IDefinitionsCollection _jumpDefinitionsCollection;
		private readonly IDefinitionsCollection _destinationDefinitionsCollection;

		public BitsBuilderService(
			IDefinitionsCollection computationDefinitionsCollection,
			IDefinitionsCollection jumpDefinitionsCollection,
			IDefinitionsCollection destinationDefinitionsCollection)
		{
			_computationDefinitionsCollection = computationDefinitionsCollection;
			_jumpDefinitionsCollection = jumpDefinitionsCollection;
			_destinationDefinitionsCollection = destinationDefinitionsCollection;
		}

		public IBinaryInstructionCollection BuildBinaryInstructionCollection(IInstructionsCollection instructionsCollection, ISymbolsCollection symbolsCollection)
		{
			var binaryInstructionCollection = new BinaryInstructionCollection();

			foreach (var instruction in instructionsCollection.Instructions)
			{
				var numericValue = -1;

				// handle A - instruction
				if (instruction.Value.StartsWith("@"))
				{
					var trimmedInstruction = instruction.Value.TrimStart('@');
					var textValue = trimmedInstruction;

					if (symbolsCollection.Contains(trimmedInstruction))
					{
						textValue = symbolsCollection.Symbols.First(o => o.Key == trimmedInstruction).Value;
					}

					numericValue = Convert.ToInt16(textValue);
				}

				// handle C - instruction
				else
				{
					var compText = string.Empty;
					var destText = string.Empty;
					var jumpText = string.Empty;
					var instructionTextParts = default(string[]);

					// computation instruction
					if (instruction.Value.Contains('='))
					{
						instructionTextParts = instruction.Value.Split('=');
						destText = instructionTextParts[0];
						compText = instructionTextParts[1];
					}

					// jump instruction
					else
					{
						instructionTextParts = instruction.Value.Split(';');
						compText = instructionTextParts[0];
						jumpText = instructionTextParts[1];
					}

					var compBits = _computationDefinitionsCollection.Definitions.First(o => o.Operation == compText).Bits;
					var destBits = _destinationDefinitionsCollection.Definitions.First(o => o.Operation == destText).Bits;
					var jumpBits = _jumpDefinitionsCollection.Definitions.First(o => o.Operation == jumpText).Bits;

					// combine all
					var resultBits = new List<int>();
					resultBits = resultBits
						.Concat(new int[3] { 1, 1, 1 })
						.Concat(compBits)
						.Concat(destBits)
						.Concat(jumpBits)
						.Reverse()
						.ToList();

					numericValue = Converter.BitArrayToInt(resultBits.ToArray());
				}

				binaryInstructionCollection.Add(new BinaryInstructionEntry(numericValue));
			}

			return binaryInstructionCollection;
		}
	}
}