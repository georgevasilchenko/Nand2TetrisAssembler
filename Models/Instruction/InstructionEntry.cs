namespace Nand2TetrisAssembler
{
   /// <summary>InstructionEntry class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IInstructionEntry" />
   public class InstructionEntry : IInstructionEntry
   {
      /// <summary>Gets the value.</summary>
      /// <value>The value.</value>
      public string Value { get; private set; }

      /// <summary>Initializes a new instance of the <see cref="InstructionEntry" /> class.</summary>
      /// <param name="spec">The spec.</param>
      public InstructionEntry(IInstructionEntry spec) => Value = spec.Value;

      /// <summary>Initializes a new instance of the <see cref="InstructionEntry" /> class.</summary>
      /// <param name="value">The value.</param>
      public InstructionEntry(string value) => Value = value;
   }
}