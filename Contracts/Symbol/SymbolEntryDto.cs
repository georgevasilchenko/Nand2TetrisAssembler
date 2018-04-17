using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
   /// <summary>SymbolEntryDto class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.ISymbolEntry" />
   public class SymbolEntryDto : ISymbolEntry
   {
      /// <summary>Gets or sets the key.</summary>
      /// <value>The key.</value>
      [XmlAttribute(AttributeName = "key", Namespace = "")]
      public string Key { get; set; }

      /// <summary>Gets or sets the value.</summary>
      /// <value>The value.</value>
      [XmlAttribute(AttributeName = "value", Namespace = "")]
      public string Value { get; set; }
   }
}