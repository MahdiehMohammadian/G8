using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class send_to_judgeBLL : BFBaseClass
	{
		#region "send_to_judge"

		public int? InsertOrUpdate(send_to_judgeModel objsend_to_judge)
		{
			return new Conf.DAL.send_to_judgeDAL().InsertOrUpdate(objsend_to_judge);
		}
		public List<send_to_judgeModel> List()
		{
			return new Conf.DAL.send_to_judgeDAL().List();
		}
		public send_to_judgeModel Info(int ID)
		{
			return new Conf.DAL.send_to_judgeDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.send_to_judgeDAL().Delete(ID);
		}

		#endregion
	}
}
