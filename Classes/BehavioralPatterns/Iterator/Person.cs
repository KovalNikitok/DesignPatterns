namespace DesignPatterns.Classes.BehavioralPatterns.Iterator
{
    class Person
    {
        public Person() { }
        public Person(string firstName, string lastName, int? age) 
        {
            FirstName = firstName;
            LastName = lastName;
            if (age != null)
                Age = age.Value;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
