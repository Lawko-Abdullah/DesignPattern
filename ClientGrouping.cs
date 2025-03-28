using System;
using System.Linq;

public class ClientGrouping
{
    public static void GroupClients(int[] distances)
    {
        var sortedDistances = distances.OrderBy(d => d).ToArray(); // Sortera avstånd

        Console.WriteLine("Grupper:");
        Console.WriteLine("Gruppering 1: ");
        foreach (var d in sortedDistances.Take(sortedDistances.Length / 2))
        {
            Console.WriteLine(d);
        }

        Console.WriteLine("Gruppering 2: ");
        foreach (var d in sortedDistances.Skip(sortedDistances.Length / 2))
        {
            Console.WriteLine(d);
        }
    }
}

public class Program
{
    public static void Main()
    {
        int[] distances = { 10, 5, 2, 8, 7, 1 };

        // Använd algoritmen för att gruppera klienter
        ClientGrouping.GroupClients(distances);
    }
}
