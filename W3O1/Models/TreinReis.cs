using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace W3O1
{
    internal class TreinReis : ITreinReis
    {
        private List<ITreinDisplay> observers;
        private List<Station> stations;
        private int huidigStation = 0;

        bool reverse = false;

        public TreinReis()
        {
            observers = new List<ITreinDisplay>();
            // stations = new List<Station>();
            stations = new List<Station>()
            {
                new Station("Amsterdam Centraal", "1A", DateTime.Now, DateTime.Now.AddMinutes(1)),
                new Station("Amsterdam Sloterdijk", "2A", DateTime.Now.AddMinutes(4), DateTime.Now.AddMinutes(5)),
                new Station("Halfweg Zwanenburg", "1B", DateTime.Now.AddMinutes(8), DateTime.Now.AddMinutes(9)),
                new Station("Haarlem Spaarnwoude", "2B", DateTime.Now.AddMinutes(12), DateTime.Now.AddMinutes(13)),
                new Station("Haarlem Centraal", "1C", DateTime.Now.AddMinutes(17), DateTime.Now.AddMinutes(18)),
                new Station("Overveen", "2C", DateTime.Now.AddMinutes(23), DateTime.Now.AddMinutes(24)),
                new Station("Zandvoort Aan Zee", "3C", DateTime.Now.AddMinutes(31), DateTime.Now.AddMinutes(32)),
            };
        }

        public void AddObserver(ITreinDisplay treinDisplay)
        {
            observers.Add(treinDisplay);
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            Station station;
            try
            {
                if (reverse)
                    station = stations[huidigStation - 1];
                else
                    station = stations[huidigStation + 1];
            } catch (ArgumentOutOfRangeException)
            {
                station = new Station("Geen volgend station", "Geen volgend spoor", DateTime.MinValue, DateTime.MaxValue);
            }
            foreach (ITreinDisplay observer in observers)
            {
                observer.Update(station);
            }
        }
        

        public void RemoveObserver(ITreinDisplay treinDisplay)
        {
            observers.Remove(treinDisplay);
        }

        public void VolgendStation()
        {
            if(reverse)
            {
                huidigStation--;
            } else 
            {
                huidigStation++;
            }

            NotifyObservers();
        }

        public void Reverse()
        {
            reverse = !reverse;
            NotifyObservers();
        }
    }
}