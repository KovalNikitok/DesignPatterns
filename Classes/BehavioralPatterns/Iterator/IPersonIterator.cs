namespace DesignPatterns.Classes.BehavioralPatterns.Iterator
{
    interface IPersonIterator
    {
        bool HasNext();
        Person Next();
    }
}
