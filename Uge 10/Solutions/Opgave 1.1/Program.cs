namespace Opgave_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People person1 = new("Laurids", 18);
            People person2 = new("Line", 19);
            People person3 = new("Lucas", 20);
            People person4 = new("Lars", 21);
            People person5 = new("Troels", 22);
            People person6 = new("Mads", 23);
            People person7 = new("Maria", 24);


            Console.WriteLine(person1.Name + " er " + person1.Age + " År Gammel");
            Console.WriteLine(person2.Name + " er " + person2.Age + " År Gammel");
            Console.WriteLine(person3.Name + " er " + person3.Age + " År Gammel");
            Console.WriteLine(person4.Name + " er " + person4.Age + " År Gammel");
            Console.WriteLine(person5.Name + " er " + person5.Age + " År Gammel");
            Console.WriteLine(person6.Name + " er " + person6.Age + " År Gammel");
            Console.WriteLine(person7.Name + " er " + person7.Age + " År Gammel");

            int gennemsnit = (person1.Age + person2.Age + person3.Age + person4.Age + person5.Age + person6.Age + person7.Age) / 7; 

            Console.WriteLine("Gennemsnits Alderen: " + gennemsnit);
        }
    }
}
