using System;

namespace DesignPatterns.Classes.AbstractFactory
{
    class BreadSlice : Bread
    {
        public override void BreadType()
        {
            Console.WriteLine("Use slice of bread.");
        }
    }
}
