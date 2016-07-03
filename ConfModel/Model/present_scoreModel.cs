using System;
using System.Collections.Generic;
using System.Text;
using Conf.Model;

namespace Conf.Model
{
	public class present_scoreModel : BaseClass
	{
		public int judge_id { get; set; }
		public int article_id { get; set; }
		public string jude_present { get; set; }
		public double score { get; set; }
	}
}

