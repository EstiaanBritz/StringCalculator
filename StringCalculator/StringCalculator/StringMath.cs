using System.Drawing;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace StringCalculator
{
    public static class StringMath
    {
        public static int AddOne(string numbers)
        {
            long sum = 0;
            if (numbers.Length>0)
            {
                String[] numbersArray = numbers.Split(',');
                int[] intArray = Array.ConvertAll(numbersArray, int.Parse);
                foreach (var number in intArray)
                {
                    sum += number;
                }
                return (int)sum;
            }

            return 0;
        }
        public static int AddTwo(string numbers)
        {
            long sum = 0;
            if (numbers.Contains(",\n"))
            {
                return 0;
            }
            if (numbers.Length > 0)
            {
                string[] numbersArray = numbers.Split(new Char[] { ',', '\n' });
                int[] intArray = Array.ConvertAll(numbersArray, int.Parse);
                foreach (var number in intArray)
                {
                    sum += number;
                }
                return (int)sum;
            }
            return 0;
        }
        public static int AddThree(string numbers)
        {
            var delimiters = new List<string> { ",", "\n" };

            if (numbers.StartsWith("//"))
            {
                var sections = numbers.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                delimiters.Add(sections.FirstOrDefault().Replace("//", ""));
                numbers = sections.LastOrDefault();
            }

            var splitNumbers = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            var sum = 0;
            foreach (var n in splitNumbers)
            {
                sum += int.Parse(n);
            }

            return sum;
        }

        public static int AddFour(string numbers)
        {
            var delimiters = new List<string> { ",", "\n", ";" };

            if (numbers.StartsWith("//"))
            {
                var sections = numbers.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                delimiters.Add(sections[0].Replace("//", ""));
                numbers = sections.LastOrDefault();
            }

            var splitNumbers = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            var negatives = "";
            var sum = 0;
            foreach (var n in splitNumbers)
            {
                if(int.Parse(n) < 0)
                    negatives += n + ",";

                sum += int.Parse(n);
            }

            if (negatives.Length > 0)
            {
                throw new ArgumentException("negatives not allowed " + negatives.Remove(negatives.Length -1 ,1));
            }

            return sum;
        }

        public static int AddFive(string numbers)
        {
            var delimiters = new List<string> { ",", "\n", ";" };

            if (numbers.StartsWith("//"))
            {
                var sections = numbers.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                delimiters.Add(sections[0].Replace("//", ""));
                numbers = sections.LastOrDefault();
            }

            var splitNumbers = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            var negatives = "";
            var sum = 0;
            foreach (var n in splitNumbers)
            {
                if (int.Parse(n) < 0)
                    negatives += n + ",";
                
                sum += int.Parse(n);

                if (int.Parse(n) > 1000)
                {
                    sum-= int.Parse(n);
                }
            }

            if (negatives.Length > 0)
            {
                throw new ArgumentException("negatives not allowed " + negatives.Remove(negatives.Length - 1, 1));
            }

            return sum;
        }

        public static int AddSix(string numbers)
        {
            var delimiters = new List<string> { ",", "\n" };

            if (numbers.StartsWith("//"))
            {
                var sections = numbers.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                delimiters.Add(sections[0].Replace("//", ""));
                numbers = sections.LastOrDefault();
            }

            var splitNumbers = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            var negatives = "";
            var sum = 0;
            foreach (var n in splitNumbers)
            {
                if (int.Parse(n) < 0)
                    negatives += n + ",";

                sum += int.Parse(n);

                if (int.Parse(n) > 1000)
                {
                    sum -= int.Parse(n);
                }
            }

            if (negatives.Length > 0)
            {
                throw new ArgumentException("negatives not allowed " + negatives.Remove(negatives.Length - 1, 1));
            }

            return sum;
        }
    }
}
