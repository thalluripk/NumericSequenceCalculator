using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumericSequenceCalculator.Services
{
    /// <summary>
    /// Generates various numeric sequences
    /// </summary>
    public class NumericSequenceGenerator
    {

        public static string GenerateNumberSequence(uint num)
        {
            var sequenceList = new List<string>();

            for (uint i = 1; i <= num; i++)
            {
                sequenceList.Add(i.ToString());
            }

            return string.Join(" ", sequenceList.ToArray());

        }

        public static string GenerateOddNumberSequence(uint num)
        {
            var sequenceList = new List<string>();

            for (uint i = 1; i <= num; i++)
            {
                if (i % 2 == 1 || i == num)
                    sequenceList.Add(i.ToString());
            }

            return string.Join(" ", sequenceList.ToArray());
        }

        public static string GenerateEvenNumberSequence(uint num)
        {
            var sequenceList = new List<string>();

            for (uint i = 1; i <= num; i++)
            {
                if (i % 2 == 0 || i == num)
                    sequenceList.Add(i.ToString());
            }

            return string.Join(" ", sequenceList.ToArray());
        }

        public static string GenerateEncodedNumberSequence(uint num)
        {
            var sequenceList = new List<string>();

            for (uint i = 1; i <= num; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    sequenceList.Add("Z");
                else if (i % 3 == 0)
                    sequenceList.Add("C");
                else if (i % 5 == 0)
                    sequenceList.Add("E");
                else
                    sequenceList.Add(i.ToString());
            }

            return string.Join(" ", sequenceList.ToArray());
        }

        public static string GenerateFibonacciNumberSequence(uint num)
        {
            var sequenceList = new List<string>();
            sequenceList.Add("1");

            int a = 1, b = 1, c = 0;

            while (true)
            {
                c = a + b;
                if (c > num)
                {
                    if (b != num)
                        sequenceList.Add(num.ToString());
                    break;
                }

                sequenceList.Add(c.ToString());

                a = b;
                b = c;
            }

            return string.Join(" ", sequenceList.ToArray());
        }

    }
}