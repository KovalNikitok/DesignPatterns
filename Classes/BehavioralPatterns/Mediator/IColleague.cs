namespace DesignPatterns.Classes.BehavioralPatterns.Mediator
{
    interface IColleague
    {
        IMediator Mediator { get; set; }
        void Send(string message);
        void Notify(string message);
    }
}
