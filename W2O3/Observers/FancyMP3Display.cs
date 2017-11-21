using System;

namespace W2O3
{
    public class FancyMP3Display : IObserver
    {

        private MP3Player player;

        public FancyMP3Display(MP3Player player)
        {
            player.AddObserver(this);
            this.player = player;
        }

        public void Update()
        {
            Console.WriteLine(
                "Fancy display: '{0}' van {1} ({2:mm\\:ss})",
                player.HuidigNummer.Naam,
                player.HuidigNummer.Artiest,
                player.HuidigNummer.Duur
                );
        }
    }
}