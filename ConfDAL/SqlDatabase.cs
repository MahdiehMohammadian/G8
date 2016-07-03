using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Conf.DAL
{
    public class SqlDatabase
    {
        //Database connection strings
        public static readonly string ConnectionStringProfile = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public SqlDatabase()
        {
        }

        internal System.Data.IDataReader ExecuteReader(System.Data.SqlClient.SqlCommand sqlCmd)
        {
            SqlDataReader rdr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            sqlCmd.Parameters.Clear();
            return rdr;
        }

        internal void ExecuteNonQuery(System.Data.SqlClient.SqlCommand cmd)
        {
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Dispose();
        }
        internal int ExecuteScaler(System.Data.SqlClient.SqlCommand cmd)
        {
            int retvalue = 0;
            int.TryParse(cmd.ExecuteScalar().ToString(), out retvalue);
            cmd.Parameters.Clear();
            cmd.Dispose();

            return retvalue;

        }

        internal System.Data.SqlClient.SqlCommand GetStoredProcCommand(string query)
        {
            System.Data.SqlClient.SqlCommand Comm = new SqlCommand(query);
            Comm.CommandType = System.Data.CommandType.StoredProcedure;
            return Comm;

        }

        internal System.Data.Common.DbCommand GetSqlStringCommand(string query)
        {
            System.Data.SqlClient.SqlCommand Comm = new SqlCommand(query);
            Comm.CommandType = System.Data.CommandType.StoredProcedure;
            return Comm;
        }

        internal void DiscoverParameters(System.Data.Common.DbCommand dbCmd)
        {
            throw new NotImplementedException();
        }
    }

}
