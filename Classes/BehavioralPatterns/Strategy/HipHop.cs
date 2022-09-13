using System;

namespace DesignPatterns.Classes.BehavioralPatterns.Strategy
{
    class HipHop : IDance
    {
        public void Dance()
        {
            Console.WriteLine("Dancing the hip hop!");
        }
    }
}
