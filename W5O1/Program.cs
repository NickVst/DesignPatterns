using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5O1
{
    class Program
    {
        private static Logger logger;
        private static MainSystem mainSystem;

        static void Main(string[] args)
        {
            logger = Logger.GetLogger();
            mainSystem = new MainSystem();

            logger.Log("main", "starting");
            mainSystem.DoSomeMainWork();
            logger.Log("main", "finishing");

            Console.ReadKey();
        }
    }
}
