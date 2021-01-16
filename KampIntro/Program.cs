using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            string categoryLabel = "Kategori";
            Console.WriteLine(categoryLabel);

            int studentCount = 32000;
            double interestRate = 1.45;

            bool isLogin = true;

            if (isLogin)
            {
                Console.WriteLine("Login is success.");
            }
            else
            {
                Console.WriteLine("Login failed.");
            }

            double dollarYesterday = 7.35;
            double dollarToday = 7.45;
            if (dollarYesterday>dollarToday)
            {
                Console.WriteLine("Down arrow");
            }
            else if (dollarYesterday<dollarToday)
            {
                Console.WriteLine("Up arrow");
            }
            else
            {
                Console.WriteLine("Hyphen");
            }
        }
    }
}
