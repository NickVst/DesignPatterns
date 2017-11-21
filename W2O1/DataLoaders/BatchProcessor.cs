using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2O1.DataLoaders
{
    class BatchProcessor
    {
        private ICollection<BigDataLoader> loaders;

        public BatchProcessor()
        {
            loaders = new List<BigDataLoader>();
        }

        public void AddLoader(BigDataLoader loader)
        {
            loaders.Add(loader);
        }

        public void ProcessLoaders()
        {
            foreach (BigDataLoader loader in loaders)
            {
                loader.ETL();
                Console.WriteLine();
            }
        }
    }
}
