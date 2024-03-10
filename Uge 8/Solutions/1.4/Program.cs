namespace _1._4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Indtast en tekst");
            string value = Console.ReadLine();

            Console.Clear();

            if (value != null && value.Length >= 6)
            {
                Console.WriteLine("Du skrev " + value);
                Console.WriteLine("Anden karakter: " + value[1] + " fjerde karakter: " + value[3] + " sjette karakter: " + value[5]);
            }
            else
                Main();
        }
    }
}
