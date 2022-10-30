using System;

namespace Task2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of X");

            int X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("X = " + X);



            Console.WriteLine("Enter value of Y");

            int Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Y = " + Y);



            Console.WriteLine("Enter value of Z");

            int Z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Z = " + Z);


            
                if (X < Y && X < Z)

                    Console.WriteLine("En kichiyi " + X + " dir");
            
            
                if (Y < X && Y < Z)

                    Console.WriteLine("En kichiyi " + Y + " dir");


                if (Z < X && Z < Y)

                    Console.WriteLine("En kichiyi " + Y + " dir");


        }
    }
}