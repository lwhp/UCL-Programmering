namespace _1._3
{
    internal class Program
    {
        // Her har vi en funktion som giver vores program et nummer med data typen "double".
        static double GetIntValue()
        {
            double number;

            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Fejl! Prøv igen");
            }


            return number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Indtast start X kordinat");

            // Her får vi starten på vores X
            double x1 = GetIntValue();

            Console.WriteLine("Indtast start Y kordinat");

            // Her får vi starten på vores Y
            double y1 = GetIntValue();

            Console.WriteLine("Indtast slut X kordinat");

            // Her får vi slutningen på vores X
            double x2 = GetIntValue();

            Console.WriteLine("Indtast slut Y kordinat");

            // Her får vi slutningen på vores Y
            double y2 = GetIntValue();


            Console.WriteLine("Hældningslinje er " + (y2 - y1) / (x2 - x1));

            /*
                 * Linjestykke 1: 0
                 * Linjestykke 2: 1
                 * Linjestykke 3: 0,5

                 * Det vil sige at double værdien giver os decimaler (komma tal) værdier hvor opgave 1.2 kun giver os heltal
            */
        }
    }
}
