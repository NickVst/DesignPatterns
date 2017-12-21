namespace W6O1
{
    internal interface IMachineFactory
    {
        IProcessor CreateProcessor();
        IHardDisk CreateHardDisk();
        IMonitor CreateMonitor();
    }
}