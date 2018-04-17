using System.Collections;
using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
   /// <summary>ComputationDefinitionsCollection class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IDefinitionsCollection" />
   /// <seealso cref="System.Collections.Generic.IEnumerable{Nand2TetrisAssembler.IDefinitionEntry}" />
   /// <seealso cref="System.Collections.Generic.IReadOnlyCollection{Nand2TetrisAssembler.IDefinitionEntry}" />
   public class ComputationDefinitionsCollection : IDefinitionsCollection, IEnumerable<IDefinitionEntry>, IReadOnlyCollection<IDefinitionEntry>
   {
      /// <summary>Gets the definitions.</summary>
      /// <value>The definitions.</value>
      public IReadOnlyCollection<IDefinitionEntry> Definitions { get; private set; }

      /// <summary>Gets the number of elements in the collection.</summary>
      public int Count => Definitions.Count;

      /// <summary>Gets the definitions.</summary>
      /// <value>The definitions.</value>
      IEnumerable<IDefinitionEntry> IDefinitionsCollection.Definitions => Definitions;

      /// <summary>
      /// Initializes a new instance of the <see cref="ComputationDefinitionsCollection" /> class.
      /// </summary>
      /// <param name="definitionsCollectionSpecifiction">The definitions collection specifiction.</param>
      public ComputationDefinitionsCollection(IDefinitionsCollection definitionsCollectionSpecifiction)
      {
         var temp = new List<IDefinitionEntry>();

         foreach (var definitionSpecification in definitionsCollectionSpecifiction.Definitions)
         {
            temp.Add(new ComputationDefinitionEntry(definitionSpecification));
         }

         Definitions = temp;
      }

      /// <summary>Returns an enumerator that iterates through the collection.</summary>
      /// <returns>An enumerator that can be used to iterate through the collection.</returns>
      public IEnumerator<IDefinitionEntry> GetEnumerator() => Definitions.GetEnumerator();

      /// <summary>Returns an enumerator that iterates through a collection.</summary>
      /// <returns>
      /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate
      /// through the collection.
      /// </returns>
      IEnumerator IEnumerable.GetEnumerator() => Definitions.GetEnumerator();
   }
}