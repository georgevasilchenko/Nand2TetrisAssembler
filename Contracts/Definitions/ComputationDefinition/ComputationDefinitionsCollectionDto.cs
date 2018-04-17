using System.Collections.Generic;
using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
   /// <summary>ComputationDefinitionsCollectionDto class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IDefinitionsCollection" />
   [XmlRoot("computations-list")]
   public class ComputationDefinitionsCollectionDto : IDefinitionsCollection
   {
      /// <summary>Gets or sets the definitions.</summary>
      /// <value>The definitions.</value>
      [XmlElement("computation")]
      public List<ComputationDefinitionEntryDto> Definitions { get; set; }

      /// <summary>Gets the definitions.</summary>
      /// <value>The definitions.</value>
      IEnumerable<IDefinitionEntry> IDefinitionsCollection.Definitions => Definitions;

      /// <summary>
      /// Initializes a new instance of the <see cref="ComputationDefinitionsCollectionDto" /> class.
      /// </summary>
      public ComputationDefinitionsCollectionDto() => Definitions = new List<ComputationDefinitionEntryDto>();
   }
}