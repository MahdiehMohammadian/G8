using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class kala_groupBLL : BFBaseClass
	{
		#region "kala_group"

		public int? InsertOrUpdate(kala_groupModel objkala_group)
		{
			return new Conf.DAL.kala_groupDAL().InsertOrUpdate(objkala_group);
		}
		public List<kala_groupModel> List()
		{
			return new Conf.DAL.kala_groupDAL().List();
		}
		public kala_groupModel Info(int ID)
		{
			return new Conf.DAL.kala_groupDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.kala_groupDAL().Delete(ID);
		}

		#endregion
	}
}
