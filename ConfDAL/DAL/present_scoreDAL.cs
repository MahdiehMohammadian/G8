using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class present_scoreDAL : DABaseClass
	{
		#region "present_score"

		public int? InsertOrUpdate(present_scoreModel objpresent_score)
		{
			try
			{
				ConfigureConnection("usp_present_score_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("judge_id", objpresent_score.judge_id);
				SetSqlParameterValue("article_id", objpresent_score.article_id);
				SetSqlParameterValue("jude_present", objpresent_score.jude_present);
				SetSqlParameterValue("score", objpresent_score.score);

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
				ConfigureConnection("usp_present_score_Delete", Constants.Conn);

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
		public List<present_scoreModel> List()
		{
			List<present_scoreModel> objpresent_scoreList = null;
			try
			{
				objpresent_scoreList = new List<present_scoreModel>();
				ConfigureConnection("usp_present_score_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objpresent_scoreList.Add(new present_scoreModel()
						{
							judge_id = GetSqlParameterValue<int>("judge_id"),
							article_id = GetSqlParameterValue<int>("article_id"),
							jude_present = GetSqlParameterValue<string>("jude_present"),
							score = GetSqlParameterValue<double>("score"),
						});
					}
				}

				return objpresent_scoreList;
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
		public present_scoreModel Info(int ID)
		{
			 present_scoreModel objpresent_scoreModel = null;
			try
			{
				ConfigureConnection("usp_present_score_Info", Constants.Conn);

				SetSqlParameterValue("judge_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objpresent_scoreModel = new present_scoreModel()
						{
							judge_id = GetSqlParameterValue<int>("judge_id"),
							article_id = GetSqlParameterValue<int>("article_id"),
							jude_present = GetSqlParameterValue<string>("jude_present"),
							score = GetSqlParameterValue<double>("score"),
						};
					}
				}

				return objpresent_scoreModel;
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
