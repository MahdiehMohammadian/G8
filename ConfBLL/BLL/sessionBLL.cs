using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class sessionBLL : BFBaseClass
	{
		#region "session"

		public int? InsertOrUpdate(sessionModel objsession)
		{
			return new Conf.DAL.sessionDAL().InsertOrUpdate(objsession);
		}
		public List<sessionModel> List()
		{
			return new Conf.DAL.sessionDAL().List();
		}
		public sessionModel Info(int ID)
		{
			return new Conf.DAL.sessionDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.sessionDAL().Delete(ID);
		}

		#endregion
	}
}
