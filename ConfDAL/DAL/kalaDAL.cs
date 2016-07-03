using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class kalaDAL : DABaseClass
	{
		#region "kala"

		public int? InsertOrUpdate(kalaModel objkala)
		{
			try
			{
				ConfigureConnection("usp_kala_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("kala_id", objkala.kala_id);
				SetSqlParameterValue("ozv_id", objkala.ozv_id);
				SetSqlParameterValue("kala_name", objkala.kala_name);
				SetSqlParameterValue("cost", objkala.cost);
				SetSqlParameterValue("id_kala_group", objkala.id_kala_group);
				SetSqlParameterValue("tozihat", objkala.tozihat);
				SetSqlParameterValue("takhfif", objkala.takhfif);

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
				ConfigureConnection("usp_kala_Delete", Constants.Conn);

				SetSqlParameterValue("kala_id", ID);
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
		public List<kalaModel> List()
		{
			List<kalaModel> objkalaList = null;
			try
			{
				objkalaList = new List<kalaModel>();
				ConfigureConnection("usp_kala_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objkalaList.Add(new kalaModel()
						{
							kala_id = GetSqlParameterValue<string>("kala_id"),
							ozv_id = GetSqlParameterValue<string>("ozv_id"),
							kala_name = GetSqlParameterValue<string>("kala_name"),
							cost = GetSqlParameterValue<int>("cost"),
							id_kala_group = GetSqlParameterValue<string>("id_kala_group"),
							tozihat = GetSqlParameterValue<string>("tozihat"),
							takhfif = GetSqlParameterValue<int>("takhfif"),
						});
					}
				}

				return objkalaList;
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
		public kalaModel Info(int ID)
		{
			 kalaModel objkalaModel = null;
			try
			{
				ConfigureConnection("usp_kala_Info", Constants.Conn);

				SetSqlParameterValue("kala_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objkalaModel = new kalaModel()
						{
							kala_id = GetSqlParameterValue<string>("kala_id"),
							ozv_id = GetSqlParameterValue<string>("ozv_id"),
							kala_name = GetSqlParameterValue<string>("kala_name"),
							cost = GetSqlParameterValue<int>("cost"),
							id_kala_group = GetSqlParameterValue<string>("id_kala_group"),
							tozihat = GetSqlParameterValue<string>("tozihat"),
							takhfif = GetSqlParameterValue<int>("takhfif"),
						};
					}
				}

				return objkalaModel;
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
