using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Conf.Model;

namespace Conf.DAL
{
    public abstract class DABaseClass
    {
        #region "   COMMON BASE DATA ACCESS VARIABLES           "
        public SqlDatabase db = null;
        public SqlCommand dbCmd = null;
        public IDataReader reader = null;
        private SqlParameter dbParm = null;
        #endregion

        #region "   GET OUT PARAMETER VALUES                    "
        public void SetOutParameterValues(BaseClass baseClass)
        {
            if (dbCmd != null && baseClass != null)
            {
                if (dbCmd.Parameters.Contains("@Return") == true)
                {
                    dbCmd.Parameters["@Return"].Value = DBNull.Value;
                }
                if (dbCmd.Parameters.Contains("@ErrID") == true)
                {
                    dbCmd.Parameters["@ErrID"].Value = DBNull.Value;
                }
                if (dbCmd.Parameters.Contains("@ErrMsg") == true)
                {
                    dbCmd.Parameters["@ErrMsg"].Value = DBNull.Value;
                }
                if (dbCmd.Parameters.Contains("@SuccessMsg") == true)
                {
                    dbCmd.Parameters["@SuccessMsg"].Value = DBNull.Value;
                }
            }
        }
        public void GetOutParameterValues(BaseClass baseClass)
        {
            if (dbCmd != null && baseClass != null)
            {
                //if (dbCmd.Parameters.Contains("@Return") == true && dbCmd.Parameters["@Return"].Value != DBNull.Value)
                //{
                //    baseClass.Return = (int)dbCmd.Parameters["@Return"].Value;
                //}
                //if (dbCmd.Parameters.Contains("@ErrID") == true && dbCmd.Parameters["@ErrID"].Value != DBNull.Value)
                //{
                //    baseClass.ErrID = (int)dbCmd.Parameters["@ErrID"].Value;
                //    baseClass.ErrMsg = GenerateErrorMessageByErrorId(baseClass.ErrID);
                //}
                if (dbCmd.Parameters.Contains("@ErrMsg") == true && dbCmd.Parameters["@ErrMsg"].Value != DBNull.Value)
                {
                    baseClass.ErrMsg = dbCmd.Parameters["@ErrMsg"].Value.ToString();
                }
                //if (dbCmd.Parameters.Contains("@SuccessMsg") == true && dbCmd.Parameters["@SuccessMsg"].Value != DBNull.Value)
                //{
                //    baseClass.SuccessMsg = dbCmd.Parameters["@SuccessMsg"].Value.ToString();
                //}
            }
        }
        public T GetOutParameterValues<T>(string strColumn)
        {
            if (dbCmd != null)
            {
                if (dbCmd.Parameters.Contains("@" + strColumn) == true && dbCmd.Parameters["@" + strColumn].Value != DBNull.Value)
                {
                    return (T)Convert.ChangeType(dbCmd.Parameters["@" + strColumn].Value, typeof(T));
                }
            }
            return default(T);
        }
        public string GenerateErrorMessageByErrorId(int errId)
        {
            string errmsg = string.Empty;
            switch (errId)
            {
                case 0:
                    errmsg = "Failed";
                    break;
                case 1:
                    errmsg = "Inserted successfully";
                    break;
                case 2:
                    errmsg = "Updated successfully";
                    break;
                case 3:
                    errmsg = "Deleted successfully";
                    break;
                case 4:
                    errmsg = "Failed to Insert";
                    break;
                case 5:
                    errmsg = "Failed to Update";
                    break;
                case 6:
                    errmsg = "Failed to Delete";
                    break;
                case 7:
                    errmsg = "Duplicate exists";
                    break;
                default:
                    errmsg = "";
                    break;
            }
            return errmsg;
        }
        #endregion

        #region "   GET/SET SQL PARM VALUE                      "

        public T GetSqlParameterValue<T>(string columnName)
        {
            object objValue = null;
            if (reader != null)
            {
                int ordinal = reader.GetOrdinal(columnName);
                objValue = reader.GetValue(ordinal);
            }
            if ((objValue.ToString() == "") && (typeof(T) == typeof(int) || typeof(T) == typeof(DateTime) || typeof(T) == typeof(bool) || typeof(T) == typeof(byte)))
            {
                return default(T);
            }
            else
            {
                if (reader.IsDBNull(reader.GetOrdinal(columnName)) == false)
                    return (T)Convert.ChangeType(objValue, typeof(T));

                return default(T);
            }
        }

      

        public void SetSqlParameterValue(string parm, object parmValue)
        {
            dbParm = null;
            if (String.IsNullOrEmpty(parm) == false)
            {
                dbParm = dbCmd.Parameters["@" + parm];
            }

            if (parmValue != null)
            {
                dbParm.Value = parmValue;
            }
            else
            {
                dbParm.Value = DBNull.Value;
            }
        }
        public void SetSqlParameterValue(string parm, object parmValue, bool allowNulls)
        {
            dbParm = null;
            if (String.IsNullOrEmpty(parm) == false)
            {
                dbParm = dbCmd.Parameters["@" + parm];
            }

            if (dbParm != null)
            {
                if (allowNulls == true && ((parmValue == null) || (parmValue != null && ((parmValue.GetType() == typeof(string) && parmValue.ToString() == "") || (parmValue.GetType() == typeof(int) && Convert.ToInt32(parmValue) <= 0) || (parmValue.GetType() == typeof(DateTime) && Convert.ToDateTime(parmValue) == default(DateTime)) || (parmValue.GetType() == typeof(bool) && Convert.ToBoolean(parmValue) == default(bool))))))
                {
                    dbParm.Value = DBNull.Value;
                }
                else
                {
                    dbParm.Value = parmValue;
                }
            }
        }
        #endregion

        #region "   CONFIGURE CONNECTION                        "
        public void ConfigureConnection(string query)
        {
            ConfigureConnection(query, Constants.Conn, CommandType.StoredProcedure);
        }
        public void ConfigureConnection(string query, CommandType cmdType)
        {
            ConfigureConnection(query, Constants.Conn, cmdType);
        }
        public void ConfigureConnection(string query, string conn)
        {
            ConfigureConnection(query, conn, CommandType.StoredProcedure);
        }
        public void ConfigureConnection(string query, string conStr, CommandType cmdType)
        {
            db = new SqlDatabase();

            SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            dbCmd = new SqlCommand(query, Con);
            dbCmd.CommandType = cmdType;
            if (Con.State != ConnectionState.Open)
                Con.Open();

            if (dbCmd.CommandType == CommandType.StoredProcedure)
                SqlCommandBuilder.DeriveParameters(dbCmd);

            dbCmd.CommandTimeout = Constants.ConnTimeOut;
        }
        #endregion

        #region "   CONFIGURE CONNECTION LOG                       "
        public void ConfigureConnectionLog(string query)
        {
            ConfigureConnectionLog(query, Constants.Conn, CommandType.StoredProcedure);
        }
        public void ConfigureConnectionLog(string query, CommandType cmdType)
        {
            ConfigureConnectionLog(query, Constants.Conn, cmdType);
        }
        public void ConfigureConnectionLog(string query, string conn)
        {
            ConfigureConnectionLog(query, conn, CommandType.StoredProcedure);
        }
        public void ConfigureConnectionLog(string query, string conStr, CommandType cmdType)
        {
            db = new SqlDatabase();

            SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionStringLog"].ConnectionString);
            dbCmd = new SqlCommand(query, Con);
            dbCmd.CommandType = cmdType;
            if (Con.State != ConnectionState.Open)
                Con.Open();

            if (dbCmd.CommandType == CommandType.StoredProcedure)
                SqlCommandBuilder.DeriveParameters(dbCmd);

            dbCmd.CommandTimeout = Constants.ConnTimeOut;
        }
        #endregion
    }
}

