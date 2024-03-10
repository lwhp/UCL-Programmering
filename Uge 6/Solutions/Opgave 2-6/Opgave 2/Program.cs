using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Indtast Navn: ");

            string name = Console.ReadLine();

            // et navn skal være minimum på 1 karakter og kan ikke være et mellemrum
            while (name.Length < 1 || name == " ")
            {
                Console.WriteLine("\nDu skal indtaste dit navn!");
                Console.Write("Indtast Navn: ");
                name = Console.ReadLine();
            }

            Console.Write("Indtast Alder: ");

            int age;

            /* 
             * Her laver vi et while loop der sørger for at brugeren kun sender et string der kan laves om til et int (heltal)
             * derefter dobbelt checker vi at alderen ikke er mindre end 0
            */
            
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.WriteLine("Fejl! Indtast din alder!");

                Console.Write("Indtast Alder: ");
            }

            string ageType;

            // En general if statement der siger hvilke categori personen hører ind i. 
            if (age >= 0 && age <= 12)
                ageType = "et barn";
            else if (age > 12 && age <= 19)
                ageType = "en teenager";
            else if (age > 20 && age <= 25)
                ageType = "en studerende";
            else if (age > 25 && age <= 67)
                ageType = "i arbejde";
            else
                ageType = "en pensionist";


            Console.WriteLine($"{name} er {age} år gammel og er {ageType}");
            Console.ReadLine();
        }
    }
}
