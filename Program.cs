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
using DesignPatterns.Classes.BehavioralPatterns.Command;

namespace DesignPatterns
{
    class Program
    {
        static void Main()
        {

            #region Creational patterns
            Console.WriteLine("Creational patterns:");
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

            Console.WriteLine();
            #endregion
            #region Abstract factory pattern

            Sandwich baconSandwich = new Sandwich(new BaconSandwichFactory());
            Sandwich bunSandwich = new Sandwich(new BunLettuceFactory());
            baconSandwich.SandwichWith();
            bunSandwich.SandwichWith();

            Console.WriteLine();
            #endregion
            #region Singleton
            Computer comp = Computer.Current("My Computer");
            Console.WriteLine(comp.Name);
            Computer comp2 = Computer.Current("My Second Computer");
            Console.WriteLine(comp2.Name);

            Console.WriteLine();
            #endregion
            #region Prototype
            IPen penPrototype = new RoundedPen(System.Drawing.Color.AliceBlue, true);
            penPrototype.GetColor();
            IPen penPrototype2 = penPrototype.Clone();
            penPrototype2.GetColor();

            Console.WriteLine();
            #endregion
            #region Builder
            BreadBuilder wheatBuilder = new WheatBuilder();
            BreadBuilder ryeBuilder = new RyeBreadBuilder();
            Baker baker = new Baker();

            Console.WriteLine(baker.Bake(wheatBuilder).ToString());
            Console.WriteLine(baker.Bake(ryeBuilder).ToString());
            Console.WriteLine(baker.Bake(wheatBuilder).ToString());

            Console.WriteLine();
            #endregion
            #endregion

            #region Behavioral patterns
            Console.WriteLine("Behavioral patterns:");
            #region Strategy
            Dancer dancer = new Dancer("Nick", new BreakDancing());
            dancer.Dancing();
            dancer.Dance = new Ballet();
            dancer.Dancing();

            Console.WriteLine();
            #endregion
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

            Console.WriteLine();
            #endregion
            #region Command
            CommandManager commandManager = new CommandManager();
            AirConditioner conditioner = new AirConditioner();
            CarCentralLock carCentralLock = new CarCentralLock(true);
            ElectricalGarageDoor electricalGarageDoor = new ElectricalGarageDoor(false);

            commandManager.SetCommand(new AirConditionerLaunchCommand(conditioner));
            commandManager.RunCommand();
            conditioner.ChangeTemperature(5);
            commandManager.RunCommand();
            commandManager.SetCommand(new CarCentralLockCommand(carCentralLock));
            commandManager.RunCommand();
            commandManager.DropCommand();
            commandManager.SetCommand(new ElectricalGarageDoorCommand(electricalGarageDoor));
            commandManager.RunCommand();
            commandManager.DropCommand();
            Console.WriteLine();
            #endregion
            #endregion
        }
    }
}
