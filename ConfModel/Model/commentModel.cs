using System;
using System.Collections.Generic;
using System.Text;
using Conf.Model;

namespace Conf.Model
{
	public class commentModel : BaseClass
	{
		public int judge_id { get; set; }
		public int article_id { get; set; }
		public string writer_id { get; set; }
		public int manager_id { get; set; }
		public string commet_writer { get; set; }
		public string comment_manager { get; set; }
	}
}

