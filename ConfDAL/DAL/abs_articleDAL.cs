using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class abs_articleDAL : DABaseClass
	{
		#region "abs_article"

		public int? InsertOrUpdate(abs_articleModel objabs_article)
		{
			try
			{
				ConfigureConnection("usp_abs_article_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("article_id", objabs_article.article_id);
				SetSqlParameterValue("abs_article", objabs_article.abs_article);
				SetSqlParameterValue("abs_id", objabs_article.abs_id);

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
				ConfigureConnection("usp_abs_article_Delete", Constants.Conn);

				SetSqlParameterValue("article_id", ID);
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
		public List<abs_articleModel> List()
		{
			List<abs_articleModel> objabs_articleList = null;
			try
			{
				objabs_articleList = new List<abs_articleModel>();
				ConfigureConnection("usp_abs_article_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objabs_articleList.Add(new abs_articleModel()
						{
							article_id = GetSqlParameterValue<string>("article_id"),
							abs_article = GetSqlParameterValue<string>("abs_article"),
							abs_id = GetSqlParameterValue<int>("abs_id"),
						});
					}
				}

				return objabs_articleList;
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
		public abs_articleModel Info(int ID)
		{
			 abs_articleModel objabs_articleModel = null;
			try
			{
				ConfigureConnection("usp_abs_article_Info", Constants.Conn);

				SetSqlParameterValue("article_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objabs_articleModel = new abs_articleModel()
						{
							article_id = GetSqlParameterValue<string>("article_id"),
							abs_article = GetSqlParameterValue<string>("abs_article"),
							abs_id = GetSqlParameterValue<int>("abs_id"),
						};
					}
				}

				return objabs_articleModel;
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
