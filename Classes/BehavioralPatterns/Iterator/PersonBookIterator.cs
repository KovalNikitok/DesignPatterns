namespace DesignPatterns.Classes.BehavioralPatterns.Iterator
{
    class PersonBookIterator : IPersonIterator
    {
        IPersonNumerable _personNumerable;
        int index = 0;
        public PersonBookIterator(IPersonNumerable personNumerable)
        {
            _personNumerable = personNumerable;
        }
        public bool HasNext()
        {
            if (index < (_personNumerable?.Count ?? 0))
                return true;

            return false;
        }
        public Person Next() => _personNumerable[index++];
    }
}
