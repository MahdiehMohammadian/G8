using System;
using System.Collections.Generic;
using System.Text;
using Conf.Model;

namespace Conf.Model
{
	public class judgmentModel : BaseClass
	{
        public int article_id { get; set; }
		public int judge_id { get; set; }
		public DateTime senddate { get; set; }
		public DateTime deadline { get; set; }
		public string status { get; set; }
		public int score { get; set; }
		public int manager_id { get; set; }
	}
}

