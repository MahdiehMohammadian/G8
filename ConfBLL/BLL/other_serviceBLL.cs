using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class other_serviceBLL : BFBaseClass
	{
		#region "other_service"

		public int? InsertOrUpdate(other_serviceModel objother_service)
		{
			return new Conf.DAL.other_serviceDAL().InsertOrUpdate(objother_service);
		}
		public List<other_serviceModel> List()
		{
			return new Conf.DAL.other_serviceDAL().List();
		}
		public other_serviceModel Info(int ID)
		{
			return new Conf.DAL.other_serviceDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.other_serviceDAL().Delete(ID);
		}

		#endregion
	}
}
