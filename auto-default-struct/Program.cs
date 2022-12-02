var pet = new Pet();
System.Console.WriteLine(pet.Id);
System.Console.WriteLine(pet.Name);

public struct Pet
{
    public Guid Id;
    public string? Name;

    public Pet()
    {
        Id = Guid.NewGuid();
    }
}