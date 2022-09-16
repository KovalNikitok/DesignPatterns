namespace DesignPatterns.Classes.BehavioralPatterns.Iterator
{
    interface IPersonNumerable
    {
        IPersonIterator GetIterator();
        int Count { get; }
        Person this[int index] { get; }
    }
}
