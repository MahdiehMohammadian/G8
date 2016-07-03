using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Conf.BLL;
using Conf.Web;
using Conf.Model;

namespace Conf.Web
{
    public partial class monshi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Services.WebMethod]
        public static bool submit_person(string f_name, string l_name, string password, string mail, string tell, string role_id)
        {
            personModel person = new personModel();
            Random r = new Random();
            int id = r.Next(0, 1000000);
            person.f_name = f_name;
            person.l_name = l_name;
            person.password = password;
            person.mail = mail;
            person.tell =int.Parse(tell);
            user_roleModel user_role = new user_roleModel();
            user_role.role_id = role_id;
            user_role.user_id =id.ToString();
            personBLL person_insert = new personBLL();
            user_roleBLL user_bll=new user_roleBLL() ;
            person_insert.InsertOrUpdate(person);
            user_bll.InsertOrUpdate(user_role);
           return true;
        }

      
    }
}