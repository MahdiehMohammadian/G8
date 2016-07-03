using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class judgmentBLL : BFBaseClass
	{
		#region "judgment"

		public int? InsertOrUpdate(judgmentModel objjudgment)
		{
			return new Conf.DAL.judgmentDAL().InsertOrUpdate(objjudgment);
		}
		public List<judgmentModel> List()
		{
			return new Conf.DAL.judgmentDAL().List();
		}
		public judgmentModel Info(int ID)
		{
			return new Conf.DAL.judgmentDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.judgmentDAL().Delete(ID);
		}

		#endregion
	}
}
