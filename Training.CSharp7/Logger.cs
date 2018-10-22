using System;

namespace Training.CSharp7
{
    public class Logger : ILogger
    {
        public void Write(string message, params object[] args) => Console.WriteLine(message, args);
    }
}
