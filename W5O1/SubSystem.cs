namespace W5O1
{
    public class SubSystem
    {
        private Logger logger;

        public SubSystem()
        {
            logger = Logger.GetLogger();
        }

        public void DoSomeWork()
        {
            logger.Log("SubSystem", "doing some work");
        }

        public void DoSomeMoreWork()
        {
            logger.Log("SubSystem", "doing some more work");
        }
    }
}