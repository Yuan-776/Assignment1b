namespace Assignment1b
{
    /// <summary>
    /// Cat class that extends Pet and implements ITalkable
    /// </summary>
    public class Cat : Pet, ITalkable
    {
        private int _mousesKilled;

        public Cat(int mousesKilled, string name) : base(name)
        {
            _mousesKilled = mousesKilled;
        }

        public int MousesKilled
        {
            get { return _mousesKilled; }
        }

        public void AddMouse()
        {
            _mousesKilled++;
        }

        public string Talk()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return $"Cat: name={_name} mousesKilled={_mousesKilled}";
        }
    }
}