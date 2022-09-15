using DesignPatterns.Interfaces;
using DesignPatterns.Classes;
using System;
using System.Collections.Generic;
using DesignPatterns.Classes.AbstractFactory;
using DesignPatterns.Classes.Singleton;
using DesignPatterns.Classes.Prototype;
using DesignPatterns.Classes.Builder;
using DesignPatterns.Classes.BehavioralPatterns.Strategy;
using DesignPatterns.Classes.BehavioralPatterns.Observer;

namespace DesignPatterns
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Creational patterns:");
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
            IPen penPrototype = new RoundedPen(System.Drawing.Color.AliceBlue, true);
            penPrototype.GetColor();
            IPen penPrototype2 = penPrototype.Clone();
            penPrototype2.GetColor();
            #endregion
            Console.WriteLine();
            #region Builder
            BreadBuilder wheatBuilder = new WheatBuilder();
            BreadBuilder ryeBuilder = new RyeBreadBuilder();
            Baker baker = new Baker();

            Console.WriteLine(baker.Bake(wheatBuilder).ToString());
            Console.WriteLine(baker.Bake(ryeBuilder).ToString());
            Console.WriteLine(baker.Bake(wheatBuilder).ToString());
            #endregion
            Console.WriteLine();
            #endregion
            Console.WriteLine("Behavioral patterns:");
            #region Behavioral patterns
            #region Strategy
            Dancer dancer = new Dancer("Nick", new BreakDancing());
            dancer.Dancing();
            dancer.Dance = new Ballet();
            dancer.Dancing();
            #endregion
            Console.WriteLine();
            #region Observer
            IObservable stock = new Stock();
            IObserver bank = new Bank();
            IObserver broker = new Broker();
            stock.AddObserver(bank);
            stock.AddObserver(broker);

            ((Stock)stock).SetStockPair();
            stock.NotifyObservers();
            Console.WriteLine();

            ((Stock)stock).SetStockPair();
            stock.NotifyObservers();

            #endregion
            Console.WriteLine();
            #endregion
            Console.WriteLine();
            
        }
    }
}
