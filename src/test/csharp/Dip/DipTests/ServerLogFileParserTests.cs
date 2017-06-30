using System.IO;
using Dip;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DipTests
{
    [TestClass]
    public class ServerLogFileParserTest
    {
        private string logFile;

        [TestMethod]
        public void ParseApacheLog_ValidFile_CorrectErrorCount()
        {
            // arrange
            var apacheLog = CreateApacheLog();

            // act
            var parser = new ServerLogFileParser(apacheLog);
            var errors = parser.GetErrors();

            // assert
            errors.Count.Should().Be(4);
            errors[3].Should().Contain("authentication failure");
        }

        [TestMethod]
        public void ParseILogMock_ValidFile_CorrectErrorCount()
        {
            // arrange
            var ilogmock = new ILogMock();

            // act
            var parser = new ServerLogFileParser(ilogmock);
            var errors = parser.GetErrors();

            // assert
            errors.Count.Should().Be(3);
            errors[2].Should().Contain("Quack");
        }

        [TestCleanup]
        public void TearDown()
        {
            if (logFile != null)
            {
                File.Delete(logFile);
            }
        }

        private ApacheLog CreateApacheLog()
        {
            logFile = TestUtils.ExtractResourceToFile("DipTests.Resources.error_log");
            return new ApacheLog(logFile);
        }
    }
}