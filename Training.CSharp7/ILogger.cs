namespace Training.CSharp7
{
    public interface ILogger
    {
        void Write(string message, params object[] args);
    }
}
