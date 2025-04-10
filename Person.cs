namespace Assignment1b
{
    /// <summary>
    /// Abstract base class for all person objects
    /// </summary>
    public abstract class Person
    {
        private string _name;

        public Person(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}