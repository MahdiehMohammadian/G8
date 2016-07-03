using System;
using System.Collections.Generic;
using System.Text;
using Conf.Model;

namespace Conf.Model
{
	public class articleModel : BaseClass
	{
		public int article_id { get; set; }
		public string topic { get; set; }
		public string writer_id { get; set; }
	}
}

