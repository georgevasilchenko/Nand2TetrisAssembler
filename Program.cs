using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nand2TetrisAssembler
{
   class Program
   {
      static void Main(string[] args)
      {
         var lines = File.ReadAllLines(@"C:\Users\admin\Documents\GitHub\Nand2TetrisAssembler\Rect.asm");

         var helper = new Helper();
         var instructionsLines = helper.CleanCommentsAndWhiteSpace(lines);

         helper.ExtractLabels(instructionsLines);
         helper.ExtractVariables(instructionsLines);
      }
   }
}
