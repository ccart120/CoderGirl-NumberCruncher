﻿using System;
using System.Collections.Generic;

namespace NumberCruncher
{
    public static class Program
    {
        public static void Main()
        {
            List<int> NumberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(NumberUtility.NumberCruncher.SumOfEvenNumbers(NumberList));
            Console.ReadLine();
        }


   /* public class NumberCruncher
        {

           
            public static int SumOfEvenNumbers(List<int> NumberList)
            {
                //method should find the sum of all even numbers in NumberList
                var result = NumberList.Where(i => i % 2 == 0).Sum();
                return result;
            }
            */
            
    }
}
