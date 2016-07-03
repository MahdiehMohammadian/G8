using System;
using System.Collections.Generic;
using System.Text;
using Conf.Model;

namespace Conf.Model
{
	public class userModel : BaseClass
	{
		public string user_id { get; set; }
		public string username { get; set; }
		public string password { get; set; }
		public string email { get; set; }
		public string sex { get; set; }
		public string educatin_level { get; set; }
		public DateTime Birthday { get; set; }
		public string add { get; set; }
		public string role_id { get; set; }
	}
}

