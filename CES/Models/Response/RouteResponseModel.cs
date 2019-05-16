using CES.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CES.Model.Response
{
	public class RouteResponseModel                                                                                                                     
	{

		public string Start { get; set; }

        public string Destination { get; set; }

        public Transportation Transportation { get; set; }

        public DateTime StartDate { get; set; }

        public int Time { get; set; }

        public decimal Price { get; set; }
    }
}
