using System;

namespace W2O1.DataLoaders
{
    public class CallDataLoader : BigDataLoader
    {
        public void Extract()
        {
            Console.WriteLine("Extracting call data");
        }

        public void Transform()
        {
            Console.WriteLine("Transforming call data");
        }

        public void Load()
        {
            Console.WriteLine("Loading call data");
        }
    }
}