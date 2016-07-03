using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class factor2BLL : BFBaseClass
	{
		#region "factor2"

		public int? InsertOrUpdate(factor2Model objfactor2)
		{
			return new Conf.DAL.factor2DAL().InsertOrUpdate(objfactor2);
		}
		public List<factor2Model> List()
		{
			return new Conf.DAL.factor2DAL().List();
		}
		public factor2Model Info(int ID)
		{
			return new Conf.DAL.factor2DAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.factor2DAL().Delete(ID);
		}

		#endregion
	}
}
