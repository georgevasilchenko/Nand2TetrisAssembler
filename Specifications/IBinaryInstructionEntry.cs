namespace Nand2TetrisAssembler
{
   /// <summary>IBinaryInstructionEntry class.</summary>
   public interface IBinaryInstructionEntry
   {
      /// <summary>Gets the code.</summary>
      /// <value>The code.</value>
      int[] Code { get; }

      /// <summary>Returns a <see cref="System.String" /> that represents this instance.</summary>
      /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
      string ToString();
   }
}