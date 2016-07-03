using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class judegBLL : BFBaseClass
	{
		#region "judeg"

		public int? InsertOrUpdate(judegModel objjudeg)
		{
			return new Conf.DAL.judegDAL().InsertOrUpdate(objjudeg);
		}
		public List<judegModel> List()
		{
			return new Conf.DAL.judegDAL().List();
		}
		public judegModel Info(int ID)
		{
			return new Conf.DAL.judegDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.judegDAL().Delete(ID);
		}

		#endregion
	}
}
