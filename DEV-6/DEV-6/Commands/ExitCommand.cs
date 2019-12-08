
namespace DEV_6
{
    class ExitCommand : ICommand
    {
        ProgramExit programExit;
        public ExitCommand(ProgramExit programExit)
        {
            this.programExit = programExit;
        }

        public void Execute()
        {
            programExit.ExitProgram();
        }

        public void Undo()
        {
        }
    }
}
