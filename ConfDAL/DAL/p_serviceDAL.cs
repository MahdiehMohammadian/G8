using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class p_serviceDAL : DABaseClass
	{
		#region "p_service"

		public int? InsertOrUpdate(p_serviceModel objp_service)
		{
			try
			{
				ConfigureConnection("usp_p_service_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("sevice_name", objp_service.sevice_name);
				SetSqlParameterValue("type", objp_service.type);
				SetSqlParameterValue("user_name", objp_service.user_name);
				SetSqlParameterValue("factor_id", objp_service.factor_id);

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
				ConfigureConnection("usp_p_service_Delete", Constants.Conn);

				SetSqlParameterValue("sevice_name", ID);
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
		public List<p_serviceModel> List()
		{
			List<p_serviceModel> objp_serviceList = null;
			try
			{
				objp_serviceList = new List<p_serviceModel>();
				ConfigureConnection("usp_p_service_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objp_serviceList.Add(new p_serviceModel()
						{
							sevice_name = GetSqlParameterValue<string>("sevice_name"),
							type = GetSqlParameterValue<int>("type"),
							user_name = GetSqlParameterValue<string>("user_name"),
							factor_id = GetSqlParameterValue<string>("factor_id"),
						});
					}
				}

				return objp_serviceList;
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
		public p_serviceModel Info(int ID)
		{
			 p_serviceModel objp_serviceModel = null;
			try
			{
				ConfigureConnection("usp_p_service_Info", Constants.Conn);

				SetSqlParameterValue("sevice_name", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objp_serviceModel = new p_serviceModel()
						{
							sevice_name = GetSqlParameterValue<string>("sevice_name"),
							type = GetSqlParameterValue<int>("type"),
							user_name = GetSqlParameterValue<string>("user_name"),
							factor_id = GetSqlParameterValue<string>("factor_id"),
						};
					}
				}

				return objp_serviceModel;
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
