using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int output = ((startNumber / n) + 1) * n;
            return output;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business bus in businesses)
            {
                if (bus.TotalRevenue == 0)
                {
                    bus.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            List<int> afterEvens = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 ==0)
                {
                    afterEvens.Add(numbers[i + 1]);
                        
                }
            }
            return afterEvens.Sum();

        }
        public string TurnWordsIntoSentence(string[] words)
        {
           return string.Join(" ", words);
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            

            return elements.ToArray(); 
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
