var pet = Pet.Create();
System.Console.WriteLine((Guid)pet);

public interface ICreatable<T> where T : ICreatable<T>
{
    Guid Id { get; }
    static abstract T Create();

    static abstract implicit operator Guid(T t);
}

public class Pet : ICreatable<Pet>
{
    private Pet() { }

    public Guid Id => Guid.NewGuid();

    public static Pet Create()
    {
        return new Pet();
    }

    public static implicit operator Guid(Pet t)
    {
        return t.Id;
    }
}