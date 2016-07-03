using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class p_licenseBLL : BFBaseClass
	{
		#region "p_license"

		public int? InsertOrUpdate(p_licenseModel objp_license)
		{
			return new Conf.DAL.p_licenseDAL().InsertOrUpdate(objp_license);
		}
		public List<p_licenseModel> List()
		{
			return new Conf.DAL.p_licenseDAL().List();
		}
		public p_licenseModel Info(int ID)
		{
			return new Conf.DAL.p_licenseDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.p_licenseDAL().Delete(ID);
		}

		#endregion
	}
}
