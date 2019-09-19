using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzv2
{
    public class FizzBuzzEvaluator
    {

        public string Evaluate(int x)
        {

            if (x % 3 == 0)
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
