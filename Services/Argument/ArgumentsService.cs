namespace Nand2TetrisAssembler
{
   /// <summary>ArgumentService class.</summary>
   /// <seealso cref="Nand2TetrisAssembler.IArgumentService" />
   public class ArgumentService : IArgumentService
   {
      /// <summary>Holds the arguments.</summary>
      private readonly string[] _arguments;

      /// <summary>Initializes a new instance of the <see cref="ArgumentService" /> class.</summary>
      /// <param name="arguments">The arguments.</param>
      public ArgumentService(string[] arguments) => _arguments = arguments;

      /// <summary>Gets the options.</summary>
      /// <returns></returns>
      public IArgumentOptions GetOptions()
      {
         var options = new ArgumentOptions();
         CommandLine.Parser.Default.ParseArguments(() => options, _arguments);
         return options;
      }
   }
}