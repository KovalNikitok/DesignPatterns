using System;
using System.Collections.Generic;

namespace DesignPatterns.Classes.BehavioralPatterns.Observer
{
    class Stock : IObservable
    {
        public List<IObserver> Observers { get; private set; }
        private Random _rnd = new Random();
        private Dollar_Ruble_Pair _stockData { get; set; }
        public Stock()
        {
            Observers = new List<IObserver>();
            _stockData = new Dollar_Ruble_Pair();
        }
        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            for(int i = 0; i < Observers.Count; i++)
            {
                Observers[i].Update(_stockData);
            }
        }

        public void SetStockPair()
        {
            _stockData.Dollar = _rnd.Next(60, 90);
            _stockData.Rubble = _rnd.Next(40, 80);
        }
    }
}
