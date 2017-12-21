using System;

namespace W6O1
{
    internal class ComputerShop
    {
        private IMachineFactory factory;

        private IProcessor processor;
        private IHardDisk hardDisk;
        private IMonitor monitor;

        public ComputerShop(IMachineFactory factory)
        {
            this.factory = factory;
        }

        internal void AssembleMachine()
        {
            processor = factory.CreateProcessor();
            hardDisk = factory.CreateHardDisk();
            monitor = factory.CreateMonitor();

            processor.PerformOperation();
            hardDisk.storeData();
            monitor.Display();
        }
        
    }
}