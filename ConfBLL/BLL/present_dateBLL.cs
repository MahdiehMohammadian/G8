using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class present_dateBLL : BFBaseClass
	{
		#region "present_date"

		public int? InsertOrUpdate(present_dateModel objpresent_date)
		{
			return new Conf.DAL.present_dateDAL().InsertOrUpdate(objpresent_date);
		}
		public List<present_dateModel> List()
		{
			return new Conf.DAL.present_dateDAL().List();
		}
		public present_dateModel Info(int ID)
		{
			return new Conf.DAL.present_dateDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.present_dateDAL().Delete(ID);
		}

		#endregion
	}
}
