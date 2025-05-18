//class PatientsDAL
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DML;

namespace CMS.DAL
{
    public class PatientsDAL
    {
        //hàm kiểm tra bệnh nhân theo CCCD
        public int checkPatientsBySSN(string SSN)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DAL.sqlDatabase.getConnectString()))
                {
                    conn.Open();
                    string query = "checkPatientsBySSN @SSN";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@SSN", SqlDbType.NVarChar).Value = SSN;
                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
        }
        //hàm kiểm tra bệnh nhân theo ID
        public int checkPatientsByID(int patientID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DAL.sqlDatabase.getConnectString()))
                {
                    conn.Open();
                    string query = "checkPatientsByID @patientID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@patientID", SqlDbType.NVarChar).Value = patientID;
                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
        }
        //hàm kiểm tra bệnh nhân theo tên
        public int checkPatientsByFirstName(string firstName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DAL.sqlDatabase.getConnectString()))
                {
                    conn.Open();
                    string query = "checkPatientsByFirstName @firstName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = firstName;
                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
        }
        //hàm kiểm tra bệnh nhân theo số phone
        public int checkPatientsByPhoneNumber(string phoneNumber)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DAL.sqlDatabase.getConnectString()))
                {
                    conn.Open();
                    string query = "checkPatientsByPhoneNumber @phoneNumber";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = phoneNumber;
                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
        }
        //hàm insert bệnh nhân 
        public void Insert(PatientsDML t)
        {
            using (SqlConnection connection = new SqlConnection(sqlDatabase.getConnectString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("insertPatient", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = t.FirstName1;
                        cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = t.LastName1;
                        cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = t.DateOfBirth1;
                        cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = t.Gender1;
                        cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = t.PhoneNumber1;
                        cmd.Parameters.Add("@AddressPatients", SqlDbType.NVarChar).Value = t.AddressPatients1;
                        cmd.Parameters.Add("@SocialSecurityNumber", SqlDbType.NVarChar).Value = t.SocialSecurityNumber1;

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        //hàm select bệnh nhân theo số CCCD
        public void Update(PatientsDML t)
        {
            string query = "updatePatientBySSN";
            using (SqlConnection connection = new SqlConnection(DAL.sqlDatabase.getConnectString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@PatientId", SqlDbType.NVarChar).Value = t.PatientId1;
                    cmd.Parameters.Add("@SocialSecurityNumber", SqlDbType.NVarChar).Value = t.SocialSecurityNumber1;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = t.FirstName1;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = t.LastName1;
                    cmd.Parameters.Add("@DateOfBirth   ", SqlDbType.NVarChar).Value = t.DateOfBirth1;
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = t.Gender1;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = t.PhoneNumber1;
                    cmd.Parameters.Add("@AddressPatients", SqlDbType.NVarChar).Value = t.AddressPatients1;

                    cmd.ExecuteNonQuery();
                }
            }
        }
        //hàm delete bệnh nhân theo số ID
        public void Delete(PatientsDML t)
        {
            using (SqlConnection connection = new SqlConnection(sqlDatabase.getConnectString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("deletePatient", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@PatientId", SqlDbType.NVarChar).Value = t.PatientId1;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //hàm select bệnh nhân theo số CCCD
        public PatientsDML SelectBySSN(PatientsDML t)
        {
            PatientsDML model_ = null;
            using (SqlConnection connection = new SqlConnection(sqlDatabase.getConnectString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SelectPatietBySSN", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@SocialSecurityNumber", SqlDbType.NVarChar).Value = t.SocialSecurityNumber1;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            model_ = new PatientsDML
                            {
                                PatientId1 = reader.GetInt32(0),
                                FirstName1 = reader.GetString(1),
                                LastName1 = reader.GetString(2),
                                DateOfBirth1 = reader.GetDateTime(3),
                                Gender1 = reader.GetString(4),
                                PhoneNumber1 = reader.GetString(5),
                                AddressPatients1 = reader.GetString(6),
                                SocialSecurityNumber1 = reader.GetString(7),
                                IsEncrypted1 = reader.GetBoolean(8)
                            };
                        }
                    }
                }
            }
            return model_;
        }
        //hàm select bệnh nhân theo số phone
        public PatientsDML SelectByPhoneNumber(PatientsDML t)
        {
            PatientsDML model_ = null;
            using (SqlConnection connection = new SqlConnection(sqlDatabase.getConnectString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SelectPatietByPhoneNumber", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = t.PhoneNumber1;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            model_ = new PatientsDML
                            {
                                PatientId1 = reader.GetInt32(0),
                                FirstName1 = reader.GetString(1),
                                LastName1 = reader.GetString(2),
                                DateOfBirth1 = reader.GetDateTime(3),
                                Gender1 = reader.GetString(4),
                                PhoneNumber1 = reader.GetString(5),
                                AddressPatients1 = reader.GetString(6),
                                SocialSecurityNumber1 = reader.GetString(7),
                                IsEncrypted1 = reader.GetBoolean(8)
                            };
                        }
                    }
                }
            }
            return model_;
        }
    }
}
