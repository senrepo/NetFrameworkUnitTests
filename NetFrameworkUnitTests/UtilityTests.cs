using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;

namespace NetFrameworkUnitTests
{
    [TestClass]
    public class UtilityTests
    {
        [TestMethod]
        public void TestCreateZipFile()
        {
            var folder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\TestData";
            var fileName = folder + @"\Results.csv";
            var zipFileName = UtilsStub.CreateZipFile(fileName);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(zipFileName));

        }
    }
}
