using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class kalaBLL : BFBaseClass
	{
		#region "kala"

		public int? InsertOrUpdate(kalaModel objkala)
		{
			return new Conf.DAL.kalaDAL().InsertOrUpdate(objkala);
		}
		public List<kalaModel> List()
		{
			return new Conf.DAL.kalaDAL().List();
		}
		public kalaModel Info(int ID)
		{
			return new Conf.DAL.kalaDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.kalaDAL().Delete(ID);
		}

		#endregion
	}
}
