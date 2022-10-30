using System;

class Program
{
    static void Main(string[] args)
    {
        
        int a, b, c;

        var sum = 0;
        int abc = 278;
        a = abc / 100;
        b = abc / 10 % 10;
        c = abc % 10;
        sum = a + b + c;
       Console.WriteLine(sum);

        /*
        
        var sum = 0;
            Console.Write("Enter the value of Number: "); 
        var num = int.Parse(Console.ReadLine()!);
        
        sum = (num % 10) + ((num / 10) % 10) + ((num / 100) % 10);
            Console.Write($"Summation is {sum}.");
        */

    }
}