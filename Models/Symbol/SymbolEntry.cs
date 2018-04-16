namespace Nand2TetrisAssembler
{
   public class SymbolEntry : ISymbolEntry
   {
      public string Key { get; private set; }

      public string Value { get; private set; }

      public SymbolEntry(ISymbolEntry spec)
      {
         Key = spec.Key;
         Value = spec.Value;
      }

      public SymbolEntry(string key, string value)
      {
         Key = key;
         Value = value;
      }
   }
}