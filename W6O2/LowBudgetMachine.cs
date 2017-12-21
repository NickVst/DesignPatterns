namespace W6O1
{
    internal class LowBudgetMachine : IMachineFactory
    {
        public IHardDisk CreateHardDisk()
        {
            return new LowBudgetHardDisk();
        }

        public IMonitor CreateMonitor()
        {
            return new LowBudgetMonitor();
        }

        public IProcessor CreateProcessor()
        {
            return new LowBudgetProcessor();
        }
    }
}