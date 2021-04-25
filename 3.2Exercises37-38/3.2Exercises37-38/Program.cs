using System;
using System.Linq;

namespace _3._2Exercises37_38
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;

            while (loop)
            {
                int[] numbers = new int[5];

                int sum = 0;

                Console.WriteLine("Give me a number!");

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                    sum += numbers[i];

                    if (i < numbers.Length - 1)
                    {
                        Console.WriteLine("\nGive me another number!");
                    }
                }

                double average = (double)sum / numbers.Length;
                Console.WriteLine($"\nThe sum of your array is {sum}, with an average of {average}.");

                Console.WriteLine("\nWant to try a different array? Y/N");
                string again = Console.ReadLine().ToLower();

                if (again == "y")
                {
                    loop = true;
                }
                else
                {
                    loop = false;
                }
            }
        }
    }
}
