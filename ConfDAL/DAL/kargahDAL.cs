using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class kargahDAL : DABaseClass
	{
		#region "kargah"

		public int? InsertOrUpdate(kargahModel objkargah)
		{
			try
			{
				ConfigureConnection("usp_kargah_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("id", objkargah.id);
				SetSqlParameterValue("topic", objkargah.topic);
				SetSqlParameterValue("writer", objkargah.writer);
				SetSqlParameterValue("kargah", objkargah.kargah);

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
				ConfigureConnection("usp_kargah_Delete", Constants.Conn);

				SetSqlParameterValue("id", ID);
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
		public List<kargahModel> List()
		{
			List<kargahModel> objkargahList = null;
			try
			{
				objkargahList = new List<kargahModel>();
				ConfigureConnection("usp_kargah_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objkargahList.Add(new kargahModel()
						{
							id = GetSqlParameterValue<int>("id"),
							topic = GetSqlParameterValue<string>("topic"),
							writer = GetSqlParameterValue<string>("writer"),
							kargah = GetSqlParameterValue<string>("kargah"),
						});
					}
				}

				return objkargahList;
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
		public kargahModel Info(int ID)
		{
			 kargahModel objkargahModel = null;
			try
			{
				ConfigureConnection("usp_kargah_Info", Constants.Conn);

				SetSqlParameterValue("id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objkargahModel = new kargahModel()
						{
							id = GetSqlParameterValue<int>("id"),
							topic = GetSqlParameterValue<string>("topic"),
							writer = GetSqlParameterValue<string>("writer"),
							kargah = GetSqlParameterValue<string>("kargah"),
						};
					}
				}

				return objkargahModel;
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
