namespace DesignPatterns.Classes.BehavioralPatterns.Visitor
{
    public interface IAccount
    {
        public string Name { get; set; }
        void AcceptVisitor(IVisitor visitor);
    }
}
