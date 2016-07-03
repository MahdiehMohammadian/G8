using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class user_roleDAL : DABaseClass
	{
		#region "user_role"

		public int? InsertOrUpdate(user_roleModel objuser_role)
		{
			try
			{
				ConfigureConnection("usp_user_role_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("user_id", objuser_role.user_id);
				SetSqlParameterValue("role_id", objuser_role.role_id);

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
				ConfigureConnection("usp_user_role_Delete", Constants.Conn);

				SetSqlParameterValue("user_id", ID);
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
		public List<user_roleModel> List()
		{
			List<user_roleModel> objuser_roleList = null;
			try
			{
				objuser_roleList = new List<user_roleModel>();
				ConfigureConnection("usp_user_role_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objuser_roleList.Add(new user_roleModel()
						{
							user_id = GetSqlParameterValue<string>("user_id"),
							role_id = GetSqlParameterValue<string>("role_id"),
						});
					}
				}

				return objuser_roleList;
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
		public user_roleModel Info(int ID)
		{
			 user_roleModel objuser_roleModel = null;
			try
			{
				ConfigureConnection("usp_user_role_Info", Constants.Conn);

				SetSqlParameterValue("user_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objuser_roleModel = new user_roleModel()
						{
							user_id = GetSqlParameterValue<string>("user_id"),
							role_id = GetSqlParameterValue<string>("role_id"),
						};
					}
				}

				return objuser_roleModel;
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
