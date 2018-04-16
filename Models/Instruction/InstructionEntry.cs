namespace Nand2TetrisAssembler
{
   public class InstructionEntry : IInstructionEntry
   {
      public string Value { get; private set; }

      public InstructionEntry(IInstructionEntry spec) => Value = spec.Value;

      public InstructionEntry(string value) => Value = value;
   }
}