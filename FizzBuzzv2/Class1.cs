using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzv2
{
    public class FizzBuzzEvaluator
    {

        public string Evaluate(int x)
        {
            if ((x % 3 == 0) && (x % 5 == 0))
            {
                return "FIZZ BUZZ!";
            }
            else if ((x % 3 == 0) && (x %5 != 0))
            {
                return "fizz";

            }
            else if ((x % 5 == 0) && (x % 3 != 0))
            {
                return "buzz";
            }
            else
            {
                return x.ToString();
            }
        }

    }
}
