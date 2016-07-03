using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class tbl_fildBLL : BFBaseClass
	{
		#region "tbl_fild"

		public int? InsertOrUpdate(tbl_fildModel objtbl_fild)
		{
			return new Conf.DAL.tbl_fildDAL().InsertOrUpdate(objtbl_fild);
		}
		public List<tbl_fildModel> List()
		{
			return new Conf.DAL.tbl_fildDAL().List();
		}
		public tbl_fildModel Info(int ID)
		{
			return new Conf.DAL.tbl_fildDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.tbl_fildDAL().Delete(ID);
		}

		#endregion
	}
}
