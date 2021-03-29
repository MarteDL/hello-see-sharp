using System;
using System.Globalization;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Hello {name}, when were you born? (YYYY/MM/DD)");
            
            var inputDate = Console.ReadLine();
            var birthDate = DateTime.Parse(inputDate);

            var age = GetAge(birthDate);

            Console.WriteLine($"So you were born on {birthDate.ToString("dd MMMM yyyy", new CultureInfo("en-GB"))}.");
            
            if (age >= 30)
            {
                Console.WriteLine($"Wooow, that means that you are {age} years old already. Here come the grey hairs!");
            }
            else if (age >= 25)
            {
                Console.WriteLine($"Oh, that means that you are {age} years old... Nice! Enjoy your twenties while you still can. The big three-oh is comin' for you ;-)");
            }
            else
            {
                Console.WriteLine($"No way, that means that you are only {age} years old?! #babyface #doesyourmamaknowthatyouareout");
            }
            // 
        }

        static int GetAge(DateTime birthDate)
        {
            var currentDate = DateTime.Now; 
            var age = currentDate.Year - birthDate.Year;

            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
                age--;

            return age;
            
        }
        
    }
}