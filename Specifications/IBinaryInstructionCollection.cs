using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
   /// <summary>IBinaryInstructionCollection class.</summary>
   public interface IBinaryInstructionCollection
   {
      /// <summary>Gets the instructions.</summary>
      /// <value>The instructions.</value>
      IEnumerable<IBinaryInstructionEntry> Instructions { get; }

      /// <summary>Gets the instructions lines text.</summary>
      /// <returns>A <see cref="string[]" /> reference.</returns>
      string[] GetInstructionsLinesText();

      /// <summary>Gets the instructions text.</summary>
      /// <returns>A <see cref="string" /> reference.</returns>
      string GetInstructionsText();

      /// <summary>Adds the specified entry.</summary>
      /// <param name="entry">The entry.</param>
      void Add(IBinaryInstructionEntry entry);
   }
}