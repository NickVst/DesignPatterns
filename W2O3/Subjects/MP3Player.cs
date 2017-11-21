using System;
using System.Collections.Generic;
using System.Linq;

namespace W2O3
{
    public class MP3Player : ISubject
    {

        public Nummer HuidigNummer { get; set; }

        private List<Nummer> nummers;
        private List<IObserver> observers;
        private Random random;

        public MP3Player()
        {
            nummers = new List<Nummer>
            {
                new Nummer("Wish You Were Here", "Pink Floyd", new TimeSpan(0, 3, 12)),
                new Nummer("Billionaire", "Bruno Mars", new TimeSpan(0, 3, 33)),
                new Nummer("Dazed and Confused", "Led Zeppelin", new TimeSpan(0, 4, 8)),
            };
            observers = new List<IObserver>();
            random = new Random();
        }

        public void NummerGewijzigd()
        {
            HuidigNummer = nummers[random.Next(nummers.Count)];
            NotifyObservers();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            observers.ForEach(o => o.Update());
        }
    }
}