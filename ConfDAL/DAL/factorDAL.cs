using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class factorDAL : DABaseClass
	{
		#region "factor"

		public int? InsertOrUpdate(factorModel objfactor)
		{
			try
			{
				ConfigureConnection("usp_factor_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("user_name", objfactor.user_name);
				SetSqlParameterValue("cost", objfactor.cost);
				SetSqlParameterValue("service", objfactor.service);
				SetSqlParameterValue("factor_id", objfactor.factor_id);
				SetSqlParameterValue("state", objfactor.state);
				SetSqlParameterValue("payment_date", objfactor.payment_date);

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
				ConfigureConnection("usp_factor_Delete", Constants.Conn);

				SetSqlParameterValue("user_name", ID);
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
		public List<factorModel> List()
		{
			List<factorModel> objfactorList = null;
			try
			{
				objfactorList = new List<factorModel>();
				ConfigureConnection("usp_factor_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objfactorList.Add(new factorModel()
						{
							user_name = GetSqlParameterValue<string>("user_name"),
							cost = GetSqlParameterValue<int>("cost"),
							service = GetSqlParameterValue<string>("service"),
							factor_id = GetSqlParameterValue<string>("factor_id"),
							state = GetSqlParameterValue<int>("state"),
							payment_date = GetSqlParameterValue<DateTime>("payment_date"),
						});
					}
				}

				return objfactorList;
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
		public factorModel Info(int ID)
		{
			 factorModel objfactorModel = null;
			try
			{
				ConfigureConnection("usp_factor_Info", Constants.Conn);

				SetSqlParameterValue("user_name", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objfactorModel = new factorModel()
						{
							user_name = GetSqlParameterValue<string>("user_name"),
							cost = GetSqlParameterValue<int>("cost"),
							service = GetSqlParameterValue<string>("service"),
							factor_id = GetSqlParameterValue<string>("factor_id"),
							state = GetSqlParameterValue<int>("state"),
							payment_date = GetSqlParameterValue<DateTime>("payment_date"),
						};
					}
				}

				return objfactorModel;
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
