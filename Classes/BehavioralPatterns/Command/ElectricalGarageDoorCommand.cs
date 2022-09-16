namespace DesignPatterns.Classes.BehavioralPatterns.Command
{
    class ElectricalGarageDoorCommand : ICommand
    {
        private ElectricalGarageDoor _garageDoor;
        public ElectricalGarageDoorCommand(ElectricalGarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void ExecuteCommand()
        {
            _garageDoor.OpenGarageDoor();
        }

        public void UndoCommand()
        {
            _garageDoor.CloseGarageDoor();
        }
    }
}
