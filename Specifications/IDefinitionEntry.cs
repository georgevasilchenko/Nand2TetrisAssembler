namespace Nand2TetrisAssembler
{
   /// <summary>IDefinitionEntry interface.</summary>
   public interface IDefinitionEntry
   {
      /// <summary>Gets the operation.</summary>
      /// <value>The operation.</value>
      string Operation { get; }

      /// <summary>Gets the code.</summary>
      /// <value>The code.</value>
      int Code { get; }

      /// <summary>Gets the bits.</summary>
      /// <value>The bits.</value>
      int[] Bits { get; }
   }
}