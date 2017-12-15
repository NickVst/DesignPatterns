using System;

namespace W5O1
{
    public class Logger
    {
        private static Logger uniqueInstance;

        private int numberOfLines;

        private Logger() { }

        public static Logger GetLogger()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Logger();
            }

            return uniqueInstance;
        }

        public void Log(string providerName, string message)
        {
            numberOfLines++;
            Console.WriteLine("{0} - [{1}] {2}", numberOfLines, providerName, message);
        }
    }
}