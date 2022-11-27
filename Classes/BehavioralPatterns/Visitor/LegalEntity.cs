namespace DesignPatterns.Classes.BehavioralPatterns.Visitor
{
    public class LegalEntity : IAccount
    {
        public string Name { get; set; }
        public string INN { get; set; }
        public string Telephone { get; set; }
        public LegalEntity(string name, string inn)
        {
            Name = name;
            INN = inn;
        }
        public LegalEntity(string name, string inn, string telephone) : this(name, inn) => Telephone = telephone;

        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.VisitLegalEntity(this);
        }
    }
}