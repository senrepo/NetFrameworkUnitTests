using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionMagic;
using System;

namespace NetFrameworkUnitTests
{
    [TestClass]
    public class ReflectionTests
    {
        [TestMethod]
        public void TestPrivateMembersWithReflection()
        {
            var p = new Person();
            p.AsDynamic()._afield = "something";
            Assert.AreEqual("test something", p.AsDynamic().GetAFieldValue());
        }
    }
}
