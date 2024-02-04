//El patrón Observer define una relación de uno a muchos entre objetos, 
//de modo que cuando un objeto cambia de estado, todos sus dependientes son notificados y actualizados automáticamente.

public interface IObserver
{
    void Update();
}

public class ConcreteObserver : IObserver
{
    public void Update()
    {
        Console.WriteLine("ConcreteObserver is updated");
    }
}

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

public class ConcreteSubject : ISubject
{
    private List<IObserver> observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update();
        }
    }
}
