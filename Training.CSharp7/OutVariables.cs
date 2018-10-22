using System.Collections.Generic;

namespace Training.CSharp7
{
    public class OutVariables
    {
        private readonly ILogger _logger;

        public OutVariables(ILogger logger)
        {
            _logger = logger;
        }

        public int ParseInt(string s)
        {
            int result;
            if (!int.TryParse(s, out result))
            {

                _logger.Write("TryParse: not a number '{0}'.", s);
            }
            else
            {
                _logger.Write("TryParse: {0}.", result);
            }
            return result;
        }

        public string GetValue(string key)
        {
            var data = new Dictionary<string, string>
            {
                ["key1"] = "value1",
                ["key2"] = "value2",
            };
            string result;
            if (!data.TryGetValue(key, out result))
            {
                _logger.Write("GetValue: cannot find a value under key '{0}'.", key);
            }
            else
            {
                _logger.Write("GetValue: {0}", result);
            }
            return result;
        }
    }
}
