using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class present_dateDAL : DABaseClass
	{
		#region "present_date"

		public int? InsertOrUpdate(present_dateModel objpresent_date)
		{
			try
			{
				ConfigureConnection("usp_present_date_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("date1", objpresent_date.date1);
				SetSqlParameterValue("date2", objpresent_date.date2);
				SetSqlParameterValue("date_id", objpresent_date.date_id);

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
				ConfigureConnection("usp_present_date_Delete", Constants.Conn);

				SetSqlParameterValue("date1", ID);
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
		public List<present_dateModel> List()
		{
			List<present_dateModel> objpresent_dateList = null;
			try
			{
				objpresent_dateList = new List<present_dateModel>();
				ConfigureConnection("usp_present_date_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objpresent_dateList.Add(new present_dateModel()
						{
							date1 = GetSqlParameterValue<DateTime>("date1"),
							date2 = GetSqlParameterValue<DateTime>("date2"),
							date_id = GetSqlParameterValue<int>("date_id"),
						});
					}
				}

				return objpresent_dateList;
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
		public present_dateModel Info(int ID)
		{
			 present_dateModel objpresent_dateModel = null;
			try
			{
				ConfigureConnection("usp_present_date_Info", Constants.Conn);

				SetSqlParameterValue("date1", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objpresent_dateModel = new present_dateModel()
						{
							date1 = GetSqlParameterValue<DateTime>("date1"),
							date2 = GetSqlParameterValue<DateTime>("date2"),
							date_id = GetSqlParameterValue<int>("date_id"),
						};
					}
				}

				return objpresent_dateModel;
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
