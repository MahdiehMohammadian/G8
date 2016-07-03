using System;
using System.Collections.Generic;
using System.Text;
using Conf.Model;

namespace Conf.Model
{
	public class placeModel : BaseClass
	{
		public int place_id { get; set; }
		public int session_id { get; set; }
		public string address { get; set; }
	}
}

