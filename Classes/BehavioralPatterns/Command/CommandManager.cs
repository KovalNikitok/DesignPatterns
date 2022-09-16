namespace DesignPatterns.Classes.BehavioralPatterns.Command
{
    // Pult for invoking command
    class CommandManager
    {
        private ICommand _command;
        public CommandManager(ICommand command)
        {
            _command = command;
        }
        public CommandManager() { }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void RunCommand()
        {
            _command.ExecuteCommand();
        }

        public void DropCommand()
        {
            _command.UndoCommand();
        }
    }
}
