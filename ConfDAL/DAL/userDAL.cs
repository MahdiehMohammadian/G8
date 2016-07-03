using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class userDAL : DABaseClass
	{
		#region "user"

		public int? InsertOrUpdate(userModel objuser)
		{
			try
			{
				ConfigureConnection("usp_user_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("user_id", objuser.user_id);
				SetSqlParameterValue("username", objuser.username);
				SetSqlParameterValue("password", objuser.password);
				SetSqlParameterValue("email", objuser.email);
				SetSqlParameterValue("sex", objuser.sex);
				SetSqlParameterValue("educatin_level", objuser.educatin_level);
				SetSqlParameterValue("Birthday", objuser.Birthday);
				SetSqlParameterValue("add", objuser.add);
				SetSqlParameterValue("role_id", objuser.role_id);

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
				ConfigureConnection("usp_user_Delete", Constants.Conn);

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
		public List<userModel> List()
		{
			List<userModel> objuserList = null;
			try
			{
				objuserList = new List<userModel>();
				ConfigureConnection("usp_user_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objuserList.Add(new userModel()
						{
							user_id = GetSqlParameterValue<string>("user_id"),
							username = GetSqlParameterValue<string>("username"),
							password = GetSqlParameterValue<string>("password"),
							email = GetSqlParameterValue<string>("email"),
							sex = GetSqlParameterValue<string>("sex"),
							educatin_level = GetSqlParameterValue<string>("educatin_level"),
							Birthday = GetSqlParameterValue<DateTime>("Birthday"),
							add = GetSqlParameterValue<string>("add"),
							role_id = GetSqlParameterValue<string>("role_id"),
						});
					}
				}

				return objuserList;
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
		public userModel Info(int ID)
		{
			 userModel objuserModel = null;
			try
			{
				ConfigureConnection("usp_user_Info", Constants.Conn);

				SetSqlParameterValue("user_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objuserModel = new userModel()
						{
							user_id = GetSqlParameterValue<string>("user_id"),
							username = GetSqlParameterValue<string>("username"),
							password = GetSqlParameterValue<string>("password"),
							email = GetSqlParameterValue<string>("email"),
							sex = GetSqlParameterValue<string>("sex"),
							educatin_level = GetSqlParameterValue<string>("educatin_level"),
							Birthday = GetSqlParameterValue<DateTime>("Birthday"),
							add = GetSqlParameterValue<string>("add"),
							role_id = GetSqlParameterValue<string>("role_id"),
						};
					}
				}

				return objuserModel;
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
