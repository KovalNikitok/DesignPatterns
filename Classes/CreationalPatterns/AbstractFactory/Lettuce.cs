using System;

namespace DesignPatterns.Classes.AbstractFactory
{
    class Lettuce : Filling
    {
        public override void FllingType()
        {
            Console.WriteLine("Filling is lettuce.");
        }
    }
}
