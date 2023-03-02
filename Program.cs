namespace LearningLists;
class Program
{
    static void Main(string[] args)
    {
        List<string> candies = new List<string> ();

        candies .Add("Hersheys Kisses");
        candies .Add("Marshmallows");
        candies .Add("Kitkats");
        candies .Add("JollyRancehers");
        candies .Add("Cream Eggs");
        candies .Add("Reese's Cup");
        candies .Add("Mint Aero");
        candies .Add("Crunchies");
        candies .Add("Maltesers");

        candies .Sort();
        Console.WriteLine($"There are {candies.Count} items in the list");

        foreach(string candy in candies)
        {
            Console.WriteLine(candy);
        }

        //candies.RemoveRange(2,2);

         Console.WriteLine($"There are {candies.Count} items in out list");

        foreach(string candy in candies)
        {
            Console.WriteLine(candy);
        }

        Console.WriteLine("Enter a candy by name to find");
        string searchTerm =Console.ReadLine();

        int location = candies.BinarySearch(searchTerm);

        if (location >= 0)
        {
             Console.WriteLine($"{searchTerm} is at index {location}");
        }
        else
        {
            Console.WriteLine ("Candy not found")
        }
        Console.ReadKey(true);
    }
}
