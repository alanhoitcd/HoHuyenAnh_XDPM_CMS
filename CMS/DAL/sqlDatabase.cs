using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DAL
{
    //class  sqlDatabase  chứa chuổi kết nối, hàm lấy kết nối và hủy kết nối
    public class sqlDatabase
    {
        private static string sql_connectString;

        private static string GetServerName()
        {
            return Environment.MachineName;
        }

        public static string getConnectString()
        {
            string serverName = GetServerName();
            sql_connectString = $@"Data Source={serverName}\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True";
            return sql_connectString;
        }

    }
}
