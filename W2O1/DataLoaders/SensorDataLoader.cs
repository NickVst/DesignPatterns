using System;

namespace W2O1.DataLoaders
{
    public class SensorDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("Extracting sensor data");
        }

        public override void Transform()
        {
            Console.WriteLine("Transforming sensor data");
        }

        public override void Load()
        {
            Console.WriteLine("Loading sensor data");
        }
    }
}