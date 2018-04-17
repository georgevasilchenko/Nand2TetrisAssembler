using System;
using System.Collections.Generic;
using System.Linq;

namespace Nand2TetrisAssembler
{
	public class InstructionService : IInstructionService
	{
		private readonly ISymbolsCollection _symbolsCollection;
		private IInstructionsCollection _instructionsCollection;
		private readonly IBitsBuilderService _bitsBuilderService;

		public InstructionService(
			IInstructionsCollection instructionsCollection,
			ISymbolsCollection symbolsCollection,
			IBitsBuilderService bitsBuilderService)
		{
			_instructionsCollection = instructionsCollection;
			_symbolsCollection = symbolsCollection;
			_bitsBuilderService = bitsBuilderService;

			CleanCommentsAndWhiteSpace();
			ExtractLabelsFromInstructions();
			ExtractVariablesFromInstructions();
		}

		public void Assemble()
		{
			var result = _bitsBuilderService.BuildBinaryInstructionCollection(_instructionsCollection, _symbolsCollection);
		}

		private void CleanCommentsAndWhiteSpace()
		{
			var cleanInstructions = new InstructionsCollection();

			foreach (var instruction in _instructionsCollection.Instructions)
			{
				// skip empty lines
				if (string.IsNullOrWhiteSpace(instruction.Value))
				{
					continue;
				}

				// skip pure comment comment
				if (instruction.Value.StartsWith("//"))
				{
					continue;
				}

				// remove whitespace from combined lines
				var cleanLine = string.Empty;
				cleanLine = instruction.Value.Replace(" ", "");

				if (cleanLine.Contains("//"))
				{
					var startIndex = cleanLine.IndexOf("//");
					cleanLine = cleanLine.Substring(0, startIndex);
				}

				cleanInstructions.Add(new InstructionEntry(cleanLine));
			}

			_instructionsCollection = new InstructionsCollection(cleanInstructions);
		}

		private void ExtractVariablesFromInstructions()
		{
			var variablesStartIndex = 16;

			foreach (var instruction in _instructionsCollection.Instructions)
			{
				if (instruction.Value.Contains("@"))
				{
					var variableName = instruction.Value.Substring(1, instruction.Value.Length - 1);

					if (int.TryParse(variableName, out var parsedNumber))
					{
						continue;
					}
					else if (_symbolsCollection.Symbols.FirstOrDefault(o => o.Key == variableName) == null)
					{
						var newSymbolEntry = new SymbolEntry(variableName, (variablesStartIndex++).ToString());
						_symbolsCollection.Add(newSymbolEntry);
					}
				}
			}
		}

		private void ExtractLabelsFromInstructions()
		{
			var index = 0;
			var indicesToRemove = new List<int>();

			foreach (var instruction in _instructionsCollection.Instructions)
			{
				if (instruction.Value.Contains("("))
				{
					var label = instruction.Value.Replace("(", "");
					label = label.Replace(")", "");

					var newSymbolEntry = new SymbolEntry(label, (index + 1).ToString());
					_symbolsCollection.Add(newSymbolEntry);

					indicesToRemove.Add(index);
				}

				index++;
			}

			for (var i = indicesToRemove.Count - 1; i >= 0; i--)
			{
				_instructionsCollection.RemoveAt(indicesToRemove[i]);
			}
		}
	}
}