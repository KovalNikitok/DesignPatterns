namespace DesignPatterns.Classes.BehavioralPatterns.Command
{
    // Command interface for concrete command realization
    interface ICommand
    {
        void ExecuteCommand();
        void UndoCommand();
    }
}
