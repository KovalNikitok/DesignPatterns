namespace DesignPatterns.Classes.BehavioralPatterns.ChainOfResponsibility
{
    class XiaomiElectricScuterRent : IElectricScuterRental
    {
        public IElectricScuterRental NextChain { get; set; }

        public void RentElectricScuter(ScuterType scuterType)
        {
            if(scuterType.Equals(ScuterType.Xiaomi))
            {
                System.Console.WriteLine("Выдача в прокат электросамоката Xiaomi.");
                return;
            }
            if (NextChain == null)
                return;
            NextChain.RentElectricScuter(scuterType);
        }
    }
}
