using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nand2TetrisAssembler
{
   public class Helper
   {
      public IEnumerable<string> CleanCommentsAndWhiteSpace(IEnumerable<string> textLines)
      {
         var cleanLines = new List<string>();

         foreach (var line in textLines)
         {
            // skip empty lines
            if (string.IsNullOrWhiteSpace(line))
            {
               continue;
            }

            // skip pure comment comment
            if (line.StartsWith("//"))
            {
               continue;
            }

            // remove whitespace from combined lines
            var cleanLine = string.Empty;
            cleanLine = line.Replace(" ", "");

            if (cleanLine.Contains("//"))
            {
               var startIndex = cleanLine.IndexOf("//");
               cleanLine = cleanLine.Substring(0, startIndex);
            }

            cleanLines.Add(cleanLine);
         }

         return cleanLines;
      }
   }
}
