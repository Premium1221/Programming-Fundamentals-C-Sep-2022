﻿using System;

namespace Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int finalNum = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = startNum; i <= finalNum; i++)
            {
                sum += i;
                Console.Write(i+" ");
                
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
