using System;

namespace RealEstateAgencyAPI.Models.FuzzyLogic
{
    static internal class SimilarityComputing
    {
        private static bool s_testIsLongerOrEqual = false;
        private static byte[] s_truthTable;
        private static byte[] s_valueToCompare;
        private static double s_distance = 0;
        private static double s_firstDenominator = 0;
        private static double s_nominator = 0;
        private static double s_secondDenominator = 0;
        private static double s_sum;
        private static int s_length;

        public static double Distance(byte[] test, byte[] question)
        {
            
            FormatArray(test, question);

            for (int i = 0; i < test.Length; i++)
            {
                s_distance += Math.Pow((test[i] - question[i]), 2);
            }

            return Math.Sqrt(s_distance);
        }

        public static double Distance(string test, string question)
        {
            FormatData(test.ToLower(), question.ToLower());

            for (int i = 0; i < s_length; i++)
            {
                s_distance += Math.Pow((s_truthTable[i] - s_valueToCompare[i]), 2);
            }

            return Math.Sqrt(s_distance);
        }

        public static double Similarity(byte[] test, byte[] question)
        {
            FormatArray(test, question);

            for (int i = 0; i < test.Length; i++)
            {
                s_nominator += test[i] * question[i];
                s_firstDenominator += test[i];
                s_secondDenominator += question[i];
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

        private static void FormatArray(byte[] test, byte[] question)
        {
            if (test.Length != question.Length)
            {
                if (test.Length > question.Length)
                {
                    Array.Resize(ref question, test.Length);
                    for (int i = question.Length; i < test.Length; i++)
                    {
                        question[i] = 0;
                    }
                }
                else
                {
                    Array.Resize(ref test, question.Length);
                    for (int i = test.Length; i < question.Length; i++)
                    {
                        test[i] = 0;
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

            s_truthTable = new byte[s_length];
            s_valueToCompare = new byte[s_length];

            for (int i = 0; i < s_length; i++)
            {
                s_truthTable[i] = 1;
                s_valueToCompare[i] = 0;
            }


            if (s_testIsLongerOrEqual)
            {
                for (int i = 0; i < question.Length; i++)
                {
                    if (test[i] == question[i])
                    {
                        s_valueToCompare[i] = 1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < test.Length; i++)
                {
                    if (test[i] == question[i])
                    {
                        s_valueToCompare[i] = 1;
                    }
                }
            }
        }
    }
}
