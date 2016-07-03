using System;
using System.Collections.Generic;
using System.Text;
using Conf.Model;

namespace Conf.Model
{
	public class personModel : BaseClass
	{
		public int user_id { get; set; }
		public string f_name { get; set; }
		public string l_name { get; set; }
		public string password { get; set; }
		public string mail { get; set; }
		public int tell { get; set; }
	}
}

