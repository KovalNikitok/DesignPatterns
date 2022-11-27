namespace DesignPatterns.Classes.BehavioralPatterns.Visitor
{
    public interface IVisitor
    {
        void VisitLegalEntity(LegalEntity legalEntity);
        void VisitPhysicalEntity(PhysicalEntity physicalEntity);
    }
}