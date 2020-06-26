using System;

class MainClass {
  public static void Main (string[] args) {
    int counter = 0;
    int total = 0; 
    int x = 1;
    Console.WriteLine("How many cars do you wish to enter?");
    int numberofCars = Convert.ToInt32(Console.ReadLine());
   

    while(counter < numberofCars)
    {
      Console.WriteLine("Enter the distance traveled by car #" + x);
      int distance = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the time taken by car #" + x);
      int time = Convert.ToInt32(Console.ReadLine());
      int s = distance/time; 
      Console.WriteLine("The speed of the car is " + s + " miles per hour");
      total = total + s;
      counter++;
      x++;
    
      

    }
    double average = total / numberofCars;
    Console.WriteLine("The average speed of the " + counter +  " cars is " + average + " miles per hour");
  }
}