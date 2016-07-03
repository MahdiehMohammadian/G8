using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model;
using Conf.DAL; 

namespace Conf.DAL 
{
	 public class accept_articleDAL : DABaseClass
	{
		#region "accept_article"

		public int? InsertOrUpdate(accept_articleModel objaccept_article)
		{
			try
			{
				ConfigureConnection("usp_accept_article_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("place_id", objaccept_article.place_id);
				SetSqlParameterValue("article_id", objaccept_article.article_id);

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
				ConfigureConnection("usp_accept_article_Delete", Constants.Conn);

				SetSqlParameterValue("place_id", ID);
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
		public List<accept_articleModel> List()
		{
			List<accept_articleModel> objaccept_articleList = null;
			try
			{
				objaccept_articleList = new List<accept_articleModel>();
				ConfigureConnection("usp_accept_article_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objaccept_articleList.Add(new accept_articleModel()
						{
							place_id = GetSqlParameterValue<int>("place_id"),
							article_id = GetSqlParameterValue<int>("article_id"),
						});
					}
				}

				return objaccept_articleList;
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
		public accept_articleModel Info(int ID)
		{
			 accept_articleModel objaccept_articleModel = null;
			try
			{
				ConfigureConnection("usp_accept_article_Info", Constants.Conn);

				SetSqlParameterValue("place_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objaccept_articleModel = new accept_articleModel()
						{
							place_id = GetSqlParameterValue<int>("place_id"),
							article_id = GetSqlParameterValue<int>("article_id"),
						};
					}
				}

				return objaccept_articleModel;
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
