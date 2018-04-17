namespace Nand2TetrisAssembler
{
   /// <summary>IArgumentOptions class.</summary>
   public interface IArgumentOptions
   {
      /// <summary>Gets the assembly file path.</summary>
      /// <value>The assembly file path.</value>
      string AssemblyFilePath { get; }

      /// <summary>Gets the hack file path.</summary>
      /// <value>The hack file path.</value>
      string HackFilePath { get; }
   }
}