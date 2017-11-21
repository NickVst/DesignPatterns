using System;

namespace W2O1.DataLoaders
{
    public class CallDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("Extracting call data");
        }

        public override void Transform()
        {
            Console.WriteLine("Transforming call data");
        }

        public override void Load()
        {
            Console.WriteLine("Loading call data");
        }
    }
}