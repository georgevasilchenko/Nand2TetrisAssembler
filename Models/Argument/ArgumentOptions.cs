using CommandLine;

namespace Nand2TetrisAssembler
{
   public class ArgumentOptions : IArgumentOptions
   {
      [Option('a', "assembly", Required = true, HelpText = "Assembly file path to be processed.")]
      public string AssemblyFilePath { get; set; }

      [Option('h', "hack", HelpText = "Output Hack file path.")]
      public string HackFilePath { get; set; }
   }
}