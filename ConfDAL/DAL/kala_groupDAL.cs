using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class kala_groupDAL : DABaseClass
	{
		#region "kala_group"

		public int? InsertOrUpdate(kala_groupModel objkala_group)
		{
			try
			{
				ConfigureConnection("usp_kala_group_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("id_kala_group", objkala_group.id_kala_group);
				SetSqlParameterValue("name_kala_group", objkala_group.name_kala_group);

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
				ConfigureConnection("usp_kala_group_Delete", Constants.Conn);

				SetSqlParameterValue("id_kala_group", ID);
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
		public List<kala_groupModel> List()
		{
			List<kala_groupModel> objkala_groupList = null;
			try
			{
				objkala_groupList = new List<kala_groupModel>();
				ConfigureConnection("usp_kala_group_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objkala_groupList.Add(new kala_groupModel()
						{
							id_kala_group = GetSqlParameterValue<string>("id_kala_group"),
							name_kala_group = GetSqlParameterValue<string>("name_kala_group"),
						});
					}
				}

				return objkala_groupList;
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
		public kala_groupModel Info(int ID)
		{
			 kala_groupModel objkala_groupModel = null;
			try
			{
				ConfigureConnection("usp_kala_group_Info", Constants.Conn);

				SetSqlParameterValue("id_kala_group", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objkala_groupModel = new kala_groupModel()
						{
							id_kala_group = GetSqlParameterValue<string>("id_kala_group"),
							name_kala_group = GetSqlParameterValue<string>("name_kala_group"),
						};
					}
				}

				return objkala_groupModel;
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
