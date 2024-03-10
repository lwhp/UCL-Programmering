using System.ComponentModel.Design;

namespace _1._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] opertaors = ["+", "-"];
            string[] Numbers = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];
            Console.WriteLine("Skriv en tilfældig tekst");
            string value = Console.ReadLine();

            for (int i = 0; i < value.Length; i++)
            {
                char character = value[i];

                string charString = character.ToString();

                // Contains bruger en string og vi har en char så her konvertere vi den
                if (opertaors.Contains(charString))
                    Console.WriteLine("<" + i + ">: " + character + " (operator)");
                else if (Numbers.Contains(charString))
                    Console.WriteLine("<" + i + ">: " + character + " (ciffer)");
                else
                    Console.WriteLine("<" + i + ">: " + character + " (ukendt)");
            }
        }
    }
}
