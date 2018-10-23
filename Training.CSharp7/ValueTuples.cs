using System;
using System.Collections.Generic;
using System.Linq;

namespace Training.CSharp7
{
    public class ValueTuples
    {
        private readonly ILogger _logger;

        public ValueTuples(ILogger logger)
        {
            _logger = logger;
        }

        public long GetFibonacciSquaresArea(int numberOfSquares)
        {
            var squares = GetFibonacciSquares(numberOfSquares);
            var sumAreas = squares.Sum(sq => sq.area);
            _logger.Write("GetFibonacciSquaresArea: total area of {0} squares equals {1:n}", numberOfSquares, sumAreas);
            return sumAreas;
        }

        public long GetFibonacciSquareAreaById(int id)
        {
            var (_, _, area) = GetFibonacciSquareById(id);
            _logger.Write("GetFibonacciSquareAreaById: area of square {0} equals {1:n}", id, area);
            return area;
        }

        private IEnumerable<(int id, long side, long area)> GetFibonacciSquares(int numberOfSquares)
        {
            long n2 = 1, n1 = 1, side = n1;
            var id = 1;
            yield return (id++, side, side * side);
            do
            {
                yield return (id++, side, side * side);
                side += n2;
                n2 = n1;
                n1 = side;
            }
            while (id <= numberOfSquares);
        }

        private (int id, long side, long area) GetFibonacciSquareById(int id)
        {
            long n2 = 1, n1 = 1, side = n1;
            var currentId = 1;
            do
            {
                side += n2;
                n2 = n1;
                n1 = side;
                currentId++;
            }
            while (currentId <= id);
            return (id, side, side * side);
        }

        private struct Square
        {
            public Square(int id, long side, long area)
            {
                Id = id;
                Side = side;
                Area = area;
            }

            public int Id { get; }
            public long Side { get; }
            public long Area { get; }

            public void Deconstruct(out int id, out long side, out long area)
            {
                id = Id;
                side = Side;
                area = Area;
            }
        }
    }
}
