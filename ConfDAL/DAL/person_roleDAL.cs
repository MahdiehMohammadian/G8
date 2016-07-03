using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class person_roleDAL : DABaseClass
	{
		#region "person_role"

		public int? InsertOrUpdate(person_roleModel objperson_role)
		{
			try
			{
				ConfigureConnection("usp_person_role_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("user_id", objperson_role.user_id);
				SetSqlParameterValue("user_role", objperson_role.user_role);

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
				ConfigureConnection("usp_person_role_Delete", Constants.Conn);

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
		public List<person_roleModel> List()
		{
			List<person_roleModel> objperson_roleList = null;
			try
			{
				objperson_roleList = new List<person_roleModel>();
				ConfigureConnection("usp_person_role_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objperson_roleList.Add(new person_roleModel()
						{
							user_id = GetSqlParameterValue<int>("user_id"),
							user_role = GetSqlParameterValue<int>("user_role"),
						});
					}
				}

				return objperson_roleList;
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
		public person_roleModel Info(int ID)
		{
			 person_roleModel objperson_roleModel = null;
			try
			{
				ConfigureConnection("usp_person_role_Info", Constants.Conn);

				SetSqlParameterValue("user_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objperson_roleModel = new person_roleModel()
						{
							user_id = GetSqlParameterValue<int>("user_id"),
							user_role = GetSqlParameterValue<int>("user_role"),
						};
					}
				}

				return objperson_roleModel;
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
