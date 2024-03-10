using _1._2._2;

namespace _2
{
    internal class Program
    {

        public static int GetMenuPunkt()
        {
            string value = Console.ReadLine() ?? "";

            if (int.TryParse(value, out int i) && i > 0 && i < 5)
                return i;
            else
            {
                Console.WriteLine("FEJL, Vælg punkt 1-4!");
                return GetMenuPunkt();
            }
        }

        public static int GetNumberFromInput()
        {
            string value = Console.ReadLine() ?? "";

            if (int.TryParse(value, out int i))
                return i;
            else
            {
                Console.WriteLine("FEJL! " + value + " VAR IKKE ET HELTAL!");
                return GetNumberFromInput();
            }
        }

        static void Main(string[] args)
        {
            string restart = "";
            do
            {
                Console.Clear();

                Console.WriteLine("Vælg et menupunkt: \n" + 
                    "1. Plus to numre sammen \n" + 
                    "2. Minus to numre sammen \n" + 
                    "3. Gange to numre sammen \n" +
                    "4. Divider to numre sammen");

                int menuPunkt = GetMenuPunkt();

                Console.Clear();

                Console.WriteLine("Indtast dit første nummer");
                int number = GetNumberFromInput();

                Console.WriteLine("Indtast dit andet nummer");
                int number2 = GetNumberFromInput();

                Console.Clear();

                double total = 0;
                string currentOperator = "";

                switch(menuPunkt)
                {
                    case 1:
                        total = Lommeregner.Add(number, number2);
                        currentOperator = "+";
                        break;
                    case 2:
                        total = Lommeregner.Substract(number, number2);
                        currentOperator = "-";
                        break;
                    case 3:
                        total = Lommeregner.Multiply(number, number2);
                        currentOperator = "*";
                        break;
                    case 4:
                        total = Lommeregner.Divide(number, number2);
                        currentOperator = "/";
                        break;
                }

                Console.WriteLine($"{number} {currentOperator} {number2} = {total}");


                Console.SetCursorPosition(0, 4);

                Console.WriteLine("Tryk enter for at exite programmet eller restart for at skrive et nyt regnestykke!");
                restart = Console.ReadLine() ?? "";
            } while (restart != "");
        }
    }
}
