using System;

namespace Maximum_Value_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values;
            int[] integerValues = new int[100];
            Console.WriteLine("Welcome To Maximum Number Problem");
            Console.WriteLine("Enter integers seperated by comma");
            values = Console.ReadLine().Split(",");
            for (int i = 0; i < values.Length; i++)
            {
                integerValues[i] = Convert.ToInt32(values[i]);
            }
            Maximum_Value<int> maximumInt = new Maximum_Value<int>(integerValues);
            maximumInt.DisplayMaximumValue();
            double[] doubleValues = new double[100];
            Console.WriteLine("Enter float numbers seperated by comma");
            values = Console.ReadLine().Split(",");
            for (int i = 0; i < values.Length; i++)
            {
                doubleValues[i] = Convert.ToDouble(values[i]);
            }
            Maximum_Value<double> maximumDouble = new Maximum_Value<double>(doubleValues);
            maximumDouble.DisplayMaximumValue();
            Console.WriteLine("Enter Strings seperated by comma");
            values = Console.ReadLine().Split(",");
            Maximum_Value<string> maximumString = new Maximum_Value<string>(values);
            string maxString = maximumString.GetMaximumValue();
            maximumString.DisplayMaximumValue();
        }
    }
}
