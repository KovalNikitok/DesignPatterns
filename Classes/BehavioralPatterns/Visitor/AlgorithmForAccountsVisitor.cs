using System;

namespace DesignPatterns.Classes.BehavioralPatterns.Visitor
{
    public class AlgorithmForAccountsVisitor : IVisitor
    {
        public void VisitLegalEntity(LegalEntity legalEntity)
        {
            Console.WriteLine($"Do some algorithm with legal entity with INN: {legalEntity.INN}");
        }

        public void VisitPhysicalEntity(PhysicalEntity physicalEntity)
        {
            Console.WriteLine($"Do some algorithm with physical entity with state reg. number: {physicalEntity.StateRegistrationNumber}");
        }
    }
}
