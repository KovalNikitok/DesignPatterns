namespace DesignPatterns.Classes.BehavioralPatterns.Visitor
{
    public class PhysicalEntity : IAccount
    {
        public string Name { get; set; }
        
        public string StateRegistrationNumber { get; set; }
        public PhysicalEntity(string name, string stateRegistrationNumber)
        {
            Name = name;
            StateRegistrationNumber = stateRegistrationNumber;
        }

        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.VisitPhysicalEntity(this);
        }
    }
}