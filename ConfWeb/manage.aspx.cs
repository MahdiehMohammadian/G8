using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Conf.Web;
using Conf.Model;
using Conf.BLL;
using System.Data.SqlClient;
using System.Configuration;

namespace Conf.Web
{
    public partial class manage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Services.WebMethod]
        public static string parametr(string name)
        { 
            string temp=null;
           SqlConnection Connection=new SqlConnection();
           Connection.ConnectionString= System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
           Connection.Open();
           SqlCommand command = new SqlCommand();
           command.CommandText = "select * from person where user_id=(select user_id from judeg where judeg_id='"+name+"')";
           command.Connection = Connection;
           SqlDataReader redar = command.ExecuteReader();
           if (redar.Read())
           {
               temp = redar[1].ToString() + "*" + redar[2].ToString() + "*" + redar[3].ToString() + "*" + redar[4].ToString() + "*" + redar[5].ToString();
           }

           redar.Close();
           Connection.Close();
           return temp;
        }

        [System.Web.Services.WebMethod]
        public static bool submit(string t1, string t2)
        {
            send_to_judgeModel send = new send_to_judgeModel();
            send.article_id = t2;
            send.judge_id = t1;
            send.username = "";
            send_to_judgeBLL sending = new send_to_judgeBLL();
            sending.InsertOrUpdate(send);
            return true;
        }

        [System.Web.Services.WebMethod]
        public static string parametr2(string name)
        {
            string temp = null;
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "select [abs_article] from abs_article where article_id='"+name+"'";
            command.Connection = Connection;
            SqlDataReader redar = command.ExecuteReader();
            if (redar.Read())
            {
                temp = redar[0].ToString();
            }

            redar.Close();
            Connection.Close();
            return temp;
        }

        [System.Web.Services.WebMethod]
        public static string[] fill()
        {
            List<string>list=new List<string>();
           SqlConnection Connection=new SqlConnection();
           Connection.ConnectionString= System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
           Connection.Open();
           SqlCommand command = new SqlCommand();
           command.CommandText = "select judeg_id from judeg";
           command.Connection = Connection;
           SqlDataReader redar = command.ExecuteReader();
           while (redar.Read())
           {
               list.Add(redar[0].ToString());
           }
           string[] array = list.ToArray();
           redar.Close();
           Connection.Close();
           return array;
        }

        [System.Web.Services.WebMethod]
        public static string[] fill2()
        {
            List<string> list = new List<string>();
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "select article_id from abs_article";
            command.Connection = Connection;
            SqlDataReader redar = command.ExecuteReader();
            while (redar.Read())
            {
                list.Add(redar[0].ToString());
            }
            string[] array = list.ToArray();
            redar.Close();
            Connection.Close();
            return array;
        }
    }
}