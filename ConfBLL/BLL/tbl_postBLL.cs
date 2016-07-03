using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class tbl_postBLL : BFBaseClass
	{
		#region "tbl_post"

		public int? InsertOrUpdate(tbl_postModel objtbl_post)
		{
			return new Conf.DAL.tbl_postDAL().InsertOrUpdate(objtbl_post);
		}
		public List<tbl_postModel> List()
		{
			return new Conf.DAL.tbl_postDAL().List();
		}
		public tbl_postModel Info(int ID)
		{
			return new Conf.DAL.tbl_postDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.tbl_postDAL().Delete(ID);
		}

		#endregion
	}
}
