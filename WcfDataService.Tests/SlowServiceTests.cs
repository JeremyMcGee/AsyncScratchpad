using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WcfDataService.Tests
{
    [TestClass]
    public class SlowServiceTests
    {
        [TestMethod]
        public void ServiceWaitsForAShortWhile()
        {
            var serviceUnderTest = new SlowService();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            serviceUnderTest.Delay(100);
            stopwatch.Stop();
            Assert.IsTrue(stopwatch.ElapsedMilliseconds >= 100);
        }

        [TestMethod]
        public void ServiceIssuesDelayDuration()
        {
            var serviceUnderTest = new SlowService();

            string result = serviceUnderTest.Delay(100);
            Console.WriteLine(result);
            Assert.IsTrue(result.Contains("Delay of 100ms"));
        }

        [TestMethod]
        public void ServiceIssuesDelayDurationShort()
        {
            var serviceUnderTest = new SlowService();

            string result = serviceUnderTest.Delay(1);
            Console.WriteLine(result);
            Assert.IsTrue(result.Contains("Delay of 1ms"));
        }

        [TestMethod]
        public void ServiceIssuesStartTime()
        {
            var serviceUnderTest = new SlowService();

            string result = serviceUnderTest.Delay(100);
            Console.WriteLine(result);
            Assert.IsTrue(result.Contains(" from "));
        }

        [TestMethod]
        public void ServiceIssuesStopTime()
        {
            var serviceUnderTest = new SlowService();

            string result = serviceUnderTest.Delay(100);
            Console.WriteLine(result);
            Assert.IsTrue(result.Contains(" to "));
        }
    }
}
