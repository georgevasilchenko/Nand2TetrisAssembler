using System.Linq;

namespace Nand2TetrisAssembler
{
   /// <summary>BinaryInstructionEntry class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IBinaryInstructionEntry" />
   public class BinaryInstructionEntry : IBinaryInstructionEntry
   {
      /// <summary>Gets the code.</summary>
      /// <value>The code.</value>
      public int[] Code { get; private set; }

      /// <summary>Initializes a new instance of the <see cref="BinaryInstructionEntry" /> class.</summary>
      /// <param name="number">The number.</param>
      public BinaryInstructionEntry(int number) => Code = Converter.IntToBitArray(number).ToArray();

      /// <summary>Initializes a new instance of the <see cref="BinaryInstructionEntry" /> class.</summary>
      /// <param name="spec">The spec.</param>
      public BinaryInstructionEntry(IBinaryInstructionEntry spec) => Code = spec.Code;

      /// <summary>Returns a <see cref="System.String" /> that represents this instance.</summary>
      /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
      public override string ToString() => string.Join("", Code.Reverse());
   }
}