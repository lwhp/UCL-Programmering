namespace _1._4
{
    internal class Program
    {
        static int GetNumberFromInput(string input)
        {
            if (!int.TryParse(input, out int result) || result < 0)
            {
                Console.WriteLine("ERROR! Try Again!");

                return GetNumberFromInput(Console.ReadLine() ?? "");
            }

            return result;
        }

        static void AssignNamesAndAge(People[] peoples)
        {
            for (int i = 0; i < peoples.Length; i++)
            {
                Console.WriteLine("Hvad er navnet på person " + (i + 1));
                string name = Console.ReadLine() ?? "";
                Console.WriteLine("Hvad er Alderen på person " + (i + 1));
                int age = GetNumberFromInput(Console.ReadLine() ?? "");

                peoples[i] = new(name, age);
                Console.Clear();
            }
        }

        static void Main()
        {
            Console.WriteLine("Hvor mange personer?");
            int amountOfPeople = GetNumberFromInput(Console.ReadLine() ?? "");

            Console.Clear();

            People[] peoples = new People[amountOfPeople];

            AssignNamesAndAge(peoples);

            Console.Write("Alder du gerne vil finde: ");
            int findAge = GetNumberFromInput(Console.ReadLine() ?? "");

            bool foundAge = false;
            int sumAge = 0;

            foreach (People people in peoples)
            {
                int currentAge = people.Age;

                Console.WriteLine(people.Name + " er " + currentAge + " År Gammel");
                sumAge += currentAge;

                if (findAge == currentAge)
                {
                    Console.WriteLine("Du fandt " + people.Name + " med alderen " + findAge + "!");
                    foundAge = true;
                    break;
                }
            }

            if (!foundAge)
            {
                Console.WriteLine("Gennemsnits alderen er " + (sumAge / peoples.Length));
            }
        }
    }
}
