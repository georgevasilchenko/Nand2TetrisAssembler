using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
   /// <summary>ComputationDefinitionEntryDto class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IDefinitionEntry" />
   public class ComputationDefinitionEntryDto : IDefinitionEntry
   {
      /// <summary>Gets or sets the operation.</summary>
      /// <value>The operation.</value>
      [XmlAttribute(AttributeName = "operation", Namespace = "")]
      public string Operation { get; set; }

      /// <summary>Gets or sets the code.</summary>
      /// <value>The code.</value>
      [XmlAttribute(AttributeName = "code", Namespace = "")]
      public int Code { get; set; }

      /// <summary>Gets the bits.</summary>
      /// <value>The bits.</value>
      [XmlIgnore]
      public int[] Bits => null;
   }
}