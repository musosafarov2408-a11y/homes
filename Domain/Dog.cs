using System.Security.Cryptography;

namespace Domain;

public class Dog
{
    private string name;
    private string breed;
    private int age;
    public Dog (string name,string breed,int age)
    {
        this.name = name;
        this.breed = breed;
        this.age = age;
    }
    public void Info()
    {
        Console.WriteLine($"Name: {name}, Breed: {breed}, Age: {age}");
    }
}
