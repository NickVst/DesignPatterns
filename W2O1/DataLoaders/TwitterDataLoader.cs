using System;

namespace W2O1.DataLoaders
{
    public class TwitterDataLoader : BigDataLoader
    {
        public void Extract()
        {
            Console.WriteLine("Extracting twitter data");
        }

        public void Transform()
        {
            Console.WriteLine("Transforming twitter data");
        }

        public void Load()
        {
            Console.WriteLine("Loading twitter data");
        }
    }
}