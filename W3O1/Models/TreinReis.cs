using System;
using System.Collections.Generic;

namespace W3O1.Models
{
    public class TreinReis : ITreinReis
    {
        private List<Station> stations;
        private List<IObserver> observers;
        private int huidigStation;

        public TreinReis()
        {

            stations = new List<Station>
            {
                new Station("Amsterdam Centraal", "1a", new DateTime(1,1,1, 14, 26, 1), new DateTime(1,1,1, 14, 26, 1)),
                new Station("Amsterdam Sloterdijk", "1b", new DateTime(1,1,1, 14, 31, 1), new DateTime(1,1,1, 14, 31, 1)),
                new Station("Halfweg Zwanenburg", "2c", new DateTime(1,1,1, 14, 36, 1), new DateTime(1,1,1, 14, 36, 1)),
                new Station("Haarlem Spaarnwoude", "3a", new DateTime(1,1,1, 14, 41, 1), new DateTime(1,1,1, 14, 41, 1)),
                new Station("Haarlem Centraal", "1c", new DateTime(1,1,1, 14, 44, 1), new DateTime(1,1,1, 14, 45, 1)),
                new Station("Overveen", "1b", new DateTime(1,1,1, 14, 48, 1), new DateTime(1,1,1, 14, 48, 1)),
                new Station("Zandvoort aan Zee", "2", new DateTime(1,1,1, 14, 55, 1), new DateTime(1,1,1, 14, 55, 1)),

            };
            observers = new List<IObserver>();
            this.huidigStation = 0;
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            observers.ForEach(o => o.Update());
        }

        public void VolgendStation()
        {
            huidigStation++;
            Notify();
        }

        public void KeerOm()
        {
            stations.Reverse();
            huidigStation = 0;
            Notify();
        }
    }
}