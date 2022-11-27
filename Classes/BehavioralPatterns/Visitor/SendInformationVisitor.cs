using System;

namespace DesignPatterns.Classes.BehavioralPatterns.Visitor
{
    public class SendInformationVisitor : IVisitor
    {
        public void VisitLegalEntity(LegalEntity legalEntity)
        {
            Console.WriteLine($"It is legal entity's info: {legalEntity.Name} with INN - {legalEntity.INN} and phone number - {legalEntity.Telephone}");
        }

        public void VisitPhysicalEntity(PhysicalEntity physicalEntity)
        {
            Console.WriteLine($"It is physical entity's info: {physicalEntity.Name} with state reg. number - {physicalEntity.StateRegistrationNumber}");
        }
    }
}
