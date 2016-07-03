using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model;
using Conf.DAL; 

namespace Conf.DAL 
{
	 public class aghlamefactorDAL : DABaseClass
	{
		#region "aghlamefactor"

		public int? InsertOrUpdate(aghlamefactorModel objaghlamefactor)
		{
			try
			{
				ConfigureConnection("usp_aghlamefactor_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("id", objaghlamefactor.id);
				SetSqlParameterValue("id_factor2", objaghlamefactor.id_factor2);
				SetSqlParameterValue("id_kala", objaghlamefactor.id_kala);

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
				ConfigureConnection("usp_aghlamefactor_Delete", Constants.Conn);

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
		public List<aghlamefactorModel> List()
		{
			List<aghlamefactorModel> objaghlamefactorList = null;
			try
			{
				objaghlamefactorList = new List<aghlamefactorModel>();
				ConfigureConnection("usp_aghlamefactor_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objaghlamefactorList.Add(new aghlamefactorModel()
						{
							id = GetSqlParameterValue<int>("id"),
							id_factor2 = GetSqlParameterValue<int>("id_factor2"),
							id_kala = GetSqlParameterValue<int>("id_kala"),
						});
					}
				}

				return objaghlamefactorList;
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
		public aghlamefactorModel Info(int ID)
		{
			 aghlamefactorModel objaghlamefactorModel = null;
			try
			{
				ConfigureConnection("usp_aghlamefactor_Info", Constants.Conn);

				SetSqlParameterValue("id", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objaghlamefactorModel = new aghlamefactorModel()
						{
							id = GetSqlParameterValue<int>("id"),
							id_factor2 = GetSqlParameterValue<int>("id_factor2"),
							id_kala = GetSqlParameterValue<int>("id_kala"),
						};
					}
				}

				return objaghlamefactorModel;
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
