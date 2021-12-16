using System;
using System.Collections.Generic;

namespace RealEstateAgencyAPI.Models.FuzzyLogic
{
    public static class TriangularDistribution
    {
        private static Dictionary<int, double> s_selectedValues;
        private static int s_step = 0;
        private static int s_peek;
        private static List<Dictionary<int, double>> s_selectedValuesList;

        public static Dictionary<int, double> CalculateDistribution(int[] field, int peek)
        {
            s_peek = peek;
            s_selectedValues = new Dictionary<int, double>();

            SetStep();
            foreach (int item in field)
            {
                AddItem(item);
            }
            return s_selectedValues;
        }

        public static double CalculateDistributionForSingleRecord(int test, int peek)
        {
            s_peek = peek;
            SetStep();
            if ((s_peek - s_step) < test && test <= (s_peek + s_step))
            {
                double value = (double)(s_step - Math.Abs(test - s_peek)) / s_step;
                return value;

            }
            return -1;
        }

        public static List<Dictionary<int, double>> CalculateDistribution(List<int[]> fields, List<int> peeks)
        {
            s_selectedValuesList = new List<Dictionary<int, double>>();

            for (int i = 0; i < fields.Count; i++)
            {
                s_selectedValuesList.Add(CalculateDistribution(fields[i], peeks[i]));
            }

            return s_selectedValuesList;
        }

        private static void AddItem(int item)
        {
            if ((s_peek - s_step) < item && item <= (s_peek + s_step))
            {
                double value = (double)(s_step - Math.Abs(item - s_peek)) / s_step;
                if(value != 0)
                {
                    s_selectedValues.Add(item, value);
                }
                else
                {
                    s_selectedValues.Add(item, 0);
                }
                
            }
        }

        private static void SetStep()
        {
            if (s_peek < 11)
            {
                s_step = 2;
            }
            if (10 < s_peek && s_peek < 51)
            {
                s_step = 5;
            }
            if (50 < s_peek && s_peek < 151)
            {
                s_step = 10;
            }
            if (150 < s_peek)
            {
                s_step = (int)(Math.Round(s_peek * 0.9));
            }
        }
    }
}
