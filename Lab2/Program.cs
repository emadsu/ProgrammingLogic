namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        int myInt = 29;
        double myDouble = 12.3;
        float myFloat = 7.89F;
        char myChar = 'A';
        bool myBool = true;
        string myString = "Hi";

 
        Console.WriteLine("int: " + myInt);
        Console.WriteLine("double: " + myDouble);
        Console.WriteLine("float: " + myFloat);
        Console.WriteLine("char: " + myChar);
        Console.WriteLine("bool: " + myBool);
        Console.WriteLine("string: " + myString);


         double doubleValue = 9.78;
        int intValue = (int)doubleValue;  

        int myInt2 = 42;
        bool myBool2 = false;

        string intToString = Convert.ToString(myInt2);
        string boolToString = Convert.ToString(myBool2);

 
        Console.WriteLine("Original double: " + doubleValue);
        Console.WriteLine("After casting to int: " + intValue);
        Console.WriteLine("Int to string: " + intToString);
        Console.WriteLine("Bool to string: " + boolToString);

     
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello " + userName + ". You are " + userAge + " years old.");

        int num1 = 5;
        int num2 = 10;

 
        Console.WriteLine("Addition (+10): " + (num1 + 10));
        Console.WriteLine("Subtraction (-2): " + (num1 - 2));
        Console.WriteLine("Multiplication (*3): " + (num1 * 3));
        Console.WriteLine("Division (/2): " + (num1 / 2));
        Console.WriteLine("Modulus (%2): " + (num1 % 2));

        float floatNum = 1.123456789F;
        double doubleNum = 1.123456789;

 
        Console.WriteLine("Float value: " + floatNum);
        Console.WriteLine("Double value: " + doubleNum);
        Console.WriteLine("The double is more precise than float.");

        int intcrement = 10;

         
        Console.WriteLine("Original : " + intcrement);

        intcrement++;
        Console.WriteLine(" increment (++): " + intcrement);

        intcrement--;
        Console.WriteLine(" decrement (--): " + intcrement);
    }
}
