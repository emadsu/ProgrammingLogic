using System.Collections;

namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        int a = 10, b = 5, c = 15;

        bool output1 = a > b;
        bool output2 = a < c;
        bool output3 = a > b && a > c;
        bool output4 = a > b || a > c;

        Console.WriteLine("a > b: " + output1);
        Console.WriteLine("a < c: " + output2);
        Console.WriteLine("a > b && a > c: " + output3);
        Console.WriteLine("a > b || a > c: " + output4);

        Console.WriteLine();
        Console.WriteLine();

        bool isRaining = true;
        bool haveUmbrella = false;

        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 5)
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (age >= 5 && age <= 12)
        {
            Console.WriteLine("Child ticket: $5");
        }
        else if (age >= 13 && age <= 64)
        {
            Console.WriteLine("Standard ticket: $10");
        }
        else if (age >= 65)
        {
            Console.WriteLine("Senior ticket: $6");
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Enter a number for the day of the week (1-7): ");
        int weekday = Convert.ToInt32(Console.ReadLine());

        switch (weekday)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid Day!");
                break;
            }    
        }
    }
 
