using System;
using System.Collections.Generic;
using System.Text;

namespace Training.CSharp7
{
    public class RefSemantics
    {
        private readonly ILogger _logger;
        public RefSemantics(ILogger logger) => _logger = logger;

        public long SumAreas(in Rectangle rect1, in Rectangle rect2)
        {
            var sum = rect1.Area + rect2.Area;
            _logger.Write("SumAreas: two rectangles areas equals {0}", sum);
            return sum;
        }

        private Rectangle _rectangle = new Rectangle(10, 10);
        public ref readonly Rectangle Rectangle => ref _rectangle;
    }

    public struct Rectangle
    {
        public Rectangle(long a, long b)
        {
            A = a;
            B = b;
        }

        public long A { get; set; }
        public long B { get; set; }
        public long Area { get => A * B; }
    }
}
