using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class user_ArticleBLL : BFBaseClass
	{
		#region "user_Article"

		public int? InsertOrUpdate(user_ArticleModel objuser_Article)
		{
			return new Conf.DAL.user_ArticleDAL().InsertOrUpdate(objuser_Article);
		}
		public List<user_ArticleModel> List()
		{
			return new Conf.DAL.user_ArticleDAL().List();
		}
		public user_ArticleModel Info(int ID)
		{
			return new Conf.DAL.user_ArticleDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.user_ArticleDAL().Delete(ID);
		}

		#endregion
	}
}
