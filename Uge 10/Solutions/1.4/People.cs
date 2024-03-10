namespace _1._4
{
    public class People
    {
        private int _age;
        private string _name;

        public string Name { get { return _name; } }
        public int Age { get { return _age; } }


        public People(string name, int age) {
            _age = age;
            _name = name;
        }
    }
}
