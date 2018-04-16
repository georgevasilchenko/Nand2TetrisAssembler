using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
	public class JumpDefinitionEntryDto : IDefinitionEntry
	{
		[XmlAttribute(AttributeName = "operation", Namespace = "")]
		public string Operation { get; set; }

		[XmlAttribute(AttributeName = "code", Namespace = "")]
		public int Code { get; set; }

		[XmlIgnore]
		public int[] Bits => null;
	}
}