using System;
using System.Collections.Generic;
using System.Text;

namespace Logistics
{
    // 6. Single Responsibility principle: 

    // Violated: Driver class handles both driver management and salary calculations
    public class Driver
    {
        public void AddDriver()
        {
            Console.WriteLine("Driver is added");
        }
        public void CalculateSalary()
        {
            Console.WriteLine("Calculate salary of driver");
        }
    }

    // Fixed: DriverService now handles driver data/behaviour and SalaryService handles salary logic 
    public class DriverService
    {
        public void AddDriver()
        {
            Console.WriteLine("Driver adding functionality");
        }
    }

    public class SalaryService
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Salary calculating functionality");
        }
    }

}
