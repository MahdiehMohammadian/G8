using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class roleDAL : DABaseClass
	{
		#region "role"

		public int? InsertOrUpdate(roleModel objrole)
		{
			try
			{
				ConfigureConnection("usp_role_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("role_id", objrole.role_id);
				SetSqlParameterValue("role_name", objrole.role_name);

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
				ConfigureConnection("usp_role_Delete", Constants.Conn);

				SetSqlParameterValue("role_id", ID);
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
		public List<roleModel> List()
		{
			List<roleModel> objroleList = null;
			try
			{
				objroleList = new List<roleModel>();
				ConfigureConnection("usp_role_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objroleList.Add(new roleModel()
						{
							role_id = GetSqlParameterValue<string>("role_id"),
							role_name = GetSqlParameterValue<string>("role_name"),
						});
					}
				}

				return objroleList;
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
		public roleModel Info(int ID)
		{
			 roleModel objroleModel = null;
			try
			{
				ConfigureConnection("usp_role_Info", Constants.Conn);

				SetSqlParameterValue("role_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objroleModel = new roleModel()
						{
							role_id = GetSqlParameterValue<string>("role_id"),
							role_name = GetSqlParameterValue<string>("role_name"),
						};
					}
				}

				return objroleModel;
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
