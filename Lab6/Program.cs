namespace Lab6;

using System;

class Car
{
  public string model;
  public string color;
  public int year;

  // Example method to display car details. You can use this as an example for the other methods.
  public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
  }

  public void Startcar()
    {
        Console.WriteLine("The Car is Starting ");
    }

  public void Milesdriven(int miles)
    {
        Console.WriteLine("The car drove " + miles + "miles.");
    }

  public string Cardescription()
    {
        return year + " " + color + " " + " " + model;
    } 

  public void Repaintcar(string newColor)
    {
      color = newColor;  
      Console.WriteLine("The car has been repainted to " + color + "!");
    }   
}

class Program
{
  static void Main()
  {
    // Creating a Car object and assigning values to its properties
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;

    myCar.Display(); // Calling the Display method

    myCar.Startcar();

    myCar.Milesdriven(50);

    string describe = myCar.Cardescription();
    Console.WriteLine(describe);

    myCar.Repaintcar("yellow");
   
  }
}