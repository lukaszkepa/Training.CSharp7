using System;

namespace Training.CSharp7
{
    public class ExpressionBodiedMembers
    {
        private ILogger _logger;

        public ExpressionBodiedMembers(ILogger logger) => _logger = logger;

        ~ExpressionBodiedMembers() => _logger.Write("{0} is finalized!", nameof(ExpressionBodiedMembers));

        public void Log(string message) => _logger.Write(message);

        public ILogger Logger
        {
            get => _logger;
            set => _logger = value ?? throw new ArgumentNullException(nameof(Logger));
        }
    }
}
