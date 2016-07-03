using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class factor2DAL : DABaseClass
	{
		#region "factor2"

		public int? InsertOrUpdate(factor2Model objfactor2)
		{
			try
			{
				ConfigureConnection("usp_factor2_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("id_factor2", objfactor2.id_factor2);
				SetSqlParameterValue("id_ozv", objfactor2.id_ozv);
				SetSqlParameterValue("tarikh", objfactor2.tarikh);

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
				ConfigureConnection("usp_factor2_Delete", Constants.Conn);

				SetSqlParameterValue("id_factor2", ID);
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
		public List<factor2Model> List()
		{
			List<factor2Model> objfactor2List = null;
			try
			{
				objfactor2List = new List<factor2Model>();
				ConfigureConnection("usp_factor2_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objfactor2List.Add(new factor2Model()
						{
							id_factor2 = GetSqlParameterValue<string>("id_factor2"),
							id_ozv = GetSqlParameterValue<string>("id_ozv"),
							tarikh = GetSqlParameterValue<DateTime>("tarikh"),
						});
					}
				}

				return objfactor2List;
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
		public factor2Model Info(int ID)
		{
			 factor2Model objfactor2Model = null;
			try
			{
				ConfigureConnection("usp_factor2_Info", Constants.Conn);

				SetSqlParameterValue("id_factor2", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objfactor2Model = new factor2Model()
						{
							id_factor2 = GetSqlParameterValue<string>("id_factor2"),
							id_ozv = GetSqlParameterValue<string>("id_ozv"),
							tarikh = GetSqlParameterValue<DateTime>("tarikh"),
						};
					}
				}

				return objfactor2Model;
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
