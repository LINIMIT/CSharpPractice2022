using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    public static class RBC
    {
        public static double CalculateTotalCost(StreamReader input)
        {
            double pOfFood = 0;
            pOfFood = double.Parse(input.ReadLine());
            pOfFood += double.Parse(input.ReadLine());
            pOfFood += double.Parse(input.ReadLine());
            pOfFood += double.Parse(input.ReadLine());
            pOfFood += double.Parse(input.ReadLine());

            double tipPercent = (double.Parse(input.ReadLine()) / 100);
            double taxrate = 0.05;

            double tax = pOfFood * tipPercent;
            double tip = (pOfFood + tax) * tipPercent / 100;

            double result = pOfFood + tax + tip;

            return Math.Round(result,2);

        }
        public static double CalculateIndividualCost(StreamReader input, double totalCost)
        {
            double result = totalCost / double.Parse(input.ReadLine());
            return Math.Round(result,2);
        }
        public static uint CalculatePayerCount(StreamReader input, double totalCost)
        {
            double result = totalCost / double.Parse(input.ReadLine());
            return (uint)Math.Ceiling(result);
        }
    }
}