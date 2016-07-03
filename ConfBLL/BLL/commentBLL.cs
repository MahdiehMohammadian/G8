using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class commentBLL : BFBaseClass
	{
		#region "comment"

		public int? InsertOrUpdate(commentModel objcomment)
		{
			return new Conf.DAL.commentDAL().InsertOrUpdate(objcomment);
		}
		public List<commentModel> List()
		{
			return new Conf.DAL.commentDAL().List();
		}
		public commentModel Info(int ID)
		{
			return new Conf.DAL.commentDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.commentDAL().Delete(ID);
		}

		#endregion
	}
}
