using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum_Value_Code
{
    public class Maximum_Value
    {
        public int GetMaximumInteger(int firstInteger, int secondInteger, int thirdInteger)
        {
            if (firstInteger.CompareTo(secondInteger) > 0 && firstInteger.CompareTo(thirdInteger) > 0)
                return firstInteger;
            if (secondInteger.CompareTo(firstInteger) > 0 && secondInteger.CompareTo(thirdInteger) > 0)
                return secondInteger;
            if (thirdInteger.CompareTo(firstInteger) > 0 && thirdInteger.CompareTo(secondInteger) > 0)
                return thirdInteger;
            throw new Exception("Numbers are same. Please enter different numbers");
        }
        public double GetMaximumFloatingPointValue(double firstDouble, double secondDouble, double thirdDouble)
        {
            if (firstDouble.CompareTo(secondDouble) > 0 && firstDouble.CompareTo(thirdDouble) > 0)
                return firstDouble;
            if (secondDouble.CompareTo(firstDouble) > 0 && secondDouble.CompareTo(thirdDouble) > 0)
                return secondDouble;
            if (thirdDouble.CompareTo(firstDouble) > 0 && thirdDouble.CompareTo(secondDouble) > 0)
                return thirdDouble;
            throw new Exception("Numbers are same. Please enter different numbers");
        }
    }
}
