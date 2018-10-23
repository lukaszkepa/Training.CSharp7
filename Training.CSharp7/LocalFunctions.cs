using System;
using System.Collections.Generic;
using System.Text;

namespace Training.CSharp7
{
    public class LocalFunctions
    {
        private readonly ILogger _logger;

        public LocalFunctions(ILogger logger) => _logger = logger;

        public IEnumerable<long> GetFibonacciSequence(long maxValue)
        {
            IEnumerable<long> result = new long[0];
            try
            {
                result = GetFibonacciSequenceInternal(maxValue);
            }
            catch (Exception e)
            {
                _logger.Write("GetFibonacciSequence ({0}): {1}", maxValue, e);
            }
            _logger.Write("GetFibonacciSequence ({0}): {1}", maxValue, string.Join(", ", result));
            return result;
        }

        private IEnumerable<long> GetFibonacciSequenceInternal(long maxValue)
        {
            if (maxValue < 1 || maxValue > long.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(maxValue), $"Maximum value must be between 1 and {long.MaxValue}.");
            }
            return getFibonacciSequence();

            IEnumerable<long> getFibonacciSequence()
            {
                long n2 = 1, n1 = 1;
                yield return n1;
                for (var at = n1; at <= maxValue; at = n2 + n1)
                {
                    yield return at;
                    n2 = n1;
                    n1 = at;
                }
            }
        }

        public long FindClosestFibonacciNumber(long number)
        {
            if (number < 1 || number > long.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(number), $"Maximum value must be between 1 and {long.MaxValue}.");
            }
            var fibNumber = getNextFibonacciNumber(1, 1);
            _logger.Write("FindClosestFibonacciNumber ({0}): {1}", number, fibNumber);
            return fibNumber;

            long getNextFibonacciNumber(long n2, long n1)
            {
                var at = n2 + n1;
                if (at > number)
                {
                    return n1;
                }
                return getNextFibonacciNumber(n1, at);
            };
        }
    }
}
