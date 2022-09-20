using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = string.Empty;
            string tryPass;
            int tryngs = 0;
            for (int i = user.Length-1; i >= 0; i--)
            {
                char currCh = user[i];
                password += currCh;
            }
            
            
            
            while ((tryPass = Console.ReadLine()) != password)
            {
                tryngs++;
                if (tryngs >= 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                
            }
            if (tryPass == password)
            {
                Console.WriteLine($"User {user} logged in.");
            }
        }
    }
}
