using System;

namespace DesignPatterns.Classes.AbstractFactory
{
    class Bacon : Filling
    {
        public override void FllingType()
        {
            Console.WriteLine("Filling is bacon.");
        }
    }
}
