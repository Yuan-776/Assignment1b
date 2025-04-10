namespace Assignment1b
{
    /// <summary>
    /// Teacher class that extends Person and implements ITalkable
    /// </summary>
    public class Teacher : Person, ITalkable
    {
        private int _age;

        public Teacher(int age, string name) : base(name)
        {
            _age = age;
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Talk()
        {
            return "Don't forget to do the assigned reading!";
        }
    }
}   