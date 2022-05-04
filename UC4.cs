using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class UC4
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public void lmn()
        {

            int EMP_RATE_PER_HR = 20;

            int empHrs = 0;
            int empWages = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 3);

            Console.WriteLine("Employee status using switch case : " + empCheck);

            switch (empCheck)
            {
                case FULL_TIME:
                    empHrs = 8;
                    break;
                case PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            empWages = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage For part time using switch case : " + empWages);
        }
    }
}