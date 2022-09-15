using System.Collections.Generic;

namespace DesignPatterns.Classes.BehavioralPatterns.Observer
{
    interface IObservable
    {
        List<IObserver> Observers { get; }
        void NotifyObservers();
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
    }
}
