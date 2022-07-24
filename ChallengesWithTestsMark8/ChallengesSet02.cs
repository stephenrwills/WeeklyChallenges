using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
            return false;   
            
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var totalElements = vals.Length;

            if (totalElements %2 == 0)
            {
                return true;
            }

            else return false;
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if(num %2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {


            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }


            double sum = numbers.Min() + numbers.Max();
            return sum;
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {

            return Math.Min(str1.Length, str2.Length);
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            var evensList = new List<int>();
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    evensList.Add(item);
                }
            }
            return evensList.Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {

            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = numbers.Sum();

            if (sum % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {

                return 0;
            }

            return number / 2;
        }
    }
}
