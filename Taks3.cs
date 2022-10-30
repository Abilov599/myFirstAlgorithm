using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        var n = Convert.ToInt32(Console.ReadLine());
        var sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine(sum);
    }
}