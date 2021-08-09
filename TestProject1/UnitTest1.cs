using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Webapi2.Controllers;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Webapi2.Controllers.WeatherForecastController wc = new Webapi2.Controllers.WeatherForecastController();
            string result = wc.Test();
            Assert.AreEqual("Jitendra", result);
        }
    }
}
