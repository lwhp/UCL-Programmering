using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Menu(string title)
    {
        public string Title = title;
        private MenuItem[] _menuItems = new MenuItem[30];
        private int _itemCount = 0;

        public void Show()
        {
            Console.WriteLine($"{Title} \n");

            for (int i = 0; i < _itemCount; i++)
            {
                Console.WriteLine($"  {(i + 1)} {_menuItems[i].Title}");
            }

            Console.WriteLine("\n(Tryk menupunkt eller 0 for at afslutte)");
        }

        public void AddMenuItem(string menuTitle)
        {
            _menuItems[_itemCount] = new MenuItem(menuTitle);
            _itemCount++;
        }

        public int SelectMenuItem()
        {
            if (int.TryParse(Console.ReadLine(), out int i))
            {
                if (i == 0)
                {
                    return 0;
                }

                Console.WriteLine(_menuItems[i - 1].Title);
                return i;
            }

            return SelectMenuItem();
        }
    }
}
