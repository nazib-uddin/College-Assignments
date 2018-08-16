using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Console;

namespace Date_Class
{
    class Date
    {
        int day, month, year;
        string nameOfMonth;

        public int getday
        {
            get { return day; }   
        }
        public int getmonth
        {
            get { return month; }

        }
        public int getyear
        {
            get { return year; }

        }
        public string getname (int month)
        {
            if (month==1)
            {
                nameOfMonth = "January";
            }
            else if (month == 2)
            { 
                nameOfMonth = "February";
            }
            else if(month == 3)
            {
                nameOfMonth = "March";
            }
            else if(month == 4)
            {
                nameOfMonth = "April";
            }
            else if(month == 5)
            {
                nameOfMonth = "May";
            }
            else if(month == 6)
            {
                nameOfMonth = "June";
            }
            else if(month == 7)
            {
                nameOfMonth = "July";
            }
            else if(month == 8)
            {
                nameOfMonth = "August";
            }
            else if (month == 9)
            {
                nameOfMonth = "September";
            }
            else if (month == 10)
            {
                nameOfMonth = "October";
            }
            else if (month == 11)
            {
                nameOfMonth = "November";
            }
            else if (month == 12)
            {
                nameOfMonth = "December";
            }
            else
            {
                WriteLine("You have entered an invalid month.");
            }

            return nameOfMonth;

        }
        public void setvalues(int a, int b, int c)
        {
            day = a;
            month = b;
            year = c;
        }

    }

   
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            WriteLine("Enter the day: ");
            a = int.Parse(ReadLine());
            WriteLine("\nEnter the month: ");
            b = int.Parse(ReadLine());
            WriteLine("\nEnter the year: ");
            c = int.Parse(ReadLine());
            Date obj1 = new Date();
            obj1.setvalues(a, b, c);
            WriteLine("\nThe date is " + obj1.getday.ToString() + "/" + obj1.getname(b) + "/" + obj1.getyear.ToString());
            ReadLine();
        }
    }
}
