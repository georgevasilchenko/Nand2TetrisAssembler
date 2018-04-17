namespace Nand2TetrisAssembler
{
   /// <summary>ISymbolEntry interface.</summary>
   public interface ISymbolEntry
   {
      /// <summary>Gets the key.</summary>
      /// <value>The key.</value>
      string Key { get; }

      /// <summary>Gets the value.</summary>
      /// <value>The value.</value>
      string Value { get; }
   }
}