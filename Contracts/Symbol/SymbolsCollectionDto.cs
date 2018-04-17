using System.Collections.Generic;
using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
   /// <summary>SymbolsCollectionDto class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.ISymbolsCollection" />
   [XmlRoot("symbols-list")]
   public class SymbolsCollectionDto : ISymbolsCollection
   {
      /// <summary>Gets or sets the symbols.</summary>
      /// <value>The symbols.</value>
      [XmlElement("symbol")]
      public List<SymbolEntryDto> Symbols { get; set; }

      /// <summary>Gets the symbols.</summary>
      /// <value>The symbols.</value>
      IEnumerable<ISymbolEntry> ISymbolsCollection.Symbols => Symbols;

      /// <summary>Initializes a new instance of the <see cref="SymbolsCollectionDto" /> class.</summary>
      public SymbolsCollectionDto() => Symbols = new List<SymbolEntryDto>();

      /// <summary>Adds the specified entry.</summary>
      /// <param name="entry">The entry.</param>
      /// <exception cref="System.NotImplementedException">NotImplementedException.</exception>
      void ISymbolsCollection.Add(ISymbolEntry entry) => throw new System.NotImplementedException();

      /// <summary>Determines whether [contains] [the specified key].</summary>
      /// <param name="key">The key.</param>
      /// <returns><c>true</c> if [contains] [the specified key]; otherwise, <c>false</c>.</returns>
      /// <exception cref="System.NotImplementedException">NotImplementedException.</exception>
      bool ISymbolsCollection.Contains(string key) => throw new System.NotImplementedException();
   }
}