namespace DesignPatterns.Classes.BehavioralPatterns.ChainOfResponsibility
{
    class KugooElectricScuterRent : IElectricScuterRental
    {
        public IElectricScuterRental NextChain { get; set; }

        public void RentElectricScuter(ScuterType scuterType)
        {
            if (scuterType.Equals(ScuterType.Kugoo))
            {
                System.Console.WriteLine("Выдача в прокат электросамоката Kugoo.");
                return;
            }
            if (NextChain == null)
                return;
            NextChain.RentElectricScuter(scuterType);
        }
    }
}
