using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class user_roleBLL : BFBaseClass
	{
		#region "user_role"

		public int? InsertOrUpdate(user_roleModel objuser_role)
		{
			return new Conf.DAL.user_roleDAL().InsertOrUpdate(objuser_role);
		}
		public List<user_roleModel> List()
		{
			return new Conf.DAL.user_roleDAL().List();
		}
		public user_roleModel Info(int ID)
		{
			return new Conf.DAL.user_roleDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.user_roleDAL().Delete(ID);
		}

		#endregion
	}
}
