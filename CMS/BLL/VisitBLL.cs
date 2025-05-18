//class VisitBLL
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
        //hàm kiểm tra lượt khám theo ID
        public bool checkVisitsByID(int visitId)
        {
            return t.checkVisitsByID(visitId) > 0;
        }
        //hàm thêm lượt khám
        public void Insert(VisitDML dml)
        {
            t.Insert(dml);
        }
        //hàm sửa lượt khám
        public void Update(VisitDML dml)
        {
            t.update(dml);
        }
        //hàm xóa lượt khám
        public void Delete(VisitDML dml)
        {
            t.Delete(dml);
        }
    }
}
