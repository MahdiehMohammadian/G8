using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class tbl_groupBLL : BFBaseClass
	{
		#region "tbl_group"

		public int? InsertOrUpdate(tbl_groupModel objtbl_group)
		{
			return new Conf.DAL.tbl_groupDAL().InsertOrUpdate(objtbl_group);
		}
		public List<tbl_groupModel> List()
		{
			return new Conf.DAL.tbl_groupDAL().List();
		}
		public tbl_groupModel Info(int ID)
		{
			return new Conf.DAL.tbl_groupDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.tbl_groupDAL().Delete(ID);
		}

		#endregion
	}
}
