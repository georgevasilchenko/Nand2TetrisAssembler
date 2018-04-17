using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nand2TetrisAssembler
{
	public interface IBinaryInstructionCollection
	{
		IEnumerable<IBinaryInstructionEntry> Instructions { get; }

		void Add(IBinaryInstructionEntry entry);
	}
}