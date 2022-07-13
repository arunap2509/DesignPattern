namespace DesignPattern.Creational.Builder;

public abstract class House
{
    protected Dictionary<string, int> _houseParts;
    private readonly string _houseType;

    public House(string houseType)
    {
        _houseType = houseType;
        _houseParts = new();
    }

    public void ListParts()
    {
        var house = $"This {_houseType} have: \n";

        foreach (var part in _houseParts)
        {
            house += $"{part.Key} {part.Value}";
            house += "\n";
        }

        Console.WriteLine(house);
    }
}