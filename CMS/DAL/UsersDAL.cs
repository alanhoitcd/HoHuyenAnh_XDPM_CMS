//class UsersDAL
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DML;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CMS.DAL
{
    class UsersDAL
    {
        //hàm kiểm tra user theo username
        public int selectCountUserByUserName(string Username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DAL.sqlDatabase.getConnectString()))
                {
                    using (SqlCommand cmd = new SqlCommand("selectCountUserByUserName", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username; // Sửa kiểu dữ liệu
                        conn.Open();
                        return (int)cmd.ExecuteScalar(); // Trả về kết quả trực tiếp
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error class Users_DAL function selectCountUserByUserName: " + ex.Message);
                return 0;
            }
        }
        //hàm select user theo username
        public UsersDML selectUserByUserName(string userName)
        {
            using (SqlConnection conn = new SqlConnection(DAL.sqlDatabase.getConnectString()))
            {
                SqlCommand cmd = new SqlCommand("selectUserByUserName", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = userName;

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new UsersDML
                        {
                            UserId1 = Convert.ToInt32(reader["UserId"]),
                            Username1 = reader["Username"].ToString(),
                            PasswordHash1 = reader["PasswordHash"].ToString(),
                            RoleUsers1 = reader["RoleUsers"].ToString(),
                            Email1 = reader["Email"].ToString(),
                            SecurityQuestion1 = reader["SecurityQuestion"].ToString(),
                            SecurityAnswerHash1 = reader["SecurityAnswerHash"].ToString(),
                            LastLogin1 = reader["LastLogin"] != DBNull.Value ? Convert.ToDateTime(reader["LastLogin"]) : (DateTime?)null,
                            IsActive1 = Convert.ToBoolean(reader["IsActive"]),
                            CreatedDate1 = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))

                        };
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error class Users_DAL function selectUserByUserName: " + ex.Message);
                }
            }
        }
        //hàm thêm user 
        public bool CreateUser(UsersDML t)
        {
            using (SqlConnection conn = new SqlConnection(DAL.sqlDatabase.getConnectString()))
            {
                string query = "INSERT INTO Users (Username, PasswordHash, RoleUsers, Email, SecurityQuestion, SecurityAnswerHash, LastLogin, IsActive, CreatedDate) VALUES (@Username, @PasswordHash, @RoleUsers, @Email, @SecurityQuestion, @SecurityAnswerHash, @LastLogin, @IsActive, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = t.Username1;
                cmd.Parameters.Add("@PasswordHash", SqlDbType.NVarChar).Value = t.PasswordHash1;
                cmd.Parameters.Add("@RoleUsers", SqlDbType.NVarChar).Value = t.RoleUsers1;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = t.Email1;
                cmd.Parameters.Add("@SecurityQuestion", SqlDbType.NVarChar).Value = t.SecurityQuestion1;
                cmd.Parameters.Add("@SecurityAnswerHash", SqlDbType.NVarChar).Value = t.SecurityAnswerHash1;
                cmd.Parameters.Add("@LastLogin", SqlDbType.DateTime).Value = (object)t.LastLogin1 ?? DBNull.Value;
                cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = t.IsActive1;

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Lỗi vi phạm ràng buộc UNIQUE
                    {
                        if (ex.Message.Contains("Username"))
                            throw new Exception("Username already exists in the database.");
                        if (ex.Message.Contains("Email"))
                            throw new Exception("Email already exists in the database.");
                    }
                    throw new Exception("Error creating user: " + ex.Message);
                }
            }
        }
        //hàm select user theo email
        public UsersDML GetUserByEmail(string email)
        {
            using (SqlConnection conn = new SqlConnection(DAL.sqlDatabase.getConnectString()))
            {
                string query = "SELECT * FROM Users WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new UsersDML
                        {
                            UserId1 = Convert.ToInt32(reader["UserId"]),
                            Username1 = reader["Username"].ToString(),
                            PasswordHash1 = reader["PasswordHash"].ToString(),
                            RoleUsers1 = reader["RoleUsers"].ToString(),
                            Email1 = reader["Email"].ToString(),
                            SecurityQuestion1 = reader["SecurityQuestion"].ToString(),
                            SecurityAnswerHash1 = reader["SecurityAnswerHash"].ToString(),
                            LastLogin1 = reader["LastLogin"] != DBNull.Value ? Convert.ToDateTime(reader["LastLogin"]) : (DateTime?)null,
                            IsActive1 = Convert.ToBoolean(reader["IsActive"]),
                            //Kiểm tra CreateDate bên sql có null không
                            //CreatedDate1 = reader["CreatedDate"] != DBNull.Value ? reader.GetDateTime(reader.GetOrdinal("CreatedDate")) : DateTime.Now
                            CreatedDate1 = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))
                        };
                    }
                    return null;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
