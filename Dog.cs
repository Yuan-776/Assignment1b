namespace Assignment1b
{
    /// <summary>
    /// Dog class that extends Pet and implements ITalkable
    /// </summary>
    public class Dog : Pet, ITalkable
    {
        private bool _friendly;

        public Dog(bool friendly, string name) : base(name)
        {
            _friendly = friendly;
        }

        public bool IsFriendly
        {
            get { return _friendly; }
        }

        public string Talk()
        {
            return "Bark";
        }

        public override string ToString()
        {
            return $"Dog: name={_name} friendly={_friendly}";
        }
    }
}