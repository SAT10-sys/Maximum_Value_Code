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
    }
}
