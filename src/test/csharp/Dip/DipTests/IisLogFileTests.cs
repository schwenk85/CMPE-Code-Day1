using System.Linq;
using Dip;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DipTests
{
    [TestClass]
    public class IisLogFileTests
    {
        [TestMethod]
        public void ReadLogEntires_ValidFile_ReturnsCorrectEntires()
        {
            // arrange
            var logFile = TestUtils.ExtractResourceToFile("DipTests.Resources.HTTPERR");
            var iisLog = new IisLog(logFile);

            // act



            // assert
            iisLog.LoadLogEntries().Should().HaveCount(4);
            iisLog.LoadLogEntries().Where(l => l.Type == LogType.Error).Should().HaveCount(2);
        }
    }
}