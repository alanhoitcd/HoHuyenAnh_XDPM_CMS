﻿//class UsersBLL
using CMS.DAL;
using CMS.DML;
using CMS.UTIL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CMS.BLL
{
    public class UsersBLL
    {
        private readonly UsersDAL _usersDAL = new UsersDAL();
        //hàm kiểm tra user theo username đã có chưa
        public bool selectCountUserByUserName(UsersDML dml)
        {
            return _usersDAL.selectCountUserByUserName(dml.Username1) > 0;
        }
        //hàm kiểm tra trạng thái đăng nhập
        public bool LoginUser(UsersDML dml)
        {
            if (string.IsNullOrEmpty(dml.Username1) || string.IsNullOrEmpty(dml.PasswordHash1))
            {
                throw new ArgumentException("Username and password are required.");
            }

            UsersDML user = _usersDAL.selectUserByUserName(dml.Username1);
            if (user == null)
            {
                return false; // Người dùng không tồn tại
            }

            if (!user.IsActive1)
            {
                throw new Exception("Account is not active.");
            }

            bool isPasswordValid = PasswordHelper.VerifyPassword(dml.PasswordHash1, user.PasswordHash1);
            if (!isPasswordValid)
            {
                return false; // Mật khẩu sai
            }

            return true;
        }
        //hàm kiểm tra định dạng email
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("Email cannot be empty.");
            if (email.Length < 6)
                throw new ArgumentException("Email must be at least 6 characters long.");
            if (email.Length > 100)
                throw new ArgumentException("Email cannot exceed 100 characters.");

            // Biểu thức chính quy kiểm tra email
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, emailPattern))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        //hàm kiểm tra dữ liệu vào khi tạo tài khoản mới
        public bool RegisterUser(UsersDML t)
        {
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrEmpty(t.Username1) || string.IsNullOrEmpty(t.PasswordHash1) ||
                string.IsNullOrEmpty(t.RoleUsers1) || string.IsNullOrEmpty(t.Email1) ||
                t.SecurityQuestion1 == null || t.SecurityQuestion1.Length == 0 ||
                t.SecurityAnswerHash1 == null || t.SecurityAnswerHash1.Length == 0)
            {
                throw new ArgumentException("All required fields must be provided.");
            }
            // Kiểm tra định dạng Email
            if (!IsValidEmail(t.Email1))
            {
                throw new ArgumentException("Invalid email format.");
            }
            // Kiểm tra xem username đã tồn tại chưa
            if (_usersDAL.selectUserByUserName(t.Username1) != null)
            {
                throw new ArgumentException("Username already exists.");
            }
            // Kiểm tra xem email đã tồn tại chưa
            if (_usersDAL.GetUserByEmail(t.Email1) != null)
            {
                throw new ArgumentException("Email already exists.");
            }
            // Mã hóa mật khẩu
            string hashedPassword = PasswordHelper.HashPassword(t.PasswordHash1);
            // Mã hóa câu hỏi bảo mật
            string hashSecurityQuestion = PasswordHelper.HashPassword(t.SecurityQuestion1);
            // Mã hóa câu trả lời bảo mật
            string hashSecurityAnswerHash = PasswordHelper.HashPassword(t.SecurityAnswerHash1);

            t.PasswordHash1 = PasswordHelper.HashPassword(t.PasswordHash1);
            t.SecurityAnswerHash1 = PasswordHelper.HashPassword(t.SecurityAnswerHash1);
            return _usersDAL.CreateUser(t);
        }
    }
}



