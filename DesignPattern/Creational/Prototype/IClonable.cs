namespace DesignPattern.Creational.Prototype;

public interface IClonable<T>
{
    T Clone();
}

public class Person : IClonable<Person>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<string> Positions { get; set; }


    public Person() { }

    public Person(Person person)
    {
        FirstName = person.FirstName;
        LastName = person.LastName;
        Positions = new(person.Positions);
    }

    public Person Clone()
    {
        return new Person(this);
    }

    // below two implementation uses framework provided method to clone
    public Person ShallowCopy()
    {
        return (Person) MemberwiseClone();
    }

    public Person DeepCopy()
    {
        var clone = (Person)MemberwiseClone();
        clone.Positions = new List<string>(clone.Positions);

        return clone;
    }
}