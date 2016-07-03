using System; 
using System.Collections.Generic;
using System.Text; 
using Conf.Model; 
using Conf.DAL; 

namespace Conf.BLL
{
	public class subjectBLL : BFBaseClass
	{
		#region "subject"

		public int? InsertOrUpdate(subjectModel objsubject)
		{
			return new Conf.DAL.subjectDAL().InsertOrUpdate(objsubject);
		}
		public List<subjectModel> List()
		{
			return new Conf.DAL.subjectDAL().List();
		}
		public subjectModel Info(int ID)
		{
			return new Conf.DAL.subjectDAL().Info(ID);
		}
		public bool Delete(int ID)
		{
			return new Conf.DAL.subjectDAL().Delete(ID);
		}

		#endregion
	}
}
