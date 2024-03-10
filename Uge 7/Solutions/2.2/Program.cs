using System.Xml.Xsl;

namespace _2._2
{
    internal class Program
    {
        /*
            * Her er vores function der hedder "GetConsoleText" der giver os en string værdi
            * Vi laver nogle checks for at være sikker på at det er noget tekst vi vil have
        */
        static string GetConsoleText()
        {
            string consoleText = "";

            while (consoleText.Length == 0)
            {
                string text = Console.ReadLine();

                if (text != null && text.Length > 0)
                    consoleText = text;
                else
                    Console.WriteLine("Fejl! Prøv igen");
            }

            // Her sikre vi os at alt teksten er lower case
            return consoleText.ToLower();
        }

        static void Main(string[] args)
        {
            Console.Write("Skriv det ord du vil finde i en tekst: ");

            // Her gemmer vi en variable med den tekst brugeren prøver at finde
            string findWord = GetConsoleText();

            Console.WriteLine("Skriv en besked med det ord du skrev før og se magien!");

            // Her gemmer vi en variable med alt den teskt computeren skal process og gøre noget ved.
            string message = GetConsoleText();

            // Her prøver vi at finde positionen af vores findWord variable
            int textPosition = message.IndexOf(findWord);

            // Hvis position er større end 0 (altså det faktisk findes i vores tekst)
            if (textPosition > 0)
            {
                // Her siger vi så fra karakteren (textPosition) og antal ord frem skal vi bruge
                string textFound = message.Substring(textPosition, findWord.Length);

                // Til sidst fortæller vi brugeren at vi fandt teksten og hvor henne
                Console.WriteLine($"Vi fandt teksten {textFound} {textPosition} karaktere inde i din tekst");
            }
            else
                // her har vi en lille "error" besked med at vi ikke kunne finde deres ord/sætning I teksten
                Console.WriteLine($"Vi kunne ikke finde ordet {findWord} I din tekst");
        }
    }
}
