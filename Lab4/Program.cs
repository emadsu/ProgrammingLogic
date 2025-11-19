namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple for loop");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

         Console.WriteLine("Even numbers 1 to 20");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine();

        Console.WriteLine("While loop countdown");
        int count = 5;
        while (count >= 1)
        {
            Console.WriteLine(count);
            count--;
        }
        Console.WriteLine();

        Console.WriteLine("Do while user input");
        int Number;
        do
        {
            Console.Write("Enter a number greater than 100: ");
            Number = int.Parse(Console.ReadLine());
        } while (Number <= 100);
        Console.WriteLine("You entered: " + Number);

        Console.WriteLine();

        Console.WriteLine("Multiples of 10 to 1000 while loop");
        int multiple = 10;
        while (multiple <= 1000)
        {
            Console.WriteLine(multiple);
            multiple += 10;
        }
        Console.WriteLine();

        Console.WriteLine("Pattern Printer");
        for (int i = 1; i <= 10; i++) 
    {
        for (int j = 1; j <= i; j++) 
      {
        Console.Write("*");
      }
        Console.WriteLine(); 
    }
}
    
}