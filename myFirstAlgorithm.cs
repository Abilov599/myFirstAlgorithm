namespace myFirstAlgorithm
{

    internal class Program
    {
        static void Main(string[] args)
        {

            var num1 = 5;
            var num2 = 10;
            var num3 = 15;
            var sum = 0;


            if (num1 % 5 == 0)

                sum += num1;


            if (num2 % 10 == 0)

                sum += num2;


            if (num3 % 15 == 0)

                sum += num3;

            Console.WriteLine(sum);


        }
    }
}