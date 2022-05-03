using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class UC5_WagesForMonth
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public void aaa()
        {

            int EMP_RATE_PER_HR = 20;

            int empHrs = 8;
            int empWages = 0;
            int i = 0;
            int monthWage = 0;



            for (i = 0; i <= 20; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);


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
                monthWage = monthWage + empWages;
            }

            Console.WriteLine("Employee wages for present days : " + monthWage);


        }
    }
}