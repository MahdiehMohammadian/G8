using System;
using System.Collections.Generic;
using System.Text;
using Conf.Model;

namespace Conf.Model
{
	public class p_licenseModel : BaseClass
	{
		public int type { get; set; }
		public DateTime time { get; set; }
		public string user_name { get; set; }
		public string factor_id { get; set; }
	}
}

