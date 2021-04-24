using System;

namespace TestingBookCode
{
    class Program
    {

        static void Main(string[] args)
        {
            int NumberOfTestResults = 1;
            int PassNumber = 0;
            int FailNumber = 0;

            while (NumberOfTestResults <= 10)
            {

                Console.WriteLine("Enter result of \"1\" as passing, or \"2\" as failing");
                int TestResult = int.Parse(Console.ReadLine());

                if (TestResult == 1)
                {
                    PassNumber += 1;
                }

                else if (TestResult == 2)
                {
                    FailNumber += 1;
                }
                NumberOfTestResults += 1;

            }
            Console.WriteLine($"{PassNumber} passed");
            Console.WriteLine($"{FailNumber} failed");

            if (PassNumber >= 8)
            {
                Console.WriteLine("Bonus to instructor!");
            }

        }


    }

}
