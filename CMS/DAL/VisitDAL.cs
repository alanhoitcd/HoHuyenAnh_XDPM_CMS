//class VisitDAL
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DML;

namespace CMS.DAL
{
    public class VisitDAL
    {
        private readonly string connectionString = sqlDatabase.getConnectString();
        //hàm kiểm tra lượt khám theo ID
        public int checkVisitsByID(int VisitId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("checkVisitsByID", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VisitId", VisitId);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        //hàm thêm lượt khám mới
        public void Insert(VisitDML dml)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("insertVisits", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientId", dml.PatientId1);
                    cmd.Parameters.AddWithValue("@DoctorId", dml.DoctorId1);
                    cmd.Parameters.AddWithValue("@VisitDate", dml.VisitDate1);
                    cmd.Parameters.AddWithValue("@Diagnosis", dml.Diagnosis1);
                    cmd.Parameters.AddWithValue("@Prescription", dml.Prescription1);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }
        //hàm update lượt khám theo ID
        public void update(VisitDML dml)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("updateVisitByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VisitId", dml.VisitId1);
                    cmd.Parameters.AddWithValue("@PatientId", dml.PatientId1);
                    cmd.Parameters.AddWithValue("@DoctorId", dml.DoctorId1);
                    cmd.Parameters.AddWithValue("@VisitDate", dml.VisitDate1);
                    cmd.Parameters.AddWithValue("@Diagnosis", dml.Diagnosis1);
                    cmd.Parameters.AddWithValue("@Prescription", dml.Prescription1);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }
        //hàm delete lượt khám theo ID
        public void Delete(VisitDML dml)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("deleteVisitById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VisitId", dml.VisitId1);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
