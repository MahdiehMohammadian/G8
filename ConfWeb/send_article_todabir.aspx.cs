using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Conf.BLL;
using Conf.Model;
using Conf.Web;

namespace Conf.Web
{
    public partial class send_article_todabir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Services.WebMethod]
        public static bool send_article(string first, string last)
        {
            abs_articleModel article = new abs_articleModel();
            Random r = new Random();
            int abs_id = r.Next(0, 1000000);
            article.abs_article = last;
            article.article_id = first;
            abs_articleBLL article_bll = new abs_articleBLL();
            article_bll.InsertOrUpdate(article);
            return false;
        }
    }
}