using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class factorBLL : BFBaseClass
	{
		#region "factor"

		public int? InsertOrUpdate(factorModel objfactor)
		{
			return new Conf.DAL.factorDAL().InsertOrUpdate(objfactor);
		}
		public List<factorModel> List()
		{
			return new Conf.DAL.factorDAL().List();
		}
		public factorModel Info(int ID)
		{
			return new Conf.DAL.factorDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.factorDAL().Delete(ID);
		}

		#endregion
	}
}
