using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nand2TetrisAssembler
{
   public class Helper
   {
      public Dictionary<string, string> SymbolsDictionary { get; private set; }
      

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

      public Helper()
      {
         SymbolsDictionary = new Dictionary<string, string>
         {
            { "R0", "0" },
            { "R1", "1" },
            { "R2", "2" },
            { "R3", "3" },
            { "R4", "4" },
            { "R5", "5" },
            { "R6", "6" },
            { "R7", "7" },
            { "R8", "8" },
            { "R9", "9" },
            { "R10", "10" },
            { "R11", "11" },
            { "R12", "12" },
            { "R13", "13" },
            { "R14", "14" },
            { "R15", "15" },
            { "SCREEN", "16384" },
            { "KBD", "24576" },
            { "SP", "0" },
            { "LCL", "1" },
            { "ARG", "2" },
            { "THIS", "3" },
            { "THAT", "4" }
         };
      }

      public void ExtractLabels(IEnumerable<string> instructionsLines)
      {
         var index = 0;

         foreach (var line in instructionsLines)
         {
            if(line.Contains("("))
            {
               var label = line.Replace("(", "");
               label = label.Replace(")", "");

               SymbolsDictionary.Add(label, (index + 1).ToString());
            }

            index++;
         }
      }

      public void ExtractVariables(IEnumerable<string> instructionsLines)
      {
         var variablesStartIndex = 16;

         foreach (var line in instructionsLines)
         {
            if (line.Contains("@"))
            {
               var variableName = line.Substring(1, line.Length - 1);

               if (int.TryParse(variableName, out var parsedNumber))
               {
                  continue;
               }
               else if (!SymbolsDictionary.ContainsKey(variableName))
               {
                  SymbolsDictionary.Add(variableName, (variablesStartIndex++).ToString());
               }
            }
         }
      }

      public IEnumerable<string> ReplaceSymbols
   }
}
