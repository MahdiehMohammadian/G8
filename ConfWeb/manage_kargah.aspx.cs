using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Conf.Model;
using Conf.BLL;
using Conf.Web;

namespace Conf.Web
{
    public partial class manage_kargah : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        [System.Web.Services.WebMethod]
        public static bool submit_kargah(string kargah_name , string kargah_writer ,string kargah_topic)
        {
            kargahModel kargah_model = new kargahModel();
            Random r=new Random();
            int id= r.Next(0,1000000);
            kargah_model.id = id;
            kargah_model.kargah = kargah_name;
            kargah_model.topic = kargah_topic;
            kargah_model.writer = kargah_writer;
            kargahBLL insert_to_kargah = new kargahBLL();
            insert_to_kargah.InsertOrUpdate(kargah_model);
            return false;
        }

        [System.Web.Services.WebMethod]
        public static bool submit_sesion(string sesion_id, string adres)
        {
            placeModel place = new placeModel();
            Random r = new Random();
            r.Next(0,1000000);
            int id = int.Parse(sesion_id);
            placeBLL plac = new placeBLL();
            place.place_id = id;
            place.session_id =int.Parse( sesion_id);
            place.address = adres;
            plac.InsertOrUpdate(place);
            return false;
        }

        [System.Web.Services.WebMethod]
        public static void submit_place(string data_id)
        {
            sessionModel session = new sessionModel();
            Random r = new Random();
            session.session_id = r.Next(0, 1000000);
            session.date_id =int.Parse( data_id);
            sessionBLL spl = new sessionBLL();
            spl.InsertOrUpdate(session);
        }
    }
}