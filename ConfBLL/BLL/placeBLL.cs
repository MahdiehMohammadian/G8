using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class placeBLL : BFBaseClass
	{
		#region "place"

		public int? InsertOrUpdate(placeModel objplace)
		{
			return new Conf.DAL.placeDAL().InsertOrUpdate(objplace);
		}
		public List<placeModel> List()
		{
			return new Conf.DAL.placeDAL().List();
		}
		public placeModel Info(int ID)
		{
			return new Conf.DAL.placeDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.placeDAL().Delete(ID);
		}

		#endregion
	}
}
