namespace W6O1
{
    internal class HighBudgetHardDisk : IHardDisk
    {
        public void storeData()
        {
            System.Console.WriteLine("Storing data very quickly...");
        }
    }
}