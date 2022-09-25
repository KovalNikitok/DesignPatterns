namespace DesignPatterns.Classes.BehavioralPatterns.Mediator
{
    class CommodityExpertColleague : IColleague
    {
        public IMediator Mediator { get; set; }
        public CommodityExpertColleague(IMediator mediator)
        {
            Mediator = mediator;
        }
        public void Notify(string message)
        {
            System.Console.WriteLine($"Message to commodity expert: {message}");
        }
        public void Send(string message)
        {
            Mediator.Send(message, this);
        }
    }
}
