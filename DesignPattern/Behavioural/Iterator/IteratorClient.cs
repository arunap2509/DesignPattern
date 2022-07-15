namespace DesignPattern.Behavioural.Iterator;

public class IteratorClient
{
    public static void Invoke()
    {
        var collection = new ListCollection<string>();

        collection.Add("keyboard");
        collection.Add("mouse");
        collection.Add("phone");
        collection.Add("laptop");

        var iterator = collection.GetIterator();

        while (iterator.HasMore())
        {
            Console.WriteLine(iterator.Current());

            iterator.Next();
        }
    }
}

