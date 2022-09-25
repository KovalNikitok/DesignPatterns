namespace DesignPatterns.Classes.BehavioralPatterns.Mediator
{
    interface IMediator
    {
        void Send(string message, IColleague colleague);
    }
}
