namespace Opgave_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // En simple menu der viser brugeren hvad de kan vælge imellem
            Console.WriteLine("Min fantastiske menu: \n" +
                "1. Gør dit\n" +
                "2. Gør dat\n" +
                "3. Gør noget\n" +
                "4. Få svaret på livet, universet og alting\n");

            // Her giver vi instruktioner til brugeren med hvad de kan vælge.
            Console.WriteLine("Tryk menupunkt 1, 2, 3 eller 4");

            // Her gemmer vi vores variable "selection" der skal gemme hvad brugeren har valgt
            int selection;

             /*
                 * Her køre vi et "while loop" der prøver at konvertere vores string til et int (heltal)
                 * efter vores string er blevet lavet over til et int, tjekker vi at numeret er mellem 1 or 4 
             */
            while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > 4)
            {
                Console.WriteLine("Fejl! Der er kun 4 valmulighed.");
            }

            string message = "";

            // Her lavet vi et if statement der skriver en besked ud fra hvad brugeren er valgt

            if (selection == 1)
            {
                message = "Gør dig";
            }
            else if (selection == 2)
            {
                message = "Gør dat";
            }
            else if (selection == 3)
            {
                message = "Gør noget";
            }
            else if (selection == 4)
            {
                message = "42";
            }

            // Her viser vi brugeren hvilken menu de har valgt og hvilken besked der var gemt
            Console.WriteLine($"Punkt {selection} er valgt: {message}");
        }
    }
}
