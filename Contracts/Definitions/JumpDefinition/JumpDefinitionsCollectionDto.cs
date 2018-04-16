using System.Collections.Generic;
using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
	[XmlRoot("jumps-list")]
	public class JumpDefinitionsCollectionDto : IDefinitionsCollection
	{
		[XmlElement("jump")]
		public List<JumpDefinitionEntryDto> Definitions { get; set; }

		IEnumerable<IDefinitionEntry> IDefinitionsCollection.Definitions => Definitions;

		public JumpDefinitionsCollectionDto() => Definitions = new List<JumpDefinitionEntryDto>();
	}
}