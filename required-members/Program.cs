using System.Diagnostics.CodeAnalysis;

var pet = new Pet("Gianni", "Beagle");

System.Console.WriteLine(pet);

//pet.Name = "Snoopy";
//System.Console.WriteLine(pet);

public class Pet
{
    public required string Name { get; init; }
    public required string Breed { get; set; }

    [SetsRequiredMembers]
    public Pet(string name, string breed)
    {
        Name = name;
        Breed = breed;
    }

    public override string ToString()
    {
        return $"{Name} {Breed}";
    }
}