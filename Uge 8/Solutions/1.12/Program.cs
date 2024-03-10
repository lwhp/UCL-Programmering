namespace _1._13
{
    internal class Program
    {
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
                default:
                    return 0;
            }
        }

        static void Main()
        {
            string input = Console.ReadLine();

            string stringNumber = "";
            string stringNumber2 = "";
            string regneStykke = "";
            string stringOperator = "";

            int result = 0;


            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (char.IsNumber(c))
                {
                    if (stringOperator.Length > 0)
                        stringNumber2 += c;
                    else
                        stringNumber += c;

                    regneStykke += c;
                }

                else if ((c == '+' || c == '-') && stringNumber.Length > 0)
                {
                    if (stringOperator.Length > 0 && stringNumber2.Length > 0)
                    {
                        result = CalculateResult(stringNumber, stringNumber2, stringOperator);
                        stringNumber = result.ToString();
                        stringNumber2 = "";
                        stringOperator = "";
                    }
                    stringOperator += c;
                    regneStykke += c;
                }

            }

            result = CalculateResult(stringNumber, stringNumber2, stringOperator);

            Console.WriteLine(regneStykke + " = " + result);
        }
    }
}
