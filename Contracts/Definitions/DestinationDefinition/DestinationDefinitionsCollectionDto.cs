using System.Collections.Generic;
using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
	[XmlRoot("destinations-list")]
	public class DestinationDefinitionsCollectionDto : IDefinitionsCollection
	{
		[XmlElement("destination")]
		public List<DestinationDefinitionEntryDto> Definitions { get; set; }

		IEnumerable<IDefinitionEntry> IDefinitionsCollection.Definitions => Definitions;

		public DestinationDefinitionsCollectionDto() => Definitions = new List<DestinationDefinitionEntryDto>();
	}
}