using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sumEvens = numbers.Where(x => x % 2 == 0).Sum();

            var sumOdds = numbers.Where(x => x % 2 != 0).Sum();

            return sumEvens - sumOdds;

            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> list = new List<string>() { str1, str2, str3, str4 };

            list.ToArray();

            int minLength = list.Min(i => i.Length); 
            
            return minLength;
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
                int[] ints = new int[] {number1, number2, number3, number4};

            Array.Sort(ints);
            return ints[0];

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {

            
            if (sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1)
            {
                return false;

            }
            return true;
        }

        public bool IsStringANumber(string input)
        {
            bool isNumber = double.TryParse(input, out _); 
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullCount = 0;
            foreach (var item in objs)
            {
                if(item == null)
                {
                    nullCount++;
                }
            }
            if (nullCount > objs.Count() / 2)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            bool allOdd = numbers.All(x => x % 2 != 0);

            if (allOdd == true)
            {
                return 0;
            }

            var averageEvens = numbers.Where(x => x % 2 == 0).Average();
            
            
            return averageEvens;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0)
            {
                return 1;
            }
            for (int i = number - 1; i > 0; i--)
            {
                number *= i;
            }

            return number;
        }
    }
}
