namespace W6O1
{
    internal class HighBudgetMachine : IMachineFactory
    {
        public IHardDisk CreateHardDisk()
        {
            return new HighBudgetHardDisk();
        }

        public IMonitor CreateMonitor()
        {
            return new HighBudgetMonitor();
        }

        public IProcessor CreateProcessor()
        {
            return new HighBudgetProcessor();
        }
    }
}