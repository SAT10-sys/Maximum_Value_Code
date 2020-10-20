using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum_Value_Code
{
    public class Maximum_Value<T> where T : IComparable
    {
        T[] values;
        public Maximum_Value(T[] values)
        {
            this.values = values;
        }
        public T GetMaximumValue()
        {
            Array.Sort(values);
            return values[values.Length - 1];
        }
    }
}
  
        
