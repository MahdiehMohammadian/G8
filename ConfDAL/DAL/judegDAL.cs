using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class judegDAL : DABaseClass
	{
		#region "judeg"

		public int? InsertOrUpdate(judegModel objjudeg)
		{
			try
			{
				ConfigureConnection("usp_judeg_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("judeg_id", objjudeg.judeg_id);
				SetSqlParameterValue("user_id", objjudeg.user_id);

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
				ConfigureConnection("usp_judeg_Delete", Constants.Conn);

				SetSqlParameterValue("judeg_id", ID);
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
		public List<judegModel> List()
		{
			List<judegModel> objjudegList = null;
			try
			{
				objjudegList = new List<judegModel>();
				ConfigureConnection("usp_judeg_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objjudegList.Add(new judegModel()
						{
							judeg_id = GetSqlParameterValue<string>("judeg_id"),
							user_id = GetSqlParameterValue<string>("user_id"),
						});
					}
				}

				return objjudegList;
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
		public judegModel Info(int ID)
		{
			 judegModel objjudegModel = null;
			try
			{
				ConfigureConnection("usp_judeg_Info", Constants.Conn);

				SetSqlParameterValue("judeg_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objjudegModel = new judegModel()
						{
							judeg_id = GetSqlParameterValue<string>("judeg_id"),
							user_id = GetSqlParameterValue<string>("user_id"),
						};
					}
				}

				return objjudegModel;
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
