namespace _1._13
{
    internal class Program
    {
        // Metode til at udregne vores regnestykke efter 2 værdier og en operator
        static int CalculateResult(string number1, string number2, string operatorString)
        {
            int intNumber1 = int.Parse(number1);
            int intNumber2 = int.Parse(number2);

            switch (operatorString)
            {
                case "+":
                    return intNumber1 + intNumber2;
                case "-":
                    return intNumber1 - intNumber2;
                case "*":
                    return intNumber1 * intNumber2;
                case "/":
                    return intNumber1 / intNumber2;
                default:
                    return 0;
            }
        }

        static void FormatRegnestykke(int index, string operatorString, List<string> regnstykke)
        {
            int currentValue = CalculateResult(regnstykke[index - 1], regnstykke[index + 1], operatorString);
            regnstykke.RemoveAt(index + 1);
            regnstykke.RemoveAt(index);
            regnstykke[index - 1] = currentValue.ToString();
        }

        static void Main()
        {
            Console.Write("Skriv et regnstykke: ");
            string input = Console.ReadLine();

            // Vi initialiserer en liste med data typen string
            List<string> regnstykke = new List<string>();

            string numbers = "";

            // Gemmer vi en string værdi, der håndtere hele vores regnestykke som en string som vi kan vise til brugeren
            string visualRegnestykke = "";

            // For loop der skanner efter tal og operatore som bygger vores liste
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (char.IsNumber(c))
                {
                    numbers += c;
                    visualRegnestykke += c;
                }
                else if ((c == '*' || c == '/' || c == '+' || c == '-') && numbers.Length > 0) 
                {
                    regnstykke.Add(numbers);
                    numbers = "";
                    regnstykke.Add(c.ToString());
                    visualRegnestykke += c;
                }
            }

            // If statement efter vores for loop for at sikre vi får det sidste tal med
            if (numbers.Length > 0)
                regnstykke.Add(numbers);

            // For loop der kører 3 gange som skanner efter gange, division, plus og minus
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < regnstykke.Count; i++)
                {
                    string listValue = regnstykke[i];

                    // Her tjekker vi vores list value for operatore og prioriteten på index j
                    if ((listValue == "*" && j == 0) || (listValue == "/" && j == 1) || ((listValue == "+" || listValue == "-") && j == 2))
                        FormatRegnestykke(i, listValue, regnstykke);
                }
            }

            Console.Clear();

            // her udskriver vi så vores regnestykke resultat
            Console.WriteLine(visualRegnestykke + " = " + regnstykke[0]);

            Console.Write("Vil du skrive et ny regnestykke? ");

            if (Console.ReadLine() == "ja")
            {
                Console.Clear();
                Main();
            }
            
        }
    }
}
