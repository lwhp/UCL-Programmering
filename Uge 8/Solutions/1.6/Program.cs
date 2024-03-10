namespace _1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en tilfældig tekst");
            string value = Console.ReadLine();


            int characterInt = 0;

            if (value != null)
            {
                do {
                    char character = value[characterInt];
                    Console.WriteLine(character);
                    characterInt++;
                } while (characterInt != value.Length);
            }
        }
    }
}
