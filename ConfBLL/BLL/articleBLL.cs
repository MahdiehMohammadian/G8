using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class articleBLL : BFBaseClass
	{
		#region "article"

		public int? InsertOrUpdate(articleModel objarticle)
		{
			return new Conf.DAL.articleDAL().InsertOrUpdate(objarticle);
		}
		public List<articleModel> List()
		{
			return new Conf.DAL.articleDAL().List();
		}
		public articleModel Info(int ID)
		{
			return new Conf.DAL.articleDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.articleDAL().Delete(ID);
		}

		#endregion
	}
}
