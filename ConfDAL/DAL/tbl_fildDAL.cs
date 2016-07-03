using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class tbl_fildDAL : DABaseClass
	{
		#region "tbl_fild"

		public int? InsertOrUpdate(tbl_fildModel objtbl_fild)
		{
			try
			{
				ConfigureConnection("usp_tbl_fild_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("fid", objtbl_fild.fid);
				SetSqlParameterValue("name", objtbl_fild.name);
				SetSqlParameterValue("type", objtbl_fild.type);
				SetSqlParameterValue("userid", objtbl_fild.userid);
				SetSqlParameterValue("path", objtbl_fild.path);

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
				ConfigureConnection("usp_tbl_fild_Delete", Constants.Conn);

				SetSqlParameterValue("fid", ID);
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
		public List<tbl_fildModel> List()
		{
			List<tbl_fildModel> objtbl_fildList = null;
			try
			{
				objtbl_fildList = new List<tbl_fildModel>();
				ConfigureConnection("usp_tbl_fild_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objtbl_fildList.Add(new tbl_fildModel()
						{
							fid = GetSqlParameterValue<int>("fid"),
							name = GetSqlParameterValue<string>("name"),
							type = GetSqlParameterValue<string>("type"),
							userid = GetSqlParameterValue<int>("userid"),
							path = GetSqlParameterValue<string>("path"),
						});
					}
				}

				return objtbl_fildList;
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
		public tbl_fildModel Info(int ID)
		{
			 tbl_fildModel objtbl_fildModel = null;
			try
			{
				ConfigureConnection("usp_tbl_fild_Info", Constants.Conn);

				SetSqlParameterValue("fid", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objtbl_fildModel = new tbl_fildModel()
						{
							fid = GetSqlParameterValue<int>("fid"),
							name = GetSqlParameterValue<string>("name"),
							type = GetSqlParameterValue<string>("type"),
							userid = GetSqlParameterValue<int>("userid"),
							path = GetSqlParameterValue<string>("path"),
						};
					}
				}

				return objtbl_fildModel;
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
