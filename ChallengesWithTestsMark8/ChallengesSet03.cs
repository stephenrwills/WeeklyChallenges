using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
              
           
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false && vals.Length != 0)
                {
                    return true;
                }

               
            }
            return false;

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var oddNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number %2 != 0)
                {
                    oddNumbers.Add(number);
                }
            }

            var sumOfOdds = oddNumbers.Sum();

            if (sumOfOdds %2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

             if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            string answer = val.Substring(0, 1);
            var newAnswer = char.Parse(answer);

            return newAnswer;
        }

        public char GetLastLetterOfString(string val)
        {
            char lastLetter = val[val.Length - 1];
            return lastLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            var lastInt = nums[nums.Length - 1];
            var firstInt = nums[0];

            return lastInt - firstInt;
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();   


            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }  
            }
            return odds.ToArray();  
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
               words[i] = words[i].ToUpper();
            }                
        }
    }
}
