using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
   /// <summary>IInstructionsCollection interface.</summary>
   public interface IInstructionsCollection
   {
      /// <summary>Gets the instructions.</summary>
      /// <value>The instructions.</value>
      IEnumerable<IInstructionEntry> Instructions { get; }

      /// <summary>Removes at.</summary>
      /// <param name="index">The index.</param>
      void RemoveAt(int index);
   }
}