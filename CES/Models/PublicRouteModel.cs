using System;
using System.Collections.Generic;
using System.Text;

namespace CES.Model
{
	public class PublicRouteModel
	{
		public String From_city { get; set; }

		public string To_city { get; set; }

        public int Hours { get; set; }

        public int Segment { get; set; }
    }

}
