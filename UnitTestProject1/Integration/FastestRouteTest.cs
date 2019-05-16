using CES.Model.Request;
using CES.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CES.Tests.Integration
{
    [TestClass]
    public class FastestRouteTest
    {
        private readonly RouteService _routeService;

        public FastestRouteTest(RouteService routeService)
        {
            _routeService = routeService;
        }

        [TestMethod]
        public void Test_Find_Fastest_Route_By_Car()
        {
            RouteRequestModel request = new RouteRequestModel()
            {
                Start = "VIS",
                Destination = "DAK"
            };
            var routes = _routeService.FindRoute(request);
            Assert.IsNotNull(routes);
        }
    }
}
