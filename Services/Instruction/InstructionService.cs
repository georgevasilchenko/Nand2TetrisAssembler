using System.Collections.Generic;
using System.Linq;

namespace Nand2TetrisAssembler
{
   /// <summary>InstructionService class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IInstructionService" />
   public class InstructionService : IInstructionService
   {
      /// <summary>Holds the symbols collection.</summary>
      private readonly ISymbolsCollection _symbolsCollection;

      /// <summary>Holds the builder service.</summary>
      private readonly IBitsBuilderService _bitsBuilderService;

      /// <summary>Holds the instructions collection.</summary>
      private IInstructionsCollection _instructionsCollection;

      /// <summary>Initializes a new instance of the <see cref="InstructionService" /> class.</summary>
      /// <param name="instructionsCollection">The instructions collection.</param>
      /// <param name="symbolsCollection">The symbols collection.</param>
      /// <param name="bitsBuilderService">The bits builder service.</param>
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

      /// <summary>Assembles this instance.</summary>
      /// <returns>A <see cref="string" /> reference.</returns>
      public string Assemble()
      {
         var result = _bitsBuilderService.BuildBinaryInstructionCollection(_instructionsCollection, _symbolsCollection);
         return result.GetInstructionsText();
      }

      /// <summary>Cleans the comments and white space.</summary>
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

         _instructionsCollection = new InstructionsCollection(cleanInstructions as IInstructionsCollection);
      }

      /// <summary>Extracts the variables from instructions.</summary>
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

      /// <summary>Extracts the labels from instructions.</summary>
      private void ExtractLabelsFromInstructions()
      {
         var index = 0;
         var indicesToRemove = new List<int>();
         var foundLabels = 0;

         foreach (var instruction in _instructionsCollection.Instructions)
         {
            if (instruction.Value.Contains("("))
            {
               var label = instruction.Value.Replace("(", "");
               label = label.Replace(")", "");

               var newSymbolEntry = new SymbolEntry(label, (index - foundLabels++).ToString());
               _symbolsCollection.Add(newSymbolEntry);
            }

            index++;
         }

         _instructionsCollection = new InstructionsCollection(_instructionsCollection.Instructions.Where(o => !o.Value.Contains("(")));
      }
   }
}