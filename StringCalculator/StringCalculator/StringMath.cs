using System.Drawing;

namespace StringCalculator
{
    public static class StringMath
    {
        public static int AddOne(string numbers)
        {
            long sum = 0;
            String[] numbersArray = numbers.Split(',');
            int[] intArray = Array.ConvertAll(numbersArray, int.Parse);
            foreach (var number in intArray)
            {
                sum += number;
            }
            return (int)sum;
        }
    }
}
