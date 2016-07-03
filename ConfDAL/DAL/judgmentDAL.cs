using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class judgmentDAL : DABaseClass
	{
		#region "judgment"

		public int? InsertOrUpdate(judgmentModel objjudgment)
		{
			try
			{
				ConfigureConnection("usp_judgment_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("article_id", objjudgment.article_id);
				SetSqlParameterValue("judge_id", objjudgment.judge_id);
				SetSqlParameterValue("senddate", objjudgment.senddate);
				SetSqlParameterValue("deadline", objjudgment.deadline);
				SetSqlParameterValue("status", objjudgment.status);
				SetSqlParameterValue("score", objjudgment.score);
				SetSqlParameterValue("manager_id", objjudgment.manager_id);

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
				ConfigureConnection("usp_judgment_Delete", Constants.Conn);

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
		public List<judgmentModel> List()
		{
			List<judgmentModel> objjudgmentList = null;
			try
			{
				objjudgmentList = new List<judgmentModel>();
				ConfigureConnection("usp_judgment_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objjudgmentList.Add(new judgmentModel()
						{
							article_id = GetSqlParameterValue<int>("article_id"),
							judge_id = GetSqlParameterValue<int>("judge_id"),
							senddate = GetSqlParameterValue<DateTime>("senddate"),
							deadline = GetSqlParameterValue<DateTime>("deadline"),
							status = GetSqlParameterValue<string>("status"),
							score = GetSqlParameterValue<int>("score"),
							manager_id = GetSqlParameterValue<int>("manager_id"),
						});
					}
				}

				return objjudgmentList;
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
		public judgmentModel Info(int ID)
		{
			 judgmentModel objjudgmentModel = null;
			try
			{
				ConfigureConnection("usp_judgment_Info", Constants.Conn);

				SetSqlParameterValue("article_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objjudgmentModel = new judgmentModel()
						{
							article_id = GetSqlParameterValue<int>("article_id"),
							judge_id = GetSqlParameterValue<int>("judge_id"),
							senddate = GetSqlParameterValue<DateTime>("senddate"),
							deadline = GetSqlParameterValue<DateTime>("deadline"),
							status = GetSqlParameterValue<string>("status"),
							score = GetSqlParameterValue<int>("score"),
							manager_id = GetSqlParameterValue<int>("manager_id"),
						};
					}
				}

				return objjudgmentModel;
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
