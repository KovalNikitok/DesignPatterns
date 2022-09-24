namespace DesignPatterns.Classes.BehavioralPatterns.ChainOfResponsibility
{
    interface IElectricScuterRental
    {
        IElectricScuterRental NextChain { get; set; }
        void RentElectricScuter(ScuterType scuterType);
    }
}
