namespace _1._1
{
    internal class Program
    {

        // Her har vi en funktion som giver vores program et nummer med data typen "double".
        static double GetDoubleValue()
        {
            double number;

            // Her lavet vi et "while loop" der stopper lige så snart brugeren skriver et tal I konsolen
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Fejl! Prøv igen");
            }


            return number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Indtast Højden på din rektangel");

            // Her får vi width "bredden" på vores rektangel
            double width = GetDoubleValue();

            Console.WriteLine("Indtast Højden på din rektangel");
            // Her får vi height "højden" på vores rektangel
            double height = GetDoubleValue();

            // Her laver vi en string concatination som udskriver vores areal på rektanglen
            Console.WriteLine("Arealet på din rektangel er " + (height * width));
        }
    }
}
