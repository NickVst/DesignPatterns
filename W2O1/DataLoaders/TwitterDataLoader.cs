using System;

namespace W2O1.DataLoaders
{
    public class TwitterDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("Extracting twitter data");
        }

        public override void Transform()
        {
            Console.WriteLine("Transforming twitter data");
        }

        public override void Load()
        {
            Console.WriteLine("Loading twitter data");
        }
    }
}