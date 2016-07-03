using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class kargahBLL : BFBaseClass
	{
		#region "kargah"

		public int? InsertOrUpdate(kargahModel objkargah)
		{
			return new Conf.DAL.kargahDAL().InsertOrUpdate(objkargah);
		}
		public List<kargahModel> List()
		{
			return new Conf.DAL.kargahDAL().List();
		}
		public kargahModel Info(int ID)
		{
			return new Conf.DAL.kargahDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.kargahDAL().Delete(ID);
		}

		#endregion
	}
}
