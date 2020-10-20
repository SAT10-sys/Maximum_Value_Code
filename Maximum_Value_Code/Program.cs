using System;

namespace Maximum_Value_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum Value Problem using Generics");
            Console.WriteLine("Enter three integers");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            int secondInteger= Convert.ToInt32(Console.ReadLine());
            int thirdInteger= Convert.ToInt32(Console.ReadLine());
            Maximum_Value maximumValue = new Maximum_Value();
            int maximumNumber = maximumValue.GetMaximumInteger(firstInteger, secondInteger, thirdInteger);
            Console.WriteLine("The maximum Integer is: "+maximumNumber); 
            Console.WriteLine("Enter three decimal values");
            double firstDouble = Convert.ToDouble(Console.ReadLine());
            double secondDouble= Convert.ToDouble(Console.ReadLine());
            double thirdDouble= Convert.ToDouble(Console.ReadLine());
            double maximumDouble = maximumValue.GetMaximumFloatingPointValue(firstDouble, secondDouble, thirdDouble);
            Console.WriteLine("The maximim Double Value is: " + maximumDouble);
            Console.WriteLine("Enter three strings");
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            string thirdString = Console.ReadLine();
            string maximumString = maximumValue.GetMaximumString(firstString, secondString, thirdString);
            Console.WriteLine("Maximum String: "+ maximumString);
        }
    }
}
