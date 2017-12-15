namespace W6O1
{
    internal class HighBudgetShop : ComputerShop
    {
        internal override IHardDisk CreateHardDisk()
        {
            return new HighBudgetHardDisk();
        }

        internal override IMonitor CreateMonitor()
        {
            return new HighBudgetMonitor();
        }

        internal override IProcessor CreateProcessor()
        {
            return new HighBudgetProcessor();
        }
    }
}