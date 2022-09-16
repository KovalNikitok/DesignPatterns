namespace DesignPatterns.Classes.BehavioralPatterns.Command
{
    class CarCentralLock
    {
        public CarCentralLock(bool isCarOpen)
        {
            IsCarOpen = isCarOpen;
        }
        public bool IsCarOpen { get; private set; }

        public void OpenCarDoors()
        {
            if (IsCarOpen)
                return;
            OpenDoors();
            IsCarOpen = true;
            System.Console.WriteLine("Central car lock opened.");
        }
        public void CloseCarDoors()
        {
            if (!IsCarOpen)
                return;
            CloseDoors();
            IsCarOpen = false;
            System.Console.WriteLine("Central car lock closed.");
        }
        // Open car doors method
        private void OpenDoors() { }
        // Close car doors method
        private void CloseDoors() { }
    }
}
