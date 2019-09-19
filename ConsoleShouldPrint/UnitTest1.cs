using FizzBuzzv2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleShouldPrint
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FizzIfMultOf3()
        {
            var fbe = new FizzBuzzEvaluator();
            int x = 3;
            var result = fbe.Evaluate(x);

            Assert.IsTrue(result == "fizz");
        }

        [TestMethod]
        public void NumberIfNotMultOf3or5()
        {
            var fbe = new FizzBuzzEvaluator();
            int x = 7;
            var result = fbe.Evaluate(x);

            Assert.IsTrue(result == x.ToString());
        }

        [TestMethod]
        public void NOTFizzOrBuzzIfNotMultOf3Or5()
        {
            var fbe = new FizzBuzzEvaluator();
            int x = 11;
            var result = fbe.Evaluate(x);

            Assert.IsFalse(result == "fizz" || result == "buzz");
        }

        [TestMethod]
        public void BuzzIfMultOf5()
        {
            var fbe = new FizzBuzzEvaluator();
            int x = 5;
            var result = fbe.Evaluate(x);

            Assert.IsTrue(result == "buzz");
        }

        [TestMethod]
        public void FIZZBUZZ_if_Mult_of_3_and_5()
        {
            var fbe = new FizzBuzzEvaluator();
            int x = 15;
            var result = fbe.Evaluate(x);

            Assert.IsTrue(result == "FIZZ BUZZ!");
        }

    }
}
