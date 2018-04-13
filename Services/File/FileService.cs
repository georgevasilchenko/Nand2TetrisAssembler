using System;
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

		public void WriteHackFile(string text)
		{
		}
	}
}