using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class roleBLL : BFBaseClass
	{
		#region "role"

		public int? InsertOrUpdate(roleModel objrole)
		{
			return new Conf.DAL.roleDAL().InsertOrUpdate(objrole);
		}
		public List<roleModel> List()
		{
			return new Conf.DAL.roleDAL().List();
		}
		public roleModel Info(int ID)
		{
			return new Conf.DAL.roleDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.roleDAL().Delete(ID);
		}

		#endregion
	}
}
