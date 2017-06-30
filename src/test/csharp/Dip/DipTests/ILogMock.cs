using Dip;
using System.Collections.Generic;

namespace DipTests
{
    class ILogMock : ILog
    {
        public IEnumerable<LogEntry> LoadLogEntries()
        {
            return new List<LogEntry> {
                new LogEntry(LogType.Unknown, "Foo"),
                new LogEntry(LogType.Error, "Quertz"),
                new LogEntry(LogType.Error, "Bar"),
                new LogEntry(LogType.Unknown, "Baz"),
                new LogEntry(LogType.Error, "Quack"), };
        }
    }
}
