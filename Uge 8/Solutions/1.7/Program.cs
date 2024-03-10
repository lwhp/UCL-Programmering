namespace _1._7
{
    internal class Program
    {

        static int GetIntFromInput()
        {
            int result = 0;
            while (!int.TryParse(Console.ReadLine(), out result))
                Console.WriteLine("Fejl! Skriv kun et heltal");

            return result;
        }

        static void Main(string[] args)
        {
            // Indlæse det første heltal
            Console.WriteLine("Indtast det første heltal:");
            int a = GetIntFromInput();

            // Indlæse det andet heltal
            Console.WriteLine("Indtast det andet heltal:");
            int b = GetIntFromInput();

            // her beregner vi vores variabler
            int kvotient = a / b;
            int rest = a % b;

            // Udskriv kvotient og rest værdien
            Console.WriteLine("Heltalskvotienten er: " + kvotient + "\n" + "Rest-delen er: " + rest);
        }
    }
}