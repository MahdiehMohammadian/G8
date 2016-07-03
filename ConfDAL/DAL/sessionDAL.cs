using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class sessionDAL : DABaseClass
	{
		#region "session"

		public int? InsertOrUpdate(sessionModel objsession)
		{
			try
			{
				ConfigureConnection("usp_session_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("session_id", objsession.session_id);
				SetSqlParameterValue("date_id", objsession.date_id);

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
				ConfigureConnection("usp_session_Delete", Constants.Conn);

				SetSqlParameterValue("session_id", ID);
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
		public List<sessionModel> List()
		{
			List<sessionModel> objsessionList = null;
			try
			{
				objsessionList = new List<sessionModel>();
				ConfigureConnection("usp_session_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objsessionList.Add(new sessionModel()
						{
							session_id = GetSqlParameterValue<int>("session_id"),
							date_id = GetSqlParameterValue<int>("date_id"),
						});
					}
				}

				return objsessionList;
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
		public sessionModel Info(int ID)
		{
			 sessionModel objsessionModel = null;
			try
			{
				ConfigureConnection("usp_session_Info", Constants.Conn);

				SetSqlParameterValue("session_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objsessionModel = new sessionModel()
						{
							session_id = GetSqlParameterValue<int>("session_id"),
							date_id = GetSqlParameterValue<int>("date_id"),
						};
					}
				}

				return objsessionModel;
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
