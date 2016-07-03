using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class commentDAL : DABaseClass
	{
		#region "comment"

		public int? InsertOrUpdate(commentModel objcomment)
		{
			try
			{
				ConfigureConnection("usp_comment_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("judge_id", objcomment.judge_id);
				SetSqlParameterValue("article_id", objcomment.article_id);
				SetSqlParameterValue("writer_id", objcomment.writer_id);
				SetSqlParameterValue("manager_id", objcomment.manager_id);
				SetSqlParameterValue("commet_writer", objcomment.commet_writer);
				SetSqlParameterValue("comment_manager", objcomment.comment_manager);

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
				ConfigureConnection("usp_comment_Delete", Constants.Conn);

				SetSqlParameterValue("judge_id", ID);
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
		public List<commentModel> List()
		{
			List<commentModel> objcommentList = null;
			try
			{
				objcommentList = new List<commentModel>();
				ConfigureConnection("usp_comment_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objcommentList.Add(new commentModel()
						{
							judge_id = GetSqlParameterValue<int>("judge_id"),
							article_id = GetSqlParameterValue<int>("article_id"),
							writer_id = GetSqlParameterValue<string>("writer_id"),
							manager_id = GetSqlParameterValue<int>("manager_id"),
							commet_writer = GetSqlParameterValue<string>("commet_writer"),
							comment_manager = GetSqlParameterValue<string>("comment_manager"),
						});
					}
				}

				return objcommentList;
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
		public commentModel Info(int ID)
		{
			 commentModel objcommentModel = null;
			try
			{
				ConfigureConnection("usp_comment_Info", Constants.Conn);

				SetSqlParameterValue("judge_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objcommentModel = new commentModel()
						{
							judge_id = GetSqlParameterValue<int>("judge_id"),
							article_id = GetSqlParameterValue<int>("article_id"),
							writer_id = GetSqlParameterValue<string>("writer_id"),
							manager_id = GetSqlParameterValue<int>("manager_id"),
							commet_writer = GetSqlParameterValue<string>("commet_writer"),
							comment_manager = GetSqlParameterValue<string>("comment_manager"),
						};
					}
				}

				return objcommentModel;
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
