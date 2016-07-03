using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 

namespace Conf.DAL 
{
	 public class tbl_postDAL : DABaseClass
	{
		#region "tbl_post"

		public int? InsertOrUpdate(tbl_postModel objtbl_post)
		{
			try
			{
				ConfigureConnection("usp_tbl_post_InsertOrUpdate", Constants.Conn);

				SetSqlParameterValue("postid", objtbl_post.postid);
				SetSqlParameterValue("Gid", objtbl_post.Gid);
				SetSqlParameterValue("userid", objtbl_post.userid);
				SetSqlParameterValue("title", objtbl_post.title);
				SetSqlParameterValue("body", objtbl_post.body);
				SetSqlParameterValue("date", objtbl_post.date);

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
				ConfigureConnection("usp_tbl_post_Delete", Constants.Conn);

				SetSqlParameterValue("postid", ID);
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
		public List<tbl_postModel> List()
		{
			List<tbl_postModel> objtbl_postList = null;
			try
			{
				objtbl_postList = new List<tbl_postModel>();
				ConfigureConnection("usp_tbl_post_List", Constants.Conn);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objtbl_postList.Add(new tbl_postModel()
						{
							postid = GetSqlParameterValue<int>("postid"),
							Gid = GetSqlParameterValue<int>("Gid"),
							userid = GetSqlParameterValue<int>("userid"),
							title = GetSqlParameterValue<string>("title"),
							body = GetSqlParameterValue<string>("body"),
							date = GetSqlParameterValue<DateTime>("date"),
						});
					}
				}

				return objtbl_postList;
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
		public tbl_postModel Info(int ID)
		{
			 tbl_postModel objtbl_postModel = null;
			try
			{
				ConfigureConnection("usp_tbl_post_Info", Constants.Conn);

				SetSqlParameterValue("postid", ID);

				using (reader = db.ExecuteReader(dbCmd))
				{
					while (reader.Read())
					{
						objtbl_postModel = new tbl_postModel()
						{
							postid = GetSqlParameterValue<int>("postid"),
							Gid = GetSqlParameterValue<int>("Gid"),
							userid = GetSqlParameterValue<int>("userid"),
							title = GetSqlParameterValue<string>("title"),
							body = GetSqlParameterValue<string>("body"),
							date = GetSqlParameterValue<DateTime>("date"),
						};
					}
				}

				return objtbl_postModel;
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
