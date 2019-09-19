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

            Assert.IsTrue(result == "buzz");
        }

        [TestMethod]
        public void NumberIfNotMultOf3()
        {
            var fbe = new FizzBuzzEvaluator();
            int x = 10;
            var result = fbe.Evaluate(x);

            Assert.IsTrue(result == x.ToString());
        }

        [TestMethod]
        public void NOTBuzzIfNotMultOf3()
        {
            var fbe = new FizzBuzzEvaluator();
            int x = 10;
            var result = fbe.Evaluate(x);

            Assert.IsFalse(result == "buzz");
        }
    }
}
