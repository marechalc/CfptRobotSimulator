using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvyControllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace IvyControllers.Tests
{
    [TestClass()]
    public class IvyControllerTests
    {
        [TestMethod()]
        public void IvyControllerTest()
        {
            var testController = new IvyController("testController", "ready", "", "255.255.255.255", "2015");
            Assert.Fail();
        }

        [TestMethod()]
        public void IvyControllerTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IvyControllerTest2()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SendMessageThroughBusTest()
        {
            Assert.Fail();
        }
    }
}
