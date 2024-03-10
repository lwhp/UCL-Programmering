using System.Linq;

namespace _1._10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] Numbers = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];
            Console.WriteLine("Skriv en tilfældig tekst");
            string value = Console.ReadLine();

            if (value != null)
            {

                for (int i = 0; i < value.Length; i++)
                {
                    char character = value[i];

                    // Contains bruger en string og vi har en char så her konvertere vi den
                    if (Numbers.Contains(character.ToString()))
                        Console.WriteLine("<" + i + ">: " + character);
                }
            }
        }
    }
}
