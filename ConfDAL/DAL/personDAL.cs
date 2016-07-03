using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class personDAL : DABaseClass
	{
		#region "person"

		public int? InsertOrUpdate(personModel objperson)
		{
			try
			{
				ConfigureConnection("usp_person_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("user_id", objperson.user_id);
				SetSqlParameterValue("f_name", objperson.f_name);
				SetSqlParameterValue("l_name", objperson.l_name);
				SetSqlParameterValue("password", objperson.password);
				SetSqlParameterValue("mail", objperson.mail);
				SetSqlParameterValue("tell", objperson.tell);

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
				ConfigureConnection("usp_person_Delete", Constants.Conn);

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
		public List<personModel> List()
		{
			List<personModel> objpersonList = null;
			try
			{
				objpersonList = new List<personModel>();
				ConfigureConnection("usp_person_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objpersonList.Add(new personModel()
						{
							user_id = GetSqlParameterValue<int>("user_id"),
							f_name = GetSqlParameterValue<string>("f_name"),
							l_name = GetSqlParameterValue<string>("l_name"),
							password = GetSqlParameterValue<string>("password"),
							mail = GetSqlParameterValue<string>("mail"),
							tell = GetSqlParameterValue<int>("tell"),
						});
					}
				}

				return objpersonList;
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
		public personModel Info(int ID)
		{
			 personModel objpersonModel = null;
			try
			{
				ConfigureConnection("usp_person_Info", Constants.Conn);

				SetSqlParameterValue("user_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objpersonModel = new personModel()
						{
							user_id = GetSqlParameterValue<int>("user_id"),
							f_name = GetSqlParameterValue<string>("f_name"),
							l_name = GetSqlParameterValue<string>("l_name"),
							password = GetSqlParameterValue<string>("password"),
							mail = GetSqlParameterValue<string>("mail"),
							tell = GetSqlParameterValue<int>("tell"),
						};
					}
				}

				return objpersonModel;
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
