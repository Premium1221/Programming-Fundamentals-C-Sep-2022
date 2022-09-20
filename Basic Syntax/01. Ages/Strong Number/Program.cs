using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numCopy = num;
            int sum = 0;
            while (numCopy>0)
            {
                int lastDigit = numCopy % 10;
                int factorial = 1;
                for (int i = 1; i <= lastDigit; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
                numCopy /= 10;
            }
            if (sum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
