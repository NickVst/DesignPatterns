namespace W3O1.Models
{
    public interface ITreinReis
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void Notify();

        void VolgendStation();
        void KeerOm();

    }
}