﻿using System;

namespace Basic_Syntax__Conditional_Statements_and_Loops___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            if (age<=2)
            {
                Console.WriteLine("baby");
            }
            else if (age>2 && age <= 13)
            {
                Console.WriteLine("child");
            }
            else if (age>13 && age<=19)
            {
                Console.WriteLine("teenager");
            }
            else if (age > 19 && age<= 65)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}
