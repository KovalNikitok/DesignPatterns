﻿using DesignPatterns.Interfaces;
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
using DesignPatterns.Classes.BehavioralPatterns.TemplateMethod;
using DesignPatterns.Classes.BehavioralPatterns.Iterator;
using DesignPatterns.Classes.BehavioralPatterns.State;
using DesignPatterns.Classes.BehavioralPatterns.ChainOfResponsibility;
using DesignPatterns.Classes.BehavioralPatterns.Interpreter;
using DesignPatterns.Classes.BehavioralPatterns.Mediator;
using DesignPatterns.Classes.BehavioralPatterns.Visitor;

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
            #region Template Method
            School school = new School();
            University university = new University();

            school.Learn();
            Console.WriteLine();
            university.Learn();

            Console.WriteLine();
            #endregion
            #region Iterator
            Person[] persons = new Person[3]
            {
                new Person("Petya", "Ryazanov", 15),
                new Person("Kolya", "Potapov", 25),
                new Person("Alina", "Gruzdeva", 30)
            };

            PersonBookReader personBookReader = new PersonBookReader(persons);
            personBookReader.ReadPersonBook();

            Console.WriteLine();
            #endregion
            #region State
            Nurition nurition = new Nurition();
            nurition.Feed();
            nurition.Feed();
            nurition.Feed();
            nurition.Feed();

            Console.WriteLine();
            #endregion
            #region Chain of Respponsibility
            IElectricScuterRental xiaomiElectricScuterRental = new XiaomiElectricScuterRent();
            IElectricScuterRental kugooElectricScuterRental = new KugooElectricScuterRent();
            IElectricScuterRental borkElectricScuterRental = new BorkElectricScuterRent();

            xiaomiElectricScuterRental.NextChain = kugooElectricScuterRental;
            kugooElectricScuterRental.NextChain = borkElectricScuterRental;
            ScuterType scuter = ScuterType.Kugoo;
            Console.WriteLine($"Попытка получить в прокате электроскутер {scuter}");
            xiaomiElectricScuterRental.RentElectricScuter(scuter);

            scuter = ScuterType.Xiaomi;
            Console.WriteLine($"Попытка получить в прокате электроскутер {scuter}");
            xiaomiElectricScuterRental.RentElectricScuter(scuter);

            Console.WriteLine();
            #endregion
            #region Interpreter
            Context context = new Context();
            context.SetVariable("X", 16);
            context.SetVariable("Y", 12);
            context.SetVariable("Z", 4);
            context.SetVariable("M", 3);

            IAbstractExpression expression =
                new MultiplicationExpression(
                    new SubstractExpression(new NumberExpression("X"), new NumberExpression("Y")),
                    new AddExpression(new NumberExpression("Z"), new NumberExpression("M"))
                );


            int result = expression.Interpret(context);
            Console.WriteLine($"Result of interpreter MZYX+-* is: {result}");

            Console.WriteLine();
            #endregion
            #region Mediator
            ManagerMediator mediator = new ManagerMediator();

            IColleague managerColleague = new ManagerColleague(mediator);
            IColleague commodityColleague = new CommodityExpertColleague(mediator);
            IColleague cashierColleague = new CashierColleague(mediator);

            mediator.ManagerColleague = managerColleague;
            mediator.CommodityExpertColleague = commodityColleague;
            mediator.CashierColleague = cashierColleague;

            managerColleague.Send("Update products at shop!");
            commodityColleague.Send("Sell updated products!");
            cashierColleague.Send("All products were sold!");

            Console.WriteLine();
            #endregion
            #region Visitor
            var objectStructure = new ObjectStructureForVisitor();

            var physicalEntitySomeCompany = new PhysicalEntity("OOO SomeCompany", "1234567890");
            var physicalEntityOtherCompany = new PhysicalEntity("OOO OtherCompany", "0987654321");

            var legalEntityAlexey = new LegalEntity("Alexey Galacticovich", "6543109876", "1 (234) 567 - 89 - 01");

            objectStructure.Add(physicalEntitySomeCompany);
            objectStructure.Add(physicalEntityOtherCompany);
            objectStructure.Add(legalEntityAlexey);


            objectStructure.AcceptVisitor(new SendInformationVisitor());

            objectStructure.Remove(physicalEntityOtherCompany);

            objectStructure.AcceptVisitor(new AlgorithmForAccountsVisitor());

            Console.WriteLine();
            #endregion
            #endregion
        }
    }
}
