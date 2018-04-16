using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
   public interface IInstructionsCollection
   {
      IEnumerable<IInstructionEntry> Instructions { get; }

      void RemoveAt(int index);
   }
}