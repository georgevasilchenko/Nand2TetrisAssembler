using System.IO;
using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
   public class FileService : IFileService
   {
      public IInstructionsCollection GetInstructionsCollection(string path)
      {
         var result = default(InstructionsCollection);
         var lines = File.ReadAllLines(path);

         result = new InstructionsCollection(lines);

         return result;
      }

      public IDefinitionsCollection GetComputationDefinitionsCollection()
      {
         var dto = DeserializeXml<ComputationDefinitionsCollectionDto>(Resources.StaticData.CComputations);
         return new ComputationDefinitionsCollection(dto);
      }

      public ISymbolsCollection GetSymbolsCollection()
      {
         var dto = DeserializeXml<SymbolsCollectionDto>(Resources.StaticData.Symbols);
         return new SymbolsCollection(dto);
      }

      public IDefinitionsCollection GetJumpDefinitionsCollection()
      {
         var dto = DeserializeXml<JumpDefinitionsCollectionDto>(Resources.StaticData.CJumps);
         return new JumpDefinitionsCollection(dto);
      }

      public IDefinitionsCollection GetDestinationDefinitionsCollection()
      {
         var dto = DeserializeXml<DestinationDefinitionsCollectionDto>(Resources.StaticData.CDestinations);
         return new DestinationDefinitionsCollection(dto);
      }

      private TDto DeserializeXml<TDto>(string sourceXml)
      {
         var xmlSerializer = new XmlSerializer(typeof(TDto));
         var dto = default(TDto);

         using (var reader = new StringReader(sourceXml))
         {
            dto = (TDto)xmlSerializer.Deserialize(reader);
         }

         return dto;
      }
   }
}