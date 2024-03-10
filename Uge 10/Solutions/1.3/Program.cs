namespace _1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People[] peoples = [new("Laurids", 18), new("Line", 19), new("Lucas", 20), new("Lars", 21), new("Troels", 22), new("Mads", 23), new("Maria", 24)];

            int findAge = 20;
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
