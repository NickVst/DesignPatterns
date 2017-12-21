namespace W6O1
{
    internal class LowBudgetProcessor : IProcessor
    {
        public void PerformOperation()
        {
            System.Console.WriteLine("Performing operation not so quickly...");
        }
    }
}