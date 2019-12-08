
namespace DEV_6
{
    class Invoker
    {
        ICommand command;

        public Invoker() 
        {
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void Run()
        {
            command.Execute();
        }
        public void Cancel()
        {
            command.Undo();
        }
    }
}
