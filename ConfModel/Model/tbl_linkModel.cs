using System;
using System.Collections.Generic;
using System.Text;
using Conf.Model;

namespace Conf.Model
{
	public class tbl_linkModel : BaseClass
	{
        public int Linkid { get; set; }
        public string Url { get; set; }
		public string name { get; set; }
        public string Discriptoin { get; set; }
	}
}

