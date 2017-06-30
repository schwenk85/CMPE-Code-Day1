using System.Collections.Generic;

namespace Dip
{
    public class ServerLogFileParser
    {
        private readonly ILog log;

        public ServerLogFileParser(ILog log)
        {
            this.log = log;
        }

        public List<string> GetErrors()
        {
            var errors = new List<string>();
            foreach (var logEntry in log.LoadLogEntries())
            {
                if (logEntry.Type == LogType.Error)
                {
                    errors.Add(logEntry.Message);
                }
            }
            return errors;
        }
    }
}