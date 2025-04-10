namespace Assignment1b
{
    /// <summary>
    /// Interface for objects that can talk
    /// </summary>
    public interface ITalkable
    {
        string Talk();
        string Name { get; }
    }
}