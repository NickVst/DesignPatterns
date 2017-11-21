namespace W2O1.DataLoaders
{
    public abstract class BigDataLoader
    {
        public void ETL()
        {
            Extract();
            Transform();
            Load();
        }
        public abstract void Extract();
        public abstract void Transform();
        public abstract void Load();
    }
}