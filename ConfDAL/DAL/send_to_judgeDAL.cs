using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class send_to_judgeDAL : DABaseClass
	{
		#region "send_to_judge"

		public int? InsertOrUpdate(send_to_judgeModel objsend_to_judge)
		{
			try
			{
				ConfigureConnection("usp_send_to_judge_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("article_id", objsend_to_judge.article_id);
				SetSqlParameterValue("username", objsend_to_judge.username);
				SetSqlParameterValue("judge_id", objsend_to_judge.judge_id);

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
				ConfigureConnection("usp_send_to_judge_Delete", Constants.Conn);

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
		public List<send_to_judgeModel> List()
		{
			List<send_to_judgeModel> objsend_to_judgeList = null;
			try
			{
				objsend_to_judgeList = new List<send_to_judgeModel>();
				ConfigureConnection("usp_send_to_judge_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objsend_to_judgeList.Add(new send_to_judgeModel()
						{
							article_id = GetSqlParameterValue<string>("article_id"),
							username = GetSqlParameterValue<string>("username"),
							judge_id = GetSqlParameterValue<string>("judge_id"),
						});
					}
				}

				return objsend_to_judgeList;
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
		public send_to_judgeModel Info(int ID)
		{
			 send_to_judgeModel objsend_to_judgeModel = null;
			try
			{
				ConfigureConnection("usp_send_to_judge_Info", Constants.Conn);

				SetSqlParameterValue("article_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objsend_to_judgeModel = new send_to_judgeModel()
						{
							article_id = GetSqlParameterValue<string>("article_id"),
							username = GetSqlParameterValue<string>("username"),
							judge_id = GetSqlParameterValue<string>("judge_id"),
						};
					}
				}

				return objsend_to_judgeModel;
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
