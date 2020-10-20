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
        }
    }
}
