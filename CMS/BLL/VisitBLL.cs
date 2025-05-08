using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DAL;
using CMS.DML;

namespace CMS.BLL
{
    public class VisitBLL
    {
        private readonly VisitDAL t = new VisitDAL();

        public bool checkVisitsByID(int visitId)
        {
            return t.checkVisitsByID(visitId) > 0;
        }

        public void Insert(VisitDML dml)
        {
            t.Insert(dml);
        }

        public void Update(VisitDML dml)
        {
            t.update(dml);
        }

        public void Delete(VisitDML dml)
        {
            t.Delete(dml);
        }

        public bool CheckVisitById(int visitID)
        {
            return t.checkVisitsByID(visitID) > 0;
        }
    }
}
