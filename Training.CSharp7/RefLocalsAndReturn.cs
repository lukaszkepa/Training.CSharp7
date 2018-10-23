using System;

namespace Training.CSharp7
{
    public class RefLocalsAndReturn
    {
        private readonly ILogger _logger;

        public RefLocalsAndReturn(ILogger logger) => _logger = logger;

        public void Replace(string[] values, Func<string, bool> predicate, string newValue)
        {
            ref var item = ref FindItem(values, predicate);
            var oldValue = item;
            item = newValue;
            _logger.Write("Replace: replaced value '{0}' to '{1}'. New text: '{2}'",
                oldValue, newValue, string.Join("", values));
        }

        public ref string FindItem(string[] values, Func<string, bool> predicate)
        {
            for (var i = 0; i < values.Length; i++)
            {
                if (predicate(values[i]))
                {
                    _logger.Write("FindIndex: found value '{0}' at index {1}", values[i], i);
                    return ref values[i];
                }
            }
            throw new InvalidOperationException("FindIndex: didn't find anything.");
        }
    }
}
