using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class personBLL : BFBaseClass
	{
		#region "person"

		public int? InsertOrUpdate(personModel objperson)
		{
			return new Conf.DAL.personDAL().InsertOrUpdate(objperson);
		}
		public List<personModel> List()
		{
			return new Conf.DAL.personDAL().List();
		}
		public personModel Info(int ID)
		{
			return new Conf.DAL.personDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.personDAL().Delete(ID);
		}

		#endregion
	}
}
