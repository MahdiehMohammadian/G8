using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class p_licenseDAL : DABaseClass
	{
		#region "p_license"

		public int? InsertOrUpdate(p_licenseModel objp_license)
		{
			try
			{
				ConfigureConnection("usp_p_license_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("type", objp_license.type);
				SetSqlParameterValue("time", objp_license.time);
				SetSqlParameterValue("user_name", objp_license.user_name);
				SetSqlParameterValue("factor_id", objp_license.factor_id);

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
				ConfigureConnection("usp_p_license_Delete", Constants.Conn);

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
		public List<p_licenseModel> List()
		{
			List<p_licenseModel> objp_licenseList = null;
			try
			{
				objp_licenseList = new List<p_licenseModel>();
				ConfigureConnection("usp_p_license_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objp_licenseList.Add(new p_licenseModel()
						{
							type = GetSqlParameterValue<int>("type"),
							time = GetSqlParameterValue<DateTime>("time"),
							user_name = GetSqlParameterValue<string>("user_name"),
							factor_id = GetSqlParameterValue<string>("factor_id"),
						});
					}
				}

				return objp_licenseList;
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
		public p_licenseModel Info(int ID)
		{
			 p_licenseModel objp_licenseModel = null;
			try
			{
				ConfigureConnection("usp_p_license_Info", Constants.Conn);

				SetSqlParameterValue("type", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objp_licenseModel = new p_licenseModel()
						{
							type = GetSqlParameterValue<int>("type"),
							time = GetSqlParameterValue<DateTime>("time"),
							user_name = GetSqlParameterValue<string>("user_name"),
							factor_id = GetSqlParameterValue<string>("factor_id"),
						};
					}
				}

				return objp_licenseModel;
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
