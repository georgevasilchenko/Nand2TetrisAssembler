using System.Collections.Generic;
using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
   /// <summary>JumpDefinitionsCollectionDto class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IDefinitionsCollection" />
   [XmlRoot("jumps-list")]
   public class JumpDefinitionsCollectionDto : IDefinitionsCollection
   {
      /// <summary>Gets or sets the definitions.</summary>
      /// <value>The definitions.</value>
      [XmlElement("jump")]
      public List<JumpDefinitionEntryDto> Definitions { get; set; }

      /// <summary>Gets the definitions.</summary>
      /// <value>The definitions.</value>
      IEnumerable<IDefinitionEntry> IDefinitionsCollection.Definitions => Definitions;

      /// <summary>
      /// Initializes a new instance of the <see cref="JumpDefinitionsCollectionDto" /> class.
      /// </summary>
      public JumpDefinitionsCollectionDto() => Definitions = new List<JumpDefinitionEntryDto>();
   }
}