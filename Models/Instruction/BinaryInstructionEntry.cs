using System;

namespace Nand2TetrisAssembler
{
   public class BinaryInstructionEntry : IBinaryInstructionEntry
   {
      public int[] Code { get; private set; }

      public BinaryInstructionEntry(IInstructionEntry instructionEntry)
      {
         if (instructionEntry.Value.StartsWith("@"))
         {
            CreateFromAInstruction(instructionEntry);
         }
         else
         {
            CreateFromCInstruction(instructionEntry);
         }
      }

      public override string ToString()
      {
         return "";
      }

      private void CreateFromCInstruction(IInstructionEntry instructionEntry)
      {
      }

      private void CreateFromAInstruction(IInstructionEntry instructionEntry) => throw new NotImplementedException();
   }
}