using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class person_roleBLL : BFBaseClass
	{
		#region "person_role"

		public int? InsertOrUpdate(person_roleModel objperson_role)
		{
			return new Conf.DAL.person_roleDAL().InsertOrUpdate(objperson_role);
		}
		public List<person_roleModel> List()
		{
			return new Conf.DAL.person_roleDAL().List();
		}
		public person_roleModel Info(int ID)
		{
			return new Conf.DAL.person_roleDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.person_roleDAL().Delete(ID);
		}

		#endregion
	}
}
