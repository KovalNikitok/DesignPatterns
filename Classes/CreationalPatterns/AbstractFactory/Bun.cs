using System;

namespace DesignPatterns.Classes.AbstractFactory
{
    class Bun : Bread
    {
        public override void BreadType()
        {
            Console.WriteLine("Use ban.");
        }
    }
}
