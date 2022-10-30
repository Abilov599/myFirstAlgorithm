using System;

namespace Task2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of X: "); 
        var x = int.Parse(Console.ReadLine()!); 
 
        Console.Write("Enter the value of Y: "); 
        var y = int.Parse(Console.ReadLine()!); 
 
        Console.Write("Enter the value of Z: "); 
        var z = int.Parse(Console.ReadLine()!); 
 
        if (x < y && x < z) 
            Console.WriteLine($"Minimal value is {x}."); 
        else if (y < z) 
            Console.WriteLine($"Minimal value is {y}."); 
        else 
            Console.WriteLine($"Minimal value is {z}.");


        }
    }
}