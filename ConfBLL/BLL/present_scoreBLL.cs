using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class present_scoreBLL : BFBaseClass
	{
		#region "present_score"

		public int? InsertOrUpdate(present_scoreModel objpresent_score)
		{
			return new Conf.DAL.present_scoreDAL().InsertOrUpdate(objpresent_score);
		}
		public List<present_scoreModel> List()
		{
			return new Conf.DAL.present_scoreDAL().List();
		}
		public present_scoreModel Info(int ID)
		{
			return new Conf.DAL.present_scoreDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.present_scoreDAL().Delete(ID);
		}

		#endregion
	}
}
