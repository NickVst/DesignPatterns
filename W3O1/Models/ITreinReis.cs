namespace W3O1
{
    internal interface ITreinReis
    {
        void AddObserver(ITreinDisplay treinDisplay);
        void RemoveObserver(ITreinDisplay treinDisplay);
        void VolgendStation();
        void Reverse();
    }
}