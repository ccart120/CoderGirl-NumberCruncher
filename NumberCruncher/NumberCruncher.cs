using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberCruncher
{
    public static class NumberUtility
    {
        public class NumberCruncher
        {
            public static int SumOfEvenNumbers(List<int> NumberList)
            {
                //method should find the sum of all even numbers in NumberList
                var result = NumberList.Where(i => i % 2 == 0).Sum();
                return result;
            }
        }
    }
}
