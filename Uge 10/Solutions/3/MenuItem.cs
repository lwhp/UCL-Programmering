namespace _3
{
    public class MenuItem
    {
        public string Title;
        private MenuItem[] menuItems = new MenuItem[30];
        public int MenuCount = 0;

        public MenuItem(string title)
        {
            Title = title;            
        }
    }
}
