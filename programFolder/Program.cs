using System;

namespace programFolder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please type a year:");
            int year = receiveInput();
            bool result = IsLeapYear(year);

            if(result) 
            {
                Console.WriteLine("yay");
            } 
            else 
            {
                Console.WriteLine("nay");
            }
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

        public static int receiveInput() {
            int year;
            try {
                year = int.Parse(Console.ReadLine());
            } catch(Exception e) {
                Console.WriteLine("Please only type numbers");
                year = receiveInput();
            }
            if(year < 1582) {
                Console.WriteLine("Leap years only really count from 1582 and up, please try again");
                year = receiveInput();
            }
            return year;
        }
    }
}
