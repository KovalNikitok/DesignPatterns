using DesignPatterns.Interfaces;
using DesignPatterns.Classes;
using System;
using System.Collections.Generic;
using DesignPatterns.Classes.AbstractFactory;
using DesignPatterns.Classes.Singleton;

namespace DesignPatterns
{
    class Program
    {
        static void Main()
        {
            #region Creational patterns
            #region Factory method pattern
            IProductFactory factoryBanana = new BananaFactory();
            IProductFactory factoryPotato = new PotatoFactory();

            List<IProduct> products = new List<IProduct>
            {
                factoryBanana.CreateProduct("Banana-Mama", 1.25f, 25m),
                factoryPotato.CreateProduct("Potato-Big-Taste", 5.0f, 20m),
                factoryBanana.CreateProduct("Banana-Papa", 1.5f, 30m),
                factoryPotato.CreateProduct("Potato-Small-Chernishevo", 10.0f, 35m),
                factoryPotato.CreateProduct("Potato-Zabugrovka", 8.0f, 20m)
            };

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name} gives {item.CalculateCallories()} callories");
            }
            #endregion
            Console.WriteLine();
            #region Abstract factory pattern

            Sandwich baconSandwich = new Sandwich(new BaconSandwichFactory());
            Sandwich bunSandwich = new Sandwich(new BunLettuceFactory());
            baconSandwich.SandwichWith();
            bunSandwich.SandwichWith();

            #endregion
            Console.WriteLine();
            #region Singleton
            Computer comp = Computer.Current("My Computer");
            Console.WriteLine(comp.Name);
            Computer comp2 = Computer.Current("My Second Computer");
            Console.WriteLine(comp2.Name);

            #endregion
            Console.WriteLine();
            #region Prototype



            #endregion
            Console.WriteLine();
            #endregion
        }
    }
}
