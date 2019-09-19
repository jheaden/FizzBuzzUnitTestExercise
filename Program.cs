using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fbe = new FizzBuzzEvaluator();

            for (int x = 1; x<= 100; x++)
            {
                Console.WriteLine(fbe.Evaluate(x));
            }


        }
    }
}
