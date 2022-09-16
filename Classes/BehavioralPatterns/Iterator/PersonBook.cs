namespace DesignPatterns.Classes.BehavioralPatterns.Iterator
{
    class PersonBook : IPersonNumerable
    {
        private Person[] _persons;
        public PersonBook(int countOfPersons)
        {
            _persons = new Person[countOfPersons];
        }

        public PersonBook(Person[] persons)
        {
            _persons = persons;
        }

        public Person this[int index]
        {
            get => _persons[index];
            set => _persons[index] = value;
        }

        public int Count => _persons?.Length ?? 0;

        public IPersonIterator GetIterator()
        {
            return new PersonBookIterator(this);
        }
    }
}
