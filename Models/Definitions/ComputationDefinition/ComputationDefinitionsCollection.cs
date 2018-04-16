using System.Collections;
using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
   public class ComputationDefinitionsCollection : IDefinitionsCollection, IEnumerable<IDefinitionEntry>, IReadOnlyCollection<IDefinitionEntry>
   {
      public IReadOnlyCollection<IDefinitionEntry> Definitions { get; private set; }

      public int Count => Definitions.Count;

      IEnumerable<IDefinitionEntry> IDefinitionsCollection.Definitions => Definitions;

      public ComputationDefinitionsCollection(IDefinitionsCollection definitionsCollectionSpecifiction)
      {
         var temp = new List<IDefinitionEntry>();

         foreach (var definitionSpecification in definitionsCollectionSpecifiction.Definitions)
         {
            temp.Add(new ComputationDefinitionEntry(definitionSpecification));
         }

         Definitions = temp;
      }

      public IEnumerator<IDefinitionEntry> GetEnumerator() => Definitions.GetEnumerator();

      IEnumerator IEnumerable.GetEnumerator() => Definitions.GetEnumerator();
   }
}