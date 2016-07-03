using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class tbl_groupDAL : DABaseClass
	{
		#region "tbl_group"

		public int? InsertOrUpdate(tbl_groupModel objtbl_group)
		{
			try
			{
				ConfigureConnection("usp_tbl_group_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("Gid", objtbl_group.Gid);
				SetSqlParameterValue("name", objtbl_group.name);

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
				ConfigureConnection("usp_tbl_group_Delete", Constants.Conn);

				SetSqlParameterValue("Gid", ID);
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
		public List<tbl_groupModel> List()
		{
			List<tbl_groupModel> objtbl_groupList = null;
			try
			{
				objtbl_groupList = new List<tbl_groupModel>();
				ConfigureConnection("usp_tbl_group_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objtbl_groupList.Add(new tbl_groupModel()
						{
							Gid = GetSqlParameterValue<int>("Gid"),
							name = GetSqlParameterValue<string>("name"),
						});
					}
				}

				return objtbl_groupList;
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
		public tbl_groupModel Info(int ID)
		{
			 tbl_groupModel objtbl_groupModel = null;
			try
			{
				ConfigureConnection("usp_tbl_group_Info", Constants.Conn);

				SetSqlParameterValue("Gid", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objtbl_groupModel = new tbl_groupModel()
						{
							Gid = GetSqlParameterValue<int>("Gid"),
							name = GetSqlParameterValue<string>("name"),
						};
					}
				}

				return objtbl_groupModel;
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
