using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class p_serviceBLL : BFBaseClass
	{
		#region "p_service"

		public int? InsertOrUpdate(p_serviceModel objp_service)
		{
			return new Conf.DAL.p_serviceDAL().InsertOrUpdate(objp_service);
		}
		public List<p_serviceModel> List()
		{
			return new Conf.DAL.p_serviceDAL().List();
		}
		public p_serviceModel Info(int ID)
		{
			return new Conf.DAL.p_serviceDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.p_serviceDAL().Delete(ID);
		}

		#endregion
	}
}
