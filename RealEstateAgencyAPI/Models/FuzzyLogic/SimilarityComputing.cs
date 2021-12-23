using System;
using System.Linq;

namespace RealEstateAgencyAPI.Models.FuzzyLogic
{
    static internal class SimilarityComputing
    {
        private static bool s_testIsLongerOrEqual = false;
        private static bool[] s_truthTable;
        private static bool[] s_valueToCompare;
        private static double s_distance = 0;
        private static double s_firstDenominator = 0;
        private static double s_nominator = 0;
        private static double s_secondDenominator = 0;
        private static double s_sum;
        private static int s_length;

        public static double Distance(bool[] test, bool[] question)
        {
            
            FormatArray(test, question);

            for (int i = 0; i < test.Length; i++)
            {
                s_distance += Math.Pow(((test[i] ? 1 : 0) - (question[i] ? 1 : 0)), 2);
            }

            return Math.Sqrt(s_distance);
        }

        public static double Distance(string test, string question)
        {
            FormatData(test.ToLower(), question.ToLower());

            for (int i = 0; i < s_length; i++)
            {
                s_distance += Math.Pow(((s_truthTable[i] ? 1 : 0) - (s_valueToCompare[i] ? 1 : 0)), 2);
            }

            return Math.Sqrt(s_distance);
        }

        public static double Similarity(bool[] test, bool[] question)
        {
            FormatArray(test, question);

            s_firstDenominator = test.Count(t => t);
            s_secondDenominator = question.Count(q => q);

            for (int i = 0; i < test.Length; i++)
            {
                s_nominator += (test[i] && question[i]) ? 1: 0;
            }

            s_sum = Math.Sqrt(s_firstDenominator) * Math.Sqrt(s_secondDenominator);
            if (s_sum != 0)
            {
                return s_nominator / s_sum;
            }
            else
            {
                return 0;
            }

        }

        public static double Similarity(string test, string question)
        {
            s_nominator = 0;
            s_secondDenominator = 0;
            s_firstDenominator = 0;
            s_sum = 0;
            FormatData(test.ToLower(), question.ToLower());
            return Similarity(s_valueToCompare, s_truthTable);
        }

        private static void FormatArray(bool[] test, bool[] question)
        {
            if (test.Length != question.Length)
            {
                if (test.Length > question.Length)
                {
                    Array.Resize(ref question, test.Length);
                    for (int i = question.Length; i < test.Length; i++)
                    {
                        question[i] = false;
                    }
                }
                else
                {
                    Array.Resize(ref test, question.Length);
                    for (int i = test.Length; i < question.Length; i++)
                    {
                        test[i] = false;
                    }
                }
            }
        }

        private static void FormatData(string test, string question)
        {
            if (test.Length >= question.Length)
            {
                s_length = test.Length;
                s_testIsLongerOrEqual = true;
            }
            else
            {
                s_length = question.Length;
                s_testIsLongerOrEqual = false;
            }

            s_truthTable = new bool[s_length];
            s_valueToCompare = new bool[s_length];

            for (int i = 0; i < s_length; i++)
            {
                s_truthTable[i] = true;
                s_valueToCompare[i] = false;
            }


            if (s_testIsLongerOrEqual)
            {
                for (int i = 0; i < question.Length; i++)
                {
                    if (test[i] == question[i])
                    {
                        s_valueToCompare[i] = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < test.Length; i++)
                {
                    if (test[i] == question[i])
                    {
                        s_valueToCompare[i] = true;
                    }
                }
            }
        }
    }
}
