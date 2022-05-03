using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class UC6
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int MAX_MONTHLY_HRS = 100;
        public const int TOTAL_MONTHLY_DAYS = 20;
        public void bbb()
        {
            int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWages = 0;
            int i = 0;
            int monthWage = 0;
            int totalhrs = 0;
            Console.WriteLine("Ouput For UC 6");

            for (i = 0; i <= TOTAL_MONTHLY_DAYS; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                Console.WriteLine("employee status : " + empCheck);
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
                if (totalhrs <= 100)
                {
                    empWages = empHrs * EMP_RATE_PER_HR;
                    monthWage = monthWage + empWages;
                }
            }

            Console.WriteLine("Employee wages for present days : " + monthWage);
        }
    }
}