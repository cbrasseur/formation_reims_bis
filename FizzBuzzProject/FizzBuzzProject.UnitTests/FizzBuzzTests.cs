namespace FizzBuzzProject.UnitTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void GetOutput_WithMultipleOf3_ReturnsFizz()
        {
            var result = FizzBuzz.GetOutput(3);

            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void GetOutput_WithMulitpleOf5_ReturnsBuzz()
        {
            var result = FizzBuzz.GetOutput(5);

            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void GetOutput_WithOf3And5_ReturnsFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.AreEqual("FizzBuzz", result);
        }


        [TestMethod]
        public void GetOutput_WithNoMulitpleOf3And5_ReturnsNumberAsString()
        {
            var result = FizzBuzz.GetOutput(8);

            Assert.AreEqual("8", result);
        }
    }
}