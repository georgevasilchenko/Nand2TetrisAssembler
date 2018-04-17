namespace Nand2TetrisAssembler
{
   /// <summary>SymbolEntry class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.ISymbolEntry" />
   public class SymbolEntry : ISymbolEntry
   {
      /// <summary>Gets the key.</summary>
      /// <value>The key.</value>
      public string Key { get; private set; }

      /// <summary>Gets the value.</summary>
      /// <value>The value.</value>
      public string Value { get; private set; }

      /// <summary>Initializes a new instance of the <see cref="SymbolEntry" /> class.</summary>
      /// <param name="spec">The spec.</param>
      public SymbolEntry(ISymbolEntry spec)
      {
         Key = spec.Key;
         Value = spec.Value;
      }

      /// <summary>Initializes a new instance of the <see cref="SymbolEntry" /> class.</summary>
      /// <param name="key">The key.</param>
      /// <param name="value">The value.</param>
      public SymbolEntry(string key, string value)
      {
         Key = key;
         Value = value;
      }
   }
}