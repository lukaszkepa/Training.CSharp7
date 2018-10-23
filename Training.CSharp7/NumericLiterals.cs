using System.Linq;

namespace Training.CSharp7
{
    public class NumericLiterals
    {
        private readonly ILogger _logger;

        public NumericLiterals(ILogger logger) => _logger = logger;

        public int Sum()
        {
            var one = 0b0001;
            var two = 2;
            var four = 0b0100;
            var eighteen = 0b0001_0010;
            var tenThousands = 10_000;

            var sum = new[] { one, two, four, eighteen, tenThousands }.Sum();
            _logger.Write("Sum: differently written, but still the same: {0}", sum);
            return sum;
        }
    }
}
