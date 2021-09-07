﻿using System;

namespace programFolder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsLeapYear(int year) 
        {
            bool isLeapYear = false;

            if(year%4 == 0) 
            {
                isLeapYear = true;
            }
            if(year%100 == 0) 
            {
                isLeapYear = false;
            }
            if(year%400 == 0) 
            {
                isLeapYear = true;
            }

            return isLeapYear;
        }
    }
}
