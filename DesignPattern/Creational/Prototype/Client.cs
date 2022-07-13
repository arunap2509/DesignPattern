namespace DesignPattern.Creational.Prototype;

public class PrototypeClient
{
    public static void Invoke()
    {
        var person = new Person
        {
            FirstName = "John",
            LastName = "Doe",
            Positions = new List<string> { "Dev", "Manager", "PM", "QA" }
        };

        var clonedPerson = person.Clone();
        var anotherClonedPerson = person.Clone();
        anotherClonedPerson.FirstName = "Adam";

        clonedPerson.Positions.Add("PO");
        anotherClonedPerson.Positions.Remove("QA");

        Console.WriteLine(string.Join(',', person.Positions));
        Console.WriteLine(string.Join(',', clonedPerson.Positions));
        Console.WriteLine(string.Join(',', anotherClonedPerson.Positions));

        Console.WriteLine(person.FirstName);
        Console.WriteLine(anotherClonedPerson.FirstName);
    }
}