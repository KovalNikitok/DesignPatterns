using System;

namespace DesignPatterns.Classes.BehavioralPatterns.Strategy
{
    class Ballet : IDance
    {
        public void Dance()
        {
            Console.WriteLine("Dancing the ballet!");
        }
    }
}
