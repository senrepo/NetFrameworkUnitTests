using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NetFrameworkUnitTests
{
    [TestClass]
    public class ConfigTests
    {
        [TestMethod]
        public void TestConsoleConfigXml()
        {
            var config = new ConfigReader();
            Assert.IsTrue(!string.IsNullOrWhiteSpace(config.GetFromEmailAddress()));
        }

        [TestMethod]
        public void TestConsoleConfigJson()
        {
            var appSettingsConfig = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", true, true)
              .Build();
            var appSettings = new AppSettings();
            appSettingsConfig.Bind("AppSettings", appSettings);

            Assert.IsTrue(!string.IsNullOrWhiteSpace(appSettings.FromEmailAddress));
        }

    }
}
