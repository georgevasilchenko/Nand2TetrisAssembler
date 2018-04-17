using System.Linq;

namespace Nand2TetrisAssembler
{
   /// <summary>ComputationDefinitionEntry class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IDefinitionEntry" />
   public class ComputationDefinitionEntry : IDefinitionEntry
   {
      /// <summary>Gets the operation.</summary>
      /// <value>The operation.</value>
      public string Operation { get; private set; }

      /// <summary>Gets the code.</summary>
      /// <value>The code.</value>
      public int Code { get; private set; }

      /// <summary>Gets the bits.</summary>
      /// <value>The bits.</value>
      public int[] Bits => Converter.IntToBitArray(Code, 7).ToArray();

      /// <summary>
      /// Initializes a new instance of the <see cref="ComputationDefinitionEntry" /> class.
      /// </summary>
      /// <param name="spec">The spec.</param>
      public ComputationDefinitionEntry(IDefinitionEntry spec)
      {
         Operation = spec.Operation;
         Code = spec.Code;
      }
   }
}