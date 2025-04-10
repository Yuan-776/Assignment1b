namespace Assignment1b
{
    /// <summary>
    /// Abstract base class for all pet objects
    /// </summary>
    public abstract class Pet
    {
        protected string _name;

        public Pet(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}