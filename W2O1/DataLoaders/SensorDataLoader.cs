using System;

namespace W2O1.DataLoaders
{
    public class SensorDataLoader : BigDataLoader
    {
        public void Extract()
        {
            Console.WriteLine("Extracting sensor data");
        }

        public void Transform()
        {
            Console.WriteLine("Transforming sensor data");
        }

        public void Load()
        {
            Console.WriteLine("Loading sensor data");
        }
    }
}