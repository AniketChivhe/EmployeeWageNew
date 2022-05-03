using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class UC2_DailyWage
    {
        public void abc()
        {
            int FULL_TIME = 1;
            int EMP_RATE_PER_HR = 20;

            int empHrs = 0;
            int empWages = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            Console.WriteLine("Employee status : " + empCheck);

            if (empCheck == FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWages = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Daily Wage : " + empWages);
        }
    }
}