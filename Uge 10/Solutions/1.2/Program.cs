namespace _1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People[] peoples = [new("Laurids", 18), new("Line", 19), new("Lucas", 20), new("Lars", 21), new("Troels", 22), new("Mads", 23), new("Maria", 24)];

            int sumAge = 0;
            foreach (People people in peoples)
            {
                Console.WriteLine(people.Name + " er " + people.Age + " År Gammel");
                sumAge += people.Age;
            }

            Console.WriteLine("Gennemsnits alderen er " + (sumAge / peoples.Length));
        }
    }
}
