using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class subjectDAL : DABaseClass
	{
		#region "subject"

		public int? InsertOrUpdate(subjectModel objsubject)
		{
			try
			{
				ConfigureConnection("usp_subject_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("subject_id", objsubject.subject_id);
				SetSqlParameterValue("subject_name", objsubject.subject_name);

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
				ConfigureConnection("usp_subject_Delete", Constants.Conn);

				SetSqlParameterValue("subject_id", ID);
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
		public List<subjectModel> List()
		{
			List<subjectModel> objsubjectList = null;
			try
			{
				objsubjectList = new List<subjectModel>();
				ConfigureConnection("usp_subject_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objsubjectList.Add(new subjectModel()
						{
							subject_id = GetSqlParameterValue<string>("subject_id"),
							subject_name = GetSqlParameterValue<string>("subject_name"),
						});
					}
				}

				return objsubjectList;
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
		public subjectModel Info(int ID)
		{
			 subjectModel objsubjectModel = null;
			try
			{
				ConfigureConnection("usp_subject_Info", Constants.Conn);

				SetSqlParameterValue("subject_id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objsubjectModel = new subjectModel()
						{
							subject_id = GetSqlParameterValue<string>("subject_id"),
							subject_name = GetSqlParameterValue<string>("subject_name"),
						};
					}
				}

				return objsubjectModel;
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
