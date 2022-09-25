namespace DesignPatterns.Classes.BehavioralPatterns.Mediator
{
    class CashierColleague : IColleague
    {
        public IMediator Mediator { get; set; }
        public CashierColleague(IMediator mediator)
        {
            Mediator = mediator;
        }
        public void Notify(string message)
        {
            System.Console.WriteLine($"Message to cashier: {message}");
        }
        public void Send(string message)
        {
            Mediator.Send(message, this);
        }
    }
}
