using System;

namespace W2O3
{
    public class SimpleMP3Display : IObserver
    {

        private ISubject player;

        public SimpleMP3Display(ISubject player)
        {
            player.AddObserver(this);
            this.player = player;
        }

        public void Update()
        {
            Console.WriteLine(
                "Simple display: {0} - '{1}'",
                player.HuidigNummer.Artiest,
                player.HuidigNummer.Naam
                );
        }
    }
}