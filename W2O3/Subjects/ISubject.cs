using System;

namespace W2O3
{
    public interface ISubject
    {
        Nummer HuidigNummer { get; set; }

        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}