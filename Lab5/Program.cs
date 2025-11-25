namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        string[] seasons = ["Spring", "Summer", "Fall", "Winter"]; 

        foreach (string season in seasons)
        {
            Console.WriteLine($"Season: {season}");
        }

        Console.WriteLine();

        string[] weekdays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" ];

        Console.Write("Enter a number 1-7: ");
        int weekday = Convert.ToInt32(Console.ReadLine());

        if (weekday >= 1 && weekday <= 7)
        {
            Console.WriteLine("That day = " + weekdays[weekday - 1]);
        }
        else
        {
            Console.WriteLine("Invalid. Please use a number correlating with the days of the week.");
        }

        Console.WriteLine();

        string[] books = ["The Hobbit", "Charlotte's Web", "1984" ];
        string[] authors = ["J.R.R. Tolkien", "E.B. White", "George Orwell"];
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(books[i] + " by " + authors[i]);
        }

        Console.WriteLine();

        int[] temperatures = { 65, 72, 78, 70, 68 };

        Array.Sort(temperatures);

        Console.Write("Sorted Temperatures: ");

        foreach (int temp in temperatures)
        {
            Console.Write(temp + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Highest Temperature: " + temperatures[temperatures.Length - 1]);
        Console.WriteLine("Lowest Temperature: " + temperatures[0]);
        
        Console.WriteLine();

        int[] reverseCount = [5, 4, 3, 2, 1];
         
        Array.Reverse(reverseCount);

        Console.Write("Countdown: ");

        for (int i = 0; i < reverseCount.Length; i++)
        {
            Console.Write(reverseCount[i] +  " ");
        }  
    }
}
