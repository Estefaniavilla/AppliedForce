using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter the mass (in kilograms): ");
        double mass = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the acceleration (in meters per second squared): ");
        double aceleration = Convert.ToDouble(Console.ReadLine());

        //fórmula F = ma
        double force = mass * aceleration;

        
        Console.WriteLine($"The applied force is: {force} newtons");
    }
}