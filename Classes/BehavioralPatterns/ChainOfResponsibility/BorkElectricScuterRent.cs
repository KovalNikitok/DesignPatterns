namespace DesignPatterns.Classes.BehavioralPatterns.ChainOfResponsibility
{
    class BorkElectricScuterRent : IElectricScuterRental
    {
        public IElectricScuterRental NextChain { get; set; }

        public void RentElectricScuter(ScuterType scuterType)
        {
            if (scuterType.Equals(ScuterType.Bork))
            {
                System.Console.WriteLine("Выдача в прокат электросамоката Bork.");
                return;
            }
            if (NextChain == null)
                return;
            NextChain.RentElectricScuter(scuterType);
        }
    }
}
