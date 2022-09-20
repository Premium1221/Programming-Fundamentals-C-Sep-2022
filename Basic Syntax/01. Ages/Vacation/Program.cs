using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = cntPeople * 8.45;
                            break;
                        case "Saturday":
                            price = cntPeople * 9.80;
                            break;
                        case "Sunday":
                            price = cntPeople * 10.46;
                            break;
                        default:
                            break;
                    }
                    if (cntPeople>=30)
                    {
                        price -= price * 0.15;
                    }
                    break;
                default:
                    break;
                case "Business":
                    if (cntPeople>=100)
                    {
                        cntPeople -= 10;
                    }
                    switch (day)
                    {
                        case "Friday":
                            price = cntPeople * 10.90;
                            break;
                        case "Saturday":
                            price = cntPeople * 15.60;
                            break;
                        case "Sunday":
                            price = cntPeople * 16;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = cntPeople * 15;
                            break;
                        case "Saturday":
                            price = cntPeople * 20;
                            break;
                        case "Sunday":
                            price = cntPeople * 22.50;
                            break;
                        default:
                            break;
                    }
                    if (cntPeople>= 10 && cntPeople<=20)
                    {
                        price -= price * 0.05;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");

        }
    }
}
