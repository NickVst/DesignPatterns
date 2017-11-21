using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W2O1.DataLoaders;

namespace W2O1
{
    class Program
    {
        static void Main(string[] args)
        {
            BatchProcessor processor = new BatchProcessor();

            processor.AddLoader(new CallDataLoader());
            processor.AddLoader(new TwitterDataLoader());
            processor.AddLoader(new SensorDataLoader());

            processor.ProcessLoaders();
            Console.ReadLine();
        }
    }
}
