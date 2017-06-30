using System.Collections.Generic;

namespace Dip
{
    public interface ILog
    {
        IEnumerable<LogEntry> LoadLogEntries();
    }
}