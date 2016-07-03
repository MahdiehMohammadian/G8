using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class accept_articleBLL : BFBaseClass
	{
		#region "accept_article"

		public int? InsertOrUpdate(accept_articleModel objaccept_article)
		{
			return new Conf.DAL.accept_articleDAL().InsertOrUpdate(objaccept_article);
		}
		public List<accept_articleModel> List()
		{
			return new Conf.DAL.accept_articleDAL().List();
		}
		public accept_articleModel Info(int ID)
		{
			return new Conf.DAL.accept_articleDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.accept_articleDAL().Delete(ID);
		}

		#endregion
	}
}
