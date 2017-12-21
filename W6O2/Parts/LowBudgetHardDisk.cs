namespace W6O1
{
    internal class LowBudgetHardDisk : IHardDisk
    {
        public void storeData()
        {
            System.Console.WriteLine("Storing data not so quickly...");
        }
    }
}