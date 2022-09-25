namespace DesignPatterns.Classes.BehavioralPatterns.Mediator
{
    class ManagerColleague : IColleague
    {
        public IMediator Mediator { get; set; }
        public ManagerColleague(IMediator mediator)
        {
            Mediator = mediator;
        }
        public void Notify(string message)
        {
            System.Console.WriteLine($"Message to manager: {message}");
        }
        public void Send(string message)
        {
            Mediator.Send(message, this);
        }
    }
}
