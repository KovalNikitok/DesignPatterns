namespace DesignPatterns.Classes.BehavioralPatterns.Command
{
    class ElectricalGarageDoor
    {
        public ElectricalGarageDoor(bool isOpen)
        {
            IsOpen = isOpen;
        }
        public bool IsOpen { get; private set; }

        public void OpenGarageDoor()
        {
            if (IsOpen)
                return;
            OpenDoor();
            IsOpen = true;
            System.Console.WriteLine("Garage door opens.");
        }
        public void CloseGarageDoor()
        {
            if (!IsOpen)
                return;
            CloseDoor();
            IsOpen = false;
            System.Console.WriteLine("Garage door closes.");
        }
        // Open garage door method
        private void OpenDoor() { }
        // Close garage door method
        private void CloseDoor() { }
    }
}
