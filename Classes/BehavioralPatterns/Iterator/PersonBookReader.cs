using System;

namespace DesignPatterns.Classes.BehavioralPatterns.Iterator
{
    class PersonBookReader
    {
        private IPersonIterator personIterator { get; set; }

        public PersonBookReader(Person[] persons)
        {
            personIterator = new PersonBook(persons).GetIterator();
        }

        public void ReadPersonBook()
        {
            while (personIterator.HasNext())
            {
                Person person = personIterator.Next();
                Console.WriteLine($"{person.FirstName} { person.LastName}");
            }
        }
    }
}
