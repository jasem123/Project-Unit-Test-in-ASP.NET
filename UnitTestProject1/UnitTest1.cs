using APP_HW_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DemoTest obj = new DemoTest();
            Assert.AreEqual("Jasem", obj.Fname);
            Assert.AreEqual("Abo Amona", obj.Lname);
        }
    }
}
