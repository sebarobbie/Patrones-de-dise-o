public interface IProduct
{
    void Operation();
}

public class ConcreteProduct : IProduct
{
    public void Operation()
    {
        Console.WriteLine("ConcreteProduct operation");
    }
}

public abstract class Creator
{
    public abstract IProduct FactoryMethod();
}

public class ConcreteCreator : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct();
    }
}
