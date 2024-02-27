namespace FizzBuzzProject.UnitTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void GetOutput_DivisbleBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void GetOutput_DivisbleBy3Only_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(6);

            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void GetOutput_DivisbleBy5Only_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(10);

            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void GetOutput_NotDisibleBy3Or5_ReturnNumber()
        {
            var result = FizzBuzz.GetOutput(7);

            Assert.AreEqual("7", result);
        }
    }
}