using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class tbl_linkDAL : DABaseClass
	{
		#region "tbl_link"

		public int? InsertOrUpdate(tbl_linkModel objtbl_link)
		{
			try
			{
				ConfigureConnection("usp_tbl_link_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("Linkid", objtbl_link.Linkid);
				SetSqlParameterValue("Url", objtbl_link.Url);
				SetSqlParameterValue("name", objtbl_link.name);
				SetSqlParameterValue("Discriptoin", objtbl_link.Discriptoin);

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
				ConfigureConnection("usp_tbl_link_Delete", Constants.Conn);

				SetSqlParameterValue("Linkid", ID);
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
		public List<tbl_linkModel> List()
		{
			List<tbl_linkModel> objtbl_linkList = null;
			try
			{
				objtbl_linkList = new List<tbl_linkModel>();
				ConfigureConnection("usp_tbl_link_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objtbl_linkList.Add(new tbl_linkModel()
						{
							Linkid = GetSqlParameterValue<int>("Linkid"),
							Url = GetSqlParameterValue<string>("Url"),
							name = GetSqlParameterValue<string>("name"),
							Discriptoin = GetSqlParameterValue<string>("Discriptoin"),
						});
					}
				}

				return objtbl_linkList;
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
		public tbl_linkModel Info(int ID)
		{
			 tbl_linkModel objtbl_linkModel = null;
			try
			{
				ConfigureConnection("usp_tbl_link_Info", Constants.Conn);

				SetSqlParameterValue("Linkid", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objtbl_linkModel = new tbl_linkModel()
						{
							Linkid = GetSqlParameterValue<int>("Linkid"),
							Url = GetSqlParameterValue<string>("Url"),
							name = GetSqlParameterValue<string>("name"),
							Discriptoin = GetSqlParameterValue<string>("Discriptoin"),
						};
					}
				}

				return objtbl_linkModel;
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
