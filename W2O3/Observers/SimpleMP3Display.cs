using System;

namespace W2O3
{
    public class SimpleMP3Display : IObserver
    {

        private MP3Player player;

        public SimpleMP3Display(MP3Player player)
        {
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