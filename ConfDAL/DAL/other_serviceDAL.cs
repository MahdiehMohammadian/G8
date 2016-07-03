using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class other_serviceDAL : DABaseClass
	{
		#region "other_service"

		public int? InsertOrUpdate(other_serviceModel objother_service)
		{
			try
			{
				ConfigureConnection("usp_other_service_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("type", objother_service.type);
				SetSqlParameterValue("satrt_time", objother_service.satrt_time);
				SetSqlParameterValue("finish_time", objother_service.finish_time);
				SetSqlParameterValue("user_name", objother_service.user_name);

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
				ConfigureConnection("usp_other_service_Delete", Constants.Conn);

				SetSqlParameterValue("type", ID);
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
		public List<other_serviceModel> List()
		{
			List<other_serviceModel> objother_serviceList = null;
			try
			{
				objother_serviceList = new List<other_serviceModel>();
				ConfigureConnection("usp_other_service_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objother_serviceList.Add(new other_serviceModel()
						{
							type = GetSqlParameterValue<string>("type"),
							satrt_time = GetSqlParameterValue<DateTime>("satrt_time"),
							finish_time = GetSqlParameterValue<DateTime>("finish_time"),
							user_name = GetSqlParameterValue<string>("user_name"),
						});
					}
				}

				return objother_serviceList;
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
		public other_serviceModel Info(int ID)
		{
			 other_serviceModel objother_serviceModel = null;
			try
			{
				ConfigureConnection("usp_other_service_Info", Constants.Conn);

				SetSqlParameterValue("type", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objother_serviceModel = new other_serviceModel()
						{
							type = GetSqlParameterValue<string>("type"),
							satrt_time = GetSqlParameterValue<DateTime>("satrt_time"),
							finish_time = GetSqlParameterValue<DateTime>("finish_time"),
							user_name = GetSqlParameterValue<string>("user_name"),
						};
					}
				}

				return objother_serviceModel;
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
