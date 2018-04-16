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
			var xmlSource = Resources.StaticData.c_computations;
			var xmlSerializer = new XmlSerializer(typeof(ComputationDefinitionsCollectionDto));
			var dto = default(ComputationDefinitionsCollectionDto);

			using (var reader = new StringReader(xmlSource))
			{
				dto = (ComputationDefinitionsCollectionDto)xmlSerializer.Deserialize(reader);
			}

			return new ComputationDefinitionsCollection(dto);
		}

		public ISymbolsCollection GetSymbolsCollection(string path)
		{
			var xmlSerializer = new XmlSerializer(typeof(SymbolsCollectionDto));
			var dto = default(SymbolsCollectionDto);

			using (var stream = new FileStream(path, FileMode.Open))
			{
				dto = (SymbolsCollectionDto)xmlSerializer.Deserialize(stream);
			}

			return new SymbolsCollection(dto);
		}

		public IDefinitionsCollection GetJumpDefinitionsCollection()
		{
			var xmlSource = Resources.StaticData.c_jumps;
			var xmlSerializer = new XmlSerializer(typeof(JumpDefinitionsCollectionDto));
			var dto = default(JumpDefinitionsCollectionDto);

			using (var reader = new StringReader(xmlSource))
			{
				dto = (JumpDefinitionsCollectionDto)xmlSerializer.Deserialize(reader);
			}

			return new JumpDefinitionsCollection(dto);
		}

		public IDefinitionsCollection GetDestinationDefinitionsCollection()
		{
			var xmlSource = Resources.StaticData.c_destinations;
			var xmlSerializer = new XmlSerializer(typeof(DestinationDefinitionsCollectionDto));
			var dto = default(DestinationDefinitionsCollectionDto);

			using (var reader = new StringReader(xmlSource))
			{
				dto = (DestinationDefinitionsCollectionDto)xmlSerializer.Deserialize(reader);
			}

			return new DestinationDefinitionsCollection(dto);
		}
	}
}