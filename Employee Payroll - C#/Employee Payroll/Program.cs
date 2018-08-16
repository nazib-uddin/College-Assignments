using System;
using static System.Console;

namespace Employee_Payroll
{
    class Program
    {
        static void Main()
        {
            string firstname, lastname, type;
            int id;
            const double FEDTAX = 0.18, RETIREMENT = 0.1, SOCIALTAX = 0.06;
            double salary=0, hours, rate, amount;
            WriteLine("Enter the Employee's First Name: ");
            firstname = ReadLine();
            WriteLine("Enter the Employee's Last Name: ");
            lastname = ReadLine();
            WriteLine("Enter the Employee ID number: ");
            id = int.Parse(ReadLine());
            WriteLine("Enter the payroll type, salary or hourly: ");
            type = ReadLine();
            if (type[0]=='s'||type[0]=='S')
            {
                WriteLine("Enter the Salary amount: ");
                salary = double.Parse(ReadLine());

            }
            else if (type[0]=='h'||type[0]=='H')
            {
                WriteLine("Enter the hourly rate: ");
                rate = double.Parse(ReadLine());
                WriteLine("Enter the number of hours worked: ");
                hours = double.Parse(ReadLine());
                if (hours<=40)
                {
                    salary = hours * rate;
                }
                else if (hours>40)
                {
                    salary = (40 * rate) + ((hours - 40) * 1.5 * rate);
                }
                else
                {
                    WriteLine("You have made an error in entering the number of hours.");
                }
            }
            else
            {
                WriteLine("You have made an error in entering the payroll type.");
            }
            amount = salary - (salary * FEDTAX) - (salary * RETIREMENT) - (salary * SOCIALTAX);
            WriteLine("The Employee's full name is: " + firstname + " " + lastname + ".");
            WriteLine("The Employee ID is: " + id);
            WriteLine("The Employee payroll amount is {0:C}", amount);
        }
    }
}
