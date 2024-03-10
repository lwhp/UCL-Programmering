namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast en tilfældig tekst");

            // et variable der gemmer brugerens input
            string randomText = Console.ReadLine();

            // Vi tjekker at teksten ikke er null
            if (randomText != null)
                // Her udskriver vi tekstens længde til brugeren
                Console.WriteLine("Længden på din tekst er: " + (randomText.Length));
        }
    }
}
