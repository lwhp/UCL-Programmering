using System;
using System.Threading;

namespace _1._8
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Min fantastiske menu: \n" +
            "1. Gør dit\n" +
            "2. Gør dat\n" +
            "3. Gør noget\n" +
            "4. Få svaret på livet, universet og alting\n" + 
            "5. Afslut programmet");

            // Her giver vi instruktioner til brugeren med hvad de kan vælge.
            Console.WriteLine("Tryk menupunkt 1, 2, 3, 4 eller 5");

            // Her gemmer vi vores variable "selection" der skal gemme hvad brugeren har valgt
            int selection;

            /*
                * Her køre vi et "while loop" der prøver at konvertere vores string til et int (heltal)
                * efter vores string er blevet lavet over til et int, tjekker vi at numeret er mellem 1 or 4 
            */
            while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > 5)
            {
                Console.WriteLine("Fejl! Der er kun 5 valmulighed.");
            }

            string message = "";

            // Her bruger vi en switch case med de 4 valgmuligheder
            switch (selection)
            {
                case 1:
                    message = "Gør dig";
                    break;
                case 2:
                    message = "Gør dat";
                    break;
                case 3:
                    message = "Gør noget";
                    break;
                case 4:
                    message = "42";
                    break;
                case 5:
                    break;
            }


            if (message == "")
                return;

            // Her viser vi brugeren hvilken menu de har valgt og hvilken besked der var gemt
            Console.WriteLine($"Punkt {selection} er valgt: {message}");

            Thread.Sleep(1500);
            Console.Clear();

            Main();
        }
    }
}
