using System;
using System.Collections.Generic;
using System.Text;
using Conf.Model;

namespace Conf.Model
{
	public class factorModel : BaseClass
	{
		public string user_name { get; set; }
		public int cost { get; set; }
		public string service { get; set; }
		public string factor_id { get; set; }
		public int state { get; set; }
		public DateTime payment_date { get; set; }
	}
}

