using System;

namespace W6O1
{
    internal abstract class ComputerShop
    {
        private IProcessor processor;
        private IHardDisk hardDisk;
        private IMonitor monitor;

        internal void AssembleMachine()
        {
            processor = CreateProcessor();
            hardDisk = CreateHardDisk();
            monitor = CreateMonitor();

            processor.PerformOperation();
            hardDisk.storeData();
            monitor.Display();
        }

        internal abstract IProcessor CreateProcessor();
        internal abstract IHardDisk CreateHardDisk();
        internal abstract IMonitor CreateMonitor();
        
    }
}