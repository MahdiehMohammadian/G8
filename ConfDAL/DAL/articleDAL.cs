using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model;
using Conf.DAL; 

namespace Conf.DAL 
{
	 public class articleDAL : DABaseClass
	{
		#region "article"

		public int? InsertOrUpdate(articleModel objarticle)
		{
			try
			{
				ConfigureConnection("usp_article_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("article_id", objarticle.article_id);
				SetSqlParameterValue("topic", objarticle.topic);
				SetSqlParameterValue("writer_id", objarticle.writer_id);

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
				ConfigureConnection("usp_article_Delete", Constants.Conn);

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
		public List<articleModel> List()
		{
			List<articleModel> objarticleList = null;
			try
			{
				objarticleList = new List<articleModel>();
				ConfigureConnection("usp_article_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objarticleList.Add(new articleModel()
						{
							article_id = GetSqlParameterValue<int>("article_id"),
							topic = GetSqlParameterValue<string>("topic"),
							writer_id = GetSqlParameterValue<string>("writer_id"),
						});
					}
				}

				return objarticleList;
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
		public articleModel Info(int ID)
		{
			 articleModel objarticleModel = null;
			try
			{
				ConfigureConnection("usp_article_Info", Constants.Conn);

				SetSqlParameterValue("article_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objarticleModel = new articleModel()
						{
							article_id = GetSqlParameterValue<int>("article_id"),
							topic = GetSqlParameterValue<string>("topic"),
							writer_id = GetSqlParameterValue<string>("writer_id"),
						};
					}
				}

				return objarticleModel;
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
