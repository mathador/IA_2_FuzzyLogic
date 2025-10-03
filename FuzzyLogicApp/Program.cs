using System;

namespace FuzzyLogicApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an application to run:");
        Console.WriteLine("1. Zoom GPS");
        Console.WriteLine("2. Store");
        Console.WriteLine("3. Test Fuzzy Sets");
        Console.Write("Enter the number of your choice: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                ZoomGps.Main(args);
                break;
            case "2":
                Store.Main(args);
                break;
            case "3":
                Test.Main(args);
                break;
            default:
                Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                break;
        }
    }
}
