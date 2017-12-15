namespace W5O1
{
    public class MainSystem
    {

        private Logger logger;
        private SubSystem subSystem;

        public MainSystem()
        {
            logger = Logger.GetLogger();
            subSystem = new SubSystem();
        }

        public void DoSomeMainWork()
        {
            logger.Log("MainSystem", "doing some main work");
            subSystem.DoSomeWork();
            subSystem.DoSomeMoreWork();
        }
    }
}