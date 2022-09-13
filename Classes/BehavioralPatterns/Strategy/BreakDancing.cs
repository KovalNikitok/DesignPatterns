using System;

namespace DesignPatterns.Classes.BehavioralPatterns.Strategy
{
    class BreakDancing : IDance
    {
        public void Dance()
        {
            Console.WriteLine("It's break dancing!");
        }
    }
}
