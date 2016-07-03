using System;
using System.Collections.Generic;
using System.Text;
using Conf.Model;

namespace Conf.Model
{
	public class kargahModel : BaseClass
	{
		public int id { get; set; }
		public string topic { get; set; }
		public string writer { get; set; }
		public string kargah { get; set; }
	}
}

