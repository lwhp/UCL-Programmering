namespace _1._5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Skriv en tilfældig tekst");
            string value = Console.ReadLine();


            int characterInt = 0;

            if (value != null)
            {
                while (characterInt != value.Length)
                {
                    char character = value[characterInt];
                    Console.WriteLine(character);
                    characterInt++;
                }
            }
        }
    }
}
