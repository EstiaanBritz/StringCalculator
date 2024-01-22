using StringCalculator;

namespace StringCalculatorTests
{
    public class StringMathTests
    {
        [Fact]
        public void StepOne()
        {
            Assert.Equal(0, StringMath.AddOne(""));
            Assert.Equal(1, StringMath.AddOne("1"));
            Assert.Equal(3, StringMath.AddOne("1,2"));
            Assert.Equal(37, StringMath.AddOne("5,8,9,1,2,3,4,5"));
        }
        [Fact]
        public void StepTwo()
        {
            Assert.Equal(6, StringMath.AddTwo("1\n2,3"));
            Assert.Equal(0, StringMath.AddTwo("1,\n"));
            Assert.Equal(32, StringMath.AddTwo("4\n7\n8,9,3\n1"));
            
        }
        [Fact]
        public void StepThree()
        {
            Assert.Equal(3, StringMath.AddThree("//;\n1;2"));
            Assert.Equal(11, StringMath.AddThree("//#\n5#6"));
            Assert.Equal(103, StringMath.AddThree("//*\n1*2*100"));

        }

        [Fact]
        public void StepFour()
        {
            var exceptionOne = Assert.Throws<ArgumentException>(() => StringMath.AddFour("//;\n1;-2"));
            Assert.Equal("negatives not allowed -2", exceptionOne.Message);

            var exceptionTwo = Assert.Throws<ArgumentException>(() => StringMath.AddFour("-1,2,-5,-9"));
            Assert.Equal("negatives not allowed -1,-5,-9", exceptionTwo.Message);

            var exceptionThree = Assert.Throws<ArgumentException>(() => StringMath.AddFour("1\n2,-3"));
            Assert.Equal("negatives not allowed -3", exceptionThree.Message);

        }

        [Fact]
        public void StepFive()
        {

            Assert.Equal(3, StringMath.AddFive("//;\n1;1001;2"));
            Assert.Equal(6, StringMath.AddFive("1\n2,3,1005"));
            Assert.Equal(103, StringMath.AddFive("//*\n1*2*100*1089"));
        }

        [Fact]
        public void StepSix()
        {

            Assert.Equal(6, StringMath.AddFive("//[***]\n1***2***3"));
            Assert.Equal(30, StringMath.AddFive("//[-+-]\n3-+-6-+9-+-12"));
            Assert.Equal(103, StringMath.AddFive("//[ABC]\n1ABC2ABC100ABC1089"));
        }
    }
}