using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice= double.Parse(Console.ReadLine());
            double displayPrice= double.Parse(Console.ReadLine());
            

            
               int  headsetCnt = lostGames / 2;
            int mouseCnt = lostGames / 3;
            int keyboardcCnt = lostGames / 6;
            int displayCnt = lostGames / 12;
            double price = headsetPrice * headsetCnt + mousePrice * mouseCnt + keyboardPrice * keyboardcCnt + displayPrice * displayCnt;
            Console.WriteLine($"Rage expenses: {price:f2} lv.");



        }
    }
}
