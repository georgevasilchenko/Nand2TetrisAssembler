using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
   /// <summary>IDefinitionsCollection interface.</summary>
   public interface IDefinitionsCollection
   {
      /// <summary>Gets the definitions.</summary>
      /// <value>The definitions.</value>
      IEnumerable<IDefinitionEntry> Definitions { get; }
   }
}