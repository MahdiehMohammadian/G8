using System;
using System.Collections.Generic;
using System.Text;
using Conf.Model;

namespace Conf.Model
{
	public class tbl_fildModel : BaseClass
	{
		public int fid { get; set; }
		public string name { get; set; }
		public string type { get; set; }
		public int userid { get; set; }
		public string path { get; set; }
	}
}

