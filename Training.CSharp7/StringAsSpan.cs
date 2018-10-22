using System;
using System.Diagnostics;

namespace Training.CSharp7
{
    public class StringAsSpan
    {
        private readonly ILogger _logger;

        public StringAsSpan(ILogger logger)
        {
            _logger = logger;
        }

        public bool IsNullOrEmpty(string s)
        {
            bool nullOrEmpty;

            var sw = Stopwatch.StartNew();
            nullOrEmpty = string.IsNullOrEmpty(s);
            sw.Stop();

            _logger.Write("IsNullOrEmpty: '{0}' => {1}. Completed in {2}.", s, nullOrEmpty, sw.Elapsed);

            sw.Restart();
            nullOrEmpty = s.AsSpan().IsEmpty;
            sw.Stop();

            _logger.Write("IsNullOrEmpty: '{0}'.AsSpan() => {1}. Completed in {2}.", s, nullOrEmpty, sw.Elapsed);

            return nullOrEmpty;
        }

        public string ToUpper(string s)
        {
            string result;

            var sw = Stopwatch.StartNew();
            result = s.ToUpper();
            sw.Stop();

            _logger.Write("ToUpper: '{0}' => '{1}'. Completed in {2}.", s, result, sw.Elapsed);

            sw.Restart();
            Span<char> sUpper = stackalloc char[s.Length];
            s.AsSpan().ToUpperInvariant(sUpper);
            result = sUpper.ToString();
            sw.Stop();

            _logger.Write("ToUpper: '{0}'.AsSpan() => '{1}'. Completed in {2}.", s, result, sw.Elapsed);

            return result;
        }
    }
}
