using System.Collections;
using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
   public class JumpDefinitionsCollection : IDefinitionsCollection, IEnumerable<IDefinitionEntry>, IReadOnlyCollection<IDefinitionEntry>
   {
      public IReadOnlyCollection<IDefinitionEntry> Definitions { get; private set; }

      public int Count => Definitions.Count;

      IEnumerable<IDefinitionEntry> IDefinitionsCollection.Definitions => Definitions;

      public JumpDefinitionsCollection(IDefinitionsCollection definitionsCollectionSpecifiction)
      {
         var temp = new List<IDefinitionEntry>();

         foreach (var definitionSpecification in definitionsCollectionSpecifiction.Definitions)
         {
            temp.Add(new JumpDefinitionEntry(definitionSpecification));
         }

         Definitions = temp;
      }

      public IEnumerator<IDefinitionEntry> GetEnumerator() => Definitions.GetEnumerator();

      IEnumerator IEnumerable.GetEnumerator() => Definitions.GetEnumerator();
   }
}