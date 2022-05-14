

using System;

namespace UC13_StoreTheDailyWageWithTotalWage
{
    class CompanyEmpWage
    {
        //Declaring Constant Variable
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        //Creating a interface 
        public interface ComputationEmployeeWage
        {
            void ComputeEmpWage();
            int ComputeEmpWage(ComputeEmpWage companyEmpWage);
        }
        //Implements the interface in class
        public class EmpBuilderWage : ComputationEmployeeWage
        {
            public const int FULL_TIME = 1;
            public const int PART_TIME = 2;
            private int numOfCompany = 0;

            private ComputeEmpWage[] companyEmpWageArray;
            private int totalWage;


            public EmpBuilderWage()
            {
                this.companyEmpWageArray = new ComputeEmpWage[5];
            }
            public void addCompanyEmpWage(string company, int wagePerhour, int maxHoursPerMonth, int maxWorkingDays)
            {
                companyEmpWageArray[this.numOfCompany] = new ComputeEmpWage(company, wagePerhour, maxHoursPerMonth, maxWorkingDays);
                numOfCompany++;
            }
            public void ComputeEmpWage()
            {
                for (int i = 0; i < numOfCompany; i++)
                {
                    companyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                    Console.WriteLine(this.companyEmpWageArray[i].toString());
                }
            }
            public void ComputeEmpWage1()
            {
                for (int i = 0; i < numOfCompany; i++)
                {
                    companyEmpWageArray[i].setTotalEmpWage1(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                    Console.WriteLine(this.companyEmpWageArray[i].DailywageCalc());
                }
            }
            public int ComputeEmpWage(ComputeEmpWage companyEmpWage)
            {
                //Console.WriteLine("Welcome to employee wage computation");
                //Creating a Random Function
                int empHours = 0, totalEmpHrs = 0, totalWorkingDays = 0;
                //workingHrs=0;

                while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays <= companyEmpWage.maxWorkingDays)
                {
                    //Calling the next method in Random Class
                    totalWorkingDays++;
                    Random r = new Random();
                    int empAttendance = r.Next(0, 3);
                    switch (empAttendance)
                    {
                        case FULL_TIME:
                            empHours = 8;
                            break;
                        case PART_TIME:
                            empHours = 4;
                            break;
                        default:
                            empHours = 0;
                            break;
                    }
                    totalEmpHrs += empHours;
                }
                Console.WriteLine("Days : " + totalWorkingDays + " Emp Hours : " + empHours);
                return totalEmpHrs * companyEmpWage.wagePerHour;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to employee wage computation");
                EmpBuilderWage empBuilderWage = new EmpBuilderWage();
                empBuilderWage.addCompanyEmpWage("SUZUKI", 70, 20, 10);
                empBuilderWage.addCompanyEmpWage("YAMAHA", 50, 30, 20);
                empBuilderWage.ComputeEmpWage();
                empBuilderWage.ComputeEmpWage1();
            }
        }
    }
}
