using StringCalculator;

namespace StringCalculatorTests
{
    public class StringMathTests
    {
        [Fact]
        public void StepOne()
        {
            Assert.Equal(37, StringMath.AddOne("5,8,9,1,2,3,4,5"));
        }
    }
}