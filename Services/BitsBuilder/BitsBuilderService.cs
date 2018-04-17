using System;
using System.Collections.Generic;
using System.Linq;

namespace Nand2TetrisAssembler
{
   /// <summary>BitsBuilderService class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IBitsBuilderService" />
   public class BitsBuilderService : IBitsBuilderService
   {
      /// <summary>Holds the computation definitions collection.</summary>
      private readonly IDefinitionsCollection _computationDefinitionsCollection;

      /// <summary>Holds the jump definitions collection.</summary>
      private readonly IDefinitionsCollection _jumpDefinitionsCollection;

      /// <summary>Holds the destination definitions collection.</summary>
      private readonly IDefinitionsCollection _destinationDefinitionsCollection;

      /// <summary>Initializes a new instance of the <see cref="BitsBuilderService" /> class.</summary>
      /// <param name="computationDefinitionsCollection">The computation definitions collection.</param>
      /// <param name="jumpDefinitionsCollection">The jump definitions collection.</param>
      /// <param name="destinationDefinitionsCollection">The destination definitions collection.</param>
      public BitsBuilderService(
         IDefinitionsCollection computationDefinitionsCollection,
         IDefinitionsCollection jumpDefinitionsCollection,
         IDefinitionsCollection destinationDefinitionsCollection)
      {
         _computationDefinitionsCollection = computationDefinitionsCollection;
         _jumpDefinitionsCollection = jumpDefinitionsCollection;
         _destinationDefinitionsCollection = destinationDefinitionsCollection;
      }

      /// <summary>Builds the binary instruction collection.</summary>
      /// <param name="instructionsCollection">The instructions collection.</param>
      /// <param name="symbolsCollection">The symbols collection.</param>
      /// <returns>A <see cref="IBinaryInstructionCollection" /> reference.</returns>
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

               // computation case
               if (instruction.Value.Contains('='))
               {
                  instructionTextParts = instruction.Value.Split('=');
                  destText = instructionTextParts[0];
                  compText = instructionTextParts[1];
               }

               // jump case
               else
               {
                  instructionTextParts = instruction.Value.Split(';');
                  compText = instructionTextParts[0];
                  jumpText = instructionTextParts[1];
               }

               var compBits = _computationDefinitionsCollection.Definitions.First(o => o.Operation == compText).Bits;
               var destBits = _destinationDefinitionsCollection.Definitions.First(o => o.Operation == destText).Bits;
               var jumpBits = _jumpDefinitionsCollection.Definitions.First(o => o.Operation == jumpText).Bits;

               // combine
               var resultBits = new List<int>();
               resultBits = resultBits
                  .Concat(jumpBits)
                  .Concat(destBits)
                  .Concat(compBits)
                  .Concat(new int[3] { 1, 1, 1 })
                  .ToList();

               numericValue = Converter.BitArrayToInt(resultBits.ToArray());
            }

            binaryInstructionCollection.Add(new BinaryInstructionEntry(numericValue));
         }

         return binaryInstructionCollection;
      }
   }
}