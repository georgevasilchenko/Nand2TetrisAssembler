using System.Collections.Generic;
using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
   /// <summary>DestinationDefinitionsCollectionDto class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IDefinitionsCollection" />
   [XmlRoot("destinations-list")]
   public class DestinationDefinitionsCollectionDto : IDefinitionsCollection
   {
      /// <summary>Gets or sets the definitions.</summary>
      /// <value>The definitions.</value>
      [XmlElement("destination")]
      public List<DestinationDefinitionEntryDto> Definitions { get; set; }

      /// <summary>Gets the definitions.</summary>
      /// <value>The definitions.</value>
      IEnumerable<IDefinitionEntry> IDefinitionsCollection.Definitions => Definitions;

      /// <summary>
      /// Initializes a new instance of the <see cref="DestinationDefinitionsCollectionDto" /> class.
      /// </summary>
      public DestinationDefinitionsCollectionDto() => Definitions = new List<DestinationDefinitionEntryDto>();
   }
}