using System;
using System.Collections.Generic;
using System.Text;
using Conf.Model;

namespace Conf.Model
{
	public class send_to_judgeModel : BaseClass
	{
		public string article_id { get; set; }
		public string username { get; set; }
		public string judge_id { get; set; }
	}
}

