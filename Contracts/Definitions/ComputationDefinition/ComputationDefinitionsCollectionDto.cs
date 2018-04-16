using System.Collections.Generic;
using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
	[XmlRoot("computations-list")]
	public class ComputationDefinitionsCollectionDto : IDefinitionsCollection
	{
		[XmlElement("computation")]
		public List<ComputationDefinitionEntryDto> Definitions { get; set; }

		IEnumerable<IDefinitionEntry> IDefinitionsCollection.Definitions => Definitions;

		public ComputationDefinitionsCollectionDto() => Definitions = new List<ComputationDefinitionEntryDto>();
	}
}