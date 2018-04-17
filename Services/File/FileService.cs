using System.IO;
using System.Xml.Serialization;

namespace Nand2TetrisAssembler
{
   /// <summary>FileService class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IFileService" />
   public class FileService : IFileService
   {
      /// <summary>Gets the instructions collection.</summary>
      /// <param name="path">The path.</param>
      /// <returns>A <see cref="IInstructionsCollection" /> reference.</returns>
      public IInstructionsCollection GetInstructionsCollection(string path)
      {
         var result = default(InstructionsCollection);
         var lines = File.ReadAllLines(path);

         result = new InstructionsCollection(lines);

         return result;
      }

      /// <summary>Gets the computation definitions collection.</summary>
      /// <returns>A <see cref="IDefinitionsCollection" /> reference.</returns>
      public IDefinitionsCollection GetComputationDefinitionsCollection()
      {
         var dto = DeserializeXml<ComputationDefinitionsCollectionDto>(Resources.StaticData.CComputations);
         return new ComputationDefinitionsCollection(dto);
      }

      /// <summary>Gets the symbols collection.</summary>
      /// <returns>A <see cref="ISymbolsCollection" /> reference.</returns>
      public ISymbolsCollection GetSymbolsCollection()
      {
         var dto = DeserializeXml<SymbolsCollectionDto>(Resources.StaticData.Symbols);
         return new SymbolsCollection(dto);
      }

      /// <summary>Gets the jump definitions collection.</summary>
      /// <returns>A <see cref="IDefinitionsCollection" /> reference.</returns>
      public IDefinitionsCollection GetJumpDefinitionsCollection()
      {
         var dto = DeserializeXml<JumpDefinitionsCollectionDto>(Resources.StaticData.CJumps);
         return new JumpDefinitionsCollection(dto);
      }

      /// <summary>Gets the destination definitions collection.</summary>
      /// <returns>A <see cref="IDefinitionsCollection" /> reference.</returns>
      public IDefinitionsCollection GetDestinationDefinitionsCollection()
      {
         var dto = DeserializeXml<DestinationDefinitionsCollectionDto>(Resources.StaticData.CDestinations);
         return new DestinationDefinitionsCollection(dto);
      }

      /// <summary>Outputs the hack file.</summary>
      /// <param name="hackInstructionsText">The hack instructions text.</param>
      /// <param name="path">The path.</param>
      public void OutputHackFile(string hackInstructionsText, string path) => File.WriteAllText(path, hackInstructionsText);

      /// <summary>Deserializes the XML.</summary>
      /// <typeparam name="TDto">The type of the dto.</typeparam>
      /// <param name="sourceXml">The source XML.</param>
      /// <returns>A <see cref="TDto" /> reference.</returns>
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