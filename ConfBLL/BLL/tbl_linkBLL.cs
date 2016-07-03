using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class tbl_linkBLL : BFBaseClass
	{
		#region "tbl_link"

		public int? InsertOrUpdate(tbl_linkModel objtbl_link)
		{
			return new Conf.DAL.tbl_linkDAL().InsertOrUpdate(objtbl_link);
		}
		public List<tbl_linkModel> List()
		{
			return new Conf.DAL.tbl_linkDAL().List();
		}
		public tbl_linkModel Info(int ID)
		{
			return new Conf.DAL.tbl_linkDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.tbl_linkDAL().Delete(ID);
		}

		#endregion
	}
}
