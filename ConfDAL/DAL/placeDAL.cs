using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class placeDAL : DABaseClass
	{
		#region "place"

		public int? InsertOrUpdate(placeModel objplace)
		{
			try
			{
				ConfigureConnection("usp_place_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("place_id", objplace.place_id);
				SetSqlParameterValue("session_id", objplace.session_id);
				SetSqlParameterValue("address", objplace.address);

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
				ConfigureConnection("usp_place_Delete", Constants.Conn);

				SetSqlParameterValue("place_id", ID);
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
		public List<placeModel> List()
		{
			List<placeModel> objplaceList = null;
			try
			{
				objplaceList = new List<placeModel>();
				ConfigureConnection("usp_place_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objplaceList.Add(new placeModel()
						{
							place_id = GetSqlParameterValue<int>("place_id"),
							session_id = GetSqlParameterValue<int>("session_id"),
							address = GetSqlParameterValue<string>("address"),
						});
					}
				}

				return objplaceList;
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
		public placeModel Info(int ID)
		{
			 placeModel objplaceModel = null;
			try
			{
				ConfigureConnection("usp_place_Info", Constants.Conn);

				SetSqlParameterValue("place_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objplaceModel = new placeModel()
						{
							place_id = GetSqlParameterValue<int>("place_id"),
							session_id = GetSqlParameterValue<int>("session_id"),
							address = GetSqlParameterValue<string>("address"),
						};
					}
				}

				return objplaceModel;
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
