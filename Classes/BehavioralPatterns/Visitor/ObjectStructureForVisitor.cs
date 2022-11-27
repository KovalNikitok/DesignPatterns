using System.Collections.Generic;

namespace DesignPatterns.Classes.BehavioralPatterns.Visitor
{
    public class ObjectStructureForVisitor
    {
        private IList<IAccount> _collection = new List<IAccount>();
        public void Add(IAccount account) => _collection.Add(account);
        public void Remove(IAccount account) => _collection.Remove(account);
        public void AcceptVisitor(IVisitor visitor)
        {
            foreach (var item in _collection)
            {
                item.AcceptVisitor(visitor);
            }
        }
    }
}
