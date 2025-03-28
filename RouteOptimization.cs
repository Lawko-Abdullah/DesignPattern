using System;
using System.Linq;

public class RouteOptimization
{
    
    public static string FindShortestRoute(int[][] distances)
    {
        int shortestDistance = int.MaxValue;
        string shortestRoute = "";

        // Går igenom alla möjliga vägar 
        for (int i = 0; i < distances.Length; i++)
        {
            for (int j = i + 1; j < distances[i].Length; j++)
            {
                if (distances[i][j] < shortestDistance)
                {
                    shortestDistance = distances[i][j];
                    shortestRoute = $"Från punkt {i} till punkt {j}";
                }
            }
        }

        return shortestRoute;
    }
}

public class Program
{
    public static void Main()
    {
        // Exempel på avstånd mellan punkter (t.ex. klienter)
        int[][] distances = {
            new int[] { 0, 3, 1, 5 },
            new int[] { 3, 0, 4, 2 },
            new int[] { 1, 4, 0, 3 },
            new int[] { 5, 2, 3, 0 }
        };

        // Använd algoritmen för att hitta kortaste vägen
        string route = RouteOptimization.FindShortestRoute(distances);
        Console.WriteLine("Kortaste vägen: " + route);
    }
}
