namespace DesignPatterns.Classes.BehavioralPatterns.Command
{
    class CarCentralLockCommand : ICommand
    {
        private CarCentralLock _carCentralLock;
        public CarCentralLockCommand(CarCentralLock centralLock)
        {
            _carCentralLock = centralLock;
        }
        public void ExecuteCommand()
        {
            _carCentralLock.OpenCarDoors();
        }

        public void UndoCommand()
        {
            _carCentralLock.CloseCarDoors();
        }
    }
}
