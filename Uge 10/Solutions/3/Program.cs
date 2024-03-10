namespace _3
{
    internal class Program
    {
        static void Main()
        {
            Menu myMenu = new("Min flotte menu");

            Console.WriteLine(myMenu.Title);

            myMenu.AddMenuItem("UCL");
            myMenu.AddMenuItem("UCL2");
            myMenu.AddMenuItem("UCL3");
            myMenu.AddMenuItem("UCL4");
            myMenu.Show();

            bool shouldExit = myMenu.SelectMenuItem() == 0;

            if (!shouldExit)
            {
                Main();
            }
        }
    }
}
