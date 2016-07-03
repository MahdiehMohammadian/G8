using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class aghlamefactorBLL : BFBaseClass
	{
		#region "aghlamefactor"

		public int? InsertOrUpdate(aghlamefactorModel objaghlamefactor)
		{
			return new Conf.DAL.aghlamefactorDAL().InsertOrUpdate(objaghlamefactor);
		}
		public List<aghlamefactorModel> List()
		{
			return new Conf.DAL.aghlamefactorDAL().List();
		}
		public aghlamefactorModel Info(int ID)
		{
			return new Conf.DAL.aghlamefactorDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.aghlamefactorDAL().Delete(ID);
		}

		#endregion
	}
}
