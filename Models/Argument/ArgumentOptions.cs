using CommandLine;

namespace Nand2TetrisAssembler
{
   /// <summary>ArgumentOptions class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IArgumentOptions" />
   public class ArgumentOptions : IArgumentOptions
   {
      /// <summary>Gets or sets the assembly file path.</summary>
      /// <value>The assembly file path.</value>
      [Option('a', "assembly", Required = true, HelpText = "Assembly file path to be processed.")]
      public string AssemblyFilePath { get; set; }

      /// <summary>Gets or sets the hack file path.</summary>
      /// <value>The hack file path.</value>
      [Option('h', "hack", HelpText = "Output Hack file path.")]
      public string HackFilePath { get; set; }
   }
}