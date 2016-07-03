using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class userBLL : BFBaseClass
	{
		#region "user"

		public int? InsertOrUpdate(userModel objuser)
		{
			return new Conf.DAL.userDAL().InsertOrUpdate(objuser);
		}
		public List<userModel> List()
		{
			return new Conf.DAL.userDAL().List();
		}
		public userModel Info(int ID)
		{
			return new Conf.DAL.userDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.userDAL().Delete(ID);
		}

		#endregion
	}
}
