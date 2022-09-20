using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int cntStudents = int.Parse(Console.ReadLine());
            double priceSaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
            int promotionBelt = 0;
            
            double priceAllSaber = priceSaber * (cntStudents + Math.Ceiling(cntStudents * 0.1));
           
            if (cntStudents>=6)
            {
                promotionBelt = cntStudents / 6;
                
            }
            double priceAllRobe = priceRobe * cntStudents;
            double priceAllBelts = priceBelt * (cntStudents - promotionBelt);
            double AllPrice = priceAllSaber + priceAllRobe + priceAllBelts;
            if (AllPrice <= budget)
            {
                
                Console.WriteLine($"The money is enough - it would cost {AllPrice:f2}lv.");
            }
            else
            {
                double diff = AllPrice - budget;
                Console.WriteLine($" John will need {diff:f2}lv more.");
            }

            
        }
    }
}
