using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.CSharp7
{
    public class PatternMatching
    {
        private readonly ILogger _logger;

        public PatternMatching(ILogger logger) => _logger = logger;

        public int ParseInt(string s)
        {
            int result = 0;
            try
            {
                result = int.Parse(s);
            }
            catch (Exception e)
            {
                if (e is ArgumentNullException)
                {
                    _logger.Write("ParseInt: ArgumentNullException has been thrown. Exception: {0}", e);
                }
                else if (e is FormatException formatEx)
                {
                    _logger.Write("ParseInt: FormatException has been thrown. Exception: {0}", formatEx);
                }
                else
                {
                    _logger.Write("ParseInt: Exception has been thrown. Exception: {0}", e);
                }
            }
            return result;
        }

        public string JoinString(string separator, params object[] values)
        {
            var filteredValues = new List<string>(values.Length);
            foreach (var item in values)
            {
                switch (item)
                {
                    case string s:
                        filteredValues.Add(s);
                        break;
                    case IEnumerable<string> multiS when multiS.Any():
                        filteredValues.Add(string.Join(string.Empty, multiS));
                        break;
                    case null:
                        _logger.Write("Join String: ingnored null");
                        break;
                    default:
                        _logger.Write("Join String: skipping not supported value '{0}'", item);
                        break;
                }
            }
            var result = string.Join(separator, filteredValues);
            _logger.Write("Join String: {0}", result);
            return result;
        }
    }
}
