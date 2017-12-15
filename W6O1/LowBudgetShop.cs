namespace W6O1
{
    internal class LowBudgetShop : ComputerShop
    {
        internal override IHardDisk CreateHardDisk()
        {
            return new LowBudgetHardDisk();
        }

        internal override IMonitor CreateMonitor()
        {
            return new LowBudgetMonitor();
        }

        internal override IProcessor CreateProcessor()
        {
            return new LowBudgetProcessor();
        }
    }
}