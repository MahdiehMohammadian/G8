using System;
using System.Collections.Generic;
using System.Text;
using Conf.Model;

namespace Conf.Model
{
	public class tbl_postModel : BaseClass
	{
		public int postid { get; set; }
        public int Gid { get; set; }
		public int userid { get; set; }
		public string title { get; set; }
		public string body { get; set; }
		public DateTime date { get; set; }
	}
}

