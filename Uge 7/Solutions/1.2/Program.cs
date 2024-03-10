namespace _1._2
{
    internal class Program
    {
        // Her har vi en funktion som giver vores program et nummer med data typen "int".
        static int GetIntValue()
        {
            int number;

            // Her lavet vi et "while loop" der stopper lige så snart brugeren skriver et tal I konsolen
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Fejl! Prøv igen");
            }

            return number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Indtast start X kordinat");

            // Her får vi starten på vores X
            int x1 = GetIntValue();

            Console.WriteLine("Indtast start Y kordinat");

            // Her får vi starten på vores Y
            int y1 = GetIntValue();

            Console.WriteLine("Indtast slut X kordinat");

            // Her får vi slutningen på vores X
            int x2 = GetIntValue();

            Console.WriteLine("Indtast slut Y kordinat");

            // Her får vi slutningen på vores Y
            int y2 = GetIntValue();


            Console.WriteLine("Hældningslinje er " + (y2-y1) / (x2-x1));

            /*
                 * Linjestykke 1: 0
                 * Linjestykke 2: 1
                 * Linjestykke 3: 0
            */
        }
    }
}
