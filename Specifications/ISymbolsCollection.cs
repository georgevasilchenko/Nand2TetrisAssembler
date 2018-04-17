using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
   /// <summary>ISymbolsCollection interface.</summary>
   public interface ISymbolsCollection
   {
      /// <summary>Gets the symbols.</summary>
      /// <value>The symbols.</value>
      IEnumerable<ISymbolEntry> Symbols { get; }

      /// <summary>Adds the specified entry.</summary>
      /// <param name="entry">The entry.</param>
      void Add(ISymbolEntry entry);

      /// <summary>Determines whether [contains] [the specified key].</summary>
      /// <param name="key">The key.</param>
      /// <returns><c>true</c> if [contains] [the specified key]; otherwise, <c>false</c>.</returns>
      bool Contains(string key);
   }
}