using CES.Model.Request;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CES.Tests.Integration
{
    [TestClass]
    class FastestRouteTest
    {
        [TestMethod]
        public void TestFindFastestRouteByCar()
        {
            RouteRequestModel request = new RouteRequestModel()
            {
                Start = "VIS",
                Destination = "DAK"
            };
        }
    }
}
