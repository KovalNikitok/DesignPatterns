namespace DesignPatterns.Classes.BehavioralPatterns.Mediator
{
    class ManagerMediator : IMediator
    {
        public IColleague ManagerColleague { get; set; }
        public IColleague CommodityExpertColleague { get; set; }
        public IColleague CashierColleague { get; set; }

        public void Send(string message, IColleague colleague)
        {
            if (colleague == ManagerColleague)
                CommodityExpertColleague.Notify(message);
            else if (colleague == CommodityExpertColleague)
                CashierColleague.Notify(message);
            else if (colleague == CashierColleague)
                ManagerColleague.Notify(message);
        }
    }
}
