using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {

            string command;
            double sum = 0;
            while ((command = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(command);
                if (coins == 2 || coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }
            string product;
            while ((product = Console.ReadLine()) != "End")
            {
                if (product == "Nuts" || product == "Coke" || product == "Water" || product == "Crisps" || product == "Soda")
                {


                    if (product == "Nuts" && sum >= 2)
                    {
                        sum -= 2;
                        Console.WriteLine($"Purchased nuts");
                    }
                    else if (product == "Nuts" && sum < 2)
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                    if (product == "Coke" && sum >= 1)
                    {
                        sum -= 1;
                        Console.WriteLine($"Purchased coke");
                    }
                    else if (product == "Coke" && sum < 1)
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                    if (product == "Water" && sum >= 0.7)
                    {
                        sum -= 0.7;
                        Console.WriteLine($"Purchased water");
                    }
                    else if (product == "Water" && sum < 0.7)
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                    if (product == "Crisps" && sum >= 1.5)
                    {
                        sum -= 1.5;
                        Console.WriteLine($"Purchased crisps");
                    }
                    else if (product == "Crisps" && sum < 1.5)
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                    if (product == "Soda" && sum >= 0.8)
                    {
                        sum -= 0.8;
                        Console.WriteLine($"Purchased soda");
                    }
                    else if (product == "Soda" && sum < 0.8)
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }

                }
                else
                {
                    Console.WriteLine($"Invalid product");
                }
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}