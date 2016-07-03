using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class abs_articleBLL : BFBaseClass
	{
		#region "abs_article"

		public int? InsertOrUpdate(abs_articleModel objabs_article)
		{
			return new Conf.DAL.abs_articleDAL().InsertOrUpdate(objabs_article);
		}
		public List<abs_articleModel> List()
		{
			return new Conf.DAL.abs_articleDAL().List();
		}
		public abs_articleModel Info(int ID)
		{
			return new Conf.DAL.abs_articleDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.abs_articleDAL().Delete(ID);
		}

		#endregion
	}
}
