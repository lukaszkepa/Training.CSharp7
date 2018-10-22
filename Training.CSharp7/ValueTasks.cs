using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp7
{
    public class ValueTasks
    {
        private readonly ILogger _logger;
        private IEnumerable<string> _cachedValues;

        public ValueTasks(ILogger logger)
        {
            _logger = logger;
        }

        public async Task<IEnumerable<string>> GetValues()
        {
            if (_cachedValues == null)
            {
                _logger.Write("GetValues: values loaded from outside.");
                return await LoadValues();
            }
            _logger.Write("GetValues: values loaded from cache.");
            return _cachedValues;
        }

        private async Task<IEnumerable<string>> LoadValues()
        {
            await Task.Delay(100);
            _cachedValues = new[] { "cy", "ber", "com" };
            return _cachedValues;
        }
    }
}
