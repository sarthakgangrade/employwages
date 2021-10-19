using System;

namespace CalculateWagesForMonth
{
    class UC5_WagesForMonth
    {
        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUMBER_OF_WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            //Variables
            int EmpHrs = 0;
            int EmpWage = 0;
            int TotalEmpWages = 0;

            for (int days = 0; days < NUMBER_OF_WORKING_DAYS; days++)
            {
                Random random = new Random();
                int CheckEmp = random.Next(0, 3);

                //Using Switch Case
                switch (CheckEmp)
                {
                    case IS_PART_TIME:
                        EmpHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        EmpHrs = 8;
                        break;

                    default:
                        EmpHrs = 0;
                        break;
                }

                EmpWage = EmpHrs * EMP_RATE_PER_HOUR;
                TotalEmpWages += EmpWage;
                Console.WriteLine("Employee Wages is : " + EmpWage);
            }

            Console.WriteLine("Total Employee Wages in Month : " + TotalEmpWages);
        }
    }
}