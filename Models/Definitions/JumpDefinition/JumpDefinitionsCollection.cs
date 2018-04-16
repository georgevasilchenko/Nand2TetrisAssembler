using System.Collections;
using System.Collections.Generic;

namespace Nand2TetrisAssembler
{
	public class JumpDefinitionsCollection : IDefinitionsCollection, IEnumerable<IDefinitionEntry>, IReadOnlyCollection<IDefinitionEntry>
	{
		public IReadOnlyCollection<IDefinitionEntry> Definitions { get; set; }

		public JumpDefinitionsCollection(IDefinitionsCollection definitionsCollectionSpecifiction)
		{
			var temp = new List<IDefinitionEntry>();

			foreach (var definitionSpecification in definitionsCollectionSpecifiction.Definitions)
			{
				temp.Add(new JumpDefinitionEntry(definitionSpecification));
			}

			Definitions = temp;
		}

		public int Count => Definitions.Count;

		public IEnumerator<IDefinitionEntry> GetEnumerator() => Definitions.GetEnumerator();

		IEnumerable<IDefinitionEntry> IDefinitionsCollection.Definitions => Definitions;

		IEnumerator IEnumerable.GetEnumerator() => Definitions.GetEnumerator();
	}
}