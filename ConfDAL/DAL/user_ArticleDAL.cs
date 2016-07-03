using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class user_ArticleDAL : DABaseClass
	{
		#region "user_Article"

		public int? InsertOrUpdate(user_ArticleModel objuser_Article)
		{
			try
			{
				ConfigureConnection("usp_user_Article_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("user_id", objuser_Article.user_id);
				SetSqlParameterValue("Article_id", objuser_Article.Article_id);

				return db.ExecuteScaler(dbCmd);
			}
			catch(Exception ex)
			{
				return null;
			}
			finally
			{
				db = null;
				dbCmd = null;
			}
		}
		public bool Delete( int ID )
		{
			try
			{
				ConfigureConnection("usp_user_Article_Delete", Constants.Conn);

				SetSqlParameterValue("user_id", ID);
				db.ExecuteNonQuery(dbCmd);

				return true;
			}
			catch(Exception ex)
			{
				return false;
			}
			finally
			{
				db = null;
				dbCmd = null;
			}
		}
		public List<user_ArticleModel> List()
		{
			List<user_ArticleModel> objuser_ArticleList = null;
			try
			{
				objuser_ArticleList = new List<user_ArticleModel>();
				ConfigureConnection("usp_user_Article_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objuser_ArticleList.Add(new user_ArticleModel()
						{
							user_id = GetSqlParameterValue<string>("user_id"),
							Article_id = GetSqlParameterValue<string>("Article_id"),
						});
					}
				}

				return objuser_ArticleList;
			}
			catch(Exception ex)
			{
				return null;
			}
			finally
			{
				db = null;
				dbCmd = null;
			}
		}
		public user_ArticleModel Info(int ID)
		{
			 user_ArticleModel objuser_ArticleModel = null;
			try
			{
				ConfigureConnection("usp_user_Article_Info", Constants.Conn);

				SetSqlParameterValue("user_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objuser_ArticleModel = new user_ArticleModel()
						{
							user_id = GetSqlParameterValue<string>("user_id"),
							Article_id = GetSqlParameterValue<string>("Article_id"),
						};
					}
				}

				return objuser_ArticleModel;
			}
			catch(Exception ex)
			{
				return null;
			}
			finally
			{
				db = null;
				dbCmd = null;
			}
		}

		#endregion
	}
}
