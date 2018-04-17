namespace Nand2TetrisAssembler
{
   public interface IFileService
   {
      ISymbolsCollection GetSymbolsCollection();

      IInstructionsCollection GetInstructionsCollection(string path);

      IDefinitionsCollection GetComputationDefinitionsCollection();

      IDefinitionsCollection GetJumpDefinitionsCollection();

      IDefinitionsCollection GetDestinationDefinitionsCollection();

      void OutputHackFile(string hackInstructionsText, string path);
   }
}