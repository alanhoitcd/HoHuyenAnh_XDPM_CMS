using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.DAL;
using CMS.DML;
using Microsoft.Reporting.WinForms;

namespace CMS.BLL
{
    public class DoctorsBLL
    {
        private readonly DoctorsDAL t = new DoctorsDAL();
        //hàm kiểm tra bác sĩ đã tồn tại chưa theo ID
        public bool CheckDoctorsByDoctorId(int doctorId)
        {
            return t.CheckDoctorsByDoctorId(doctorId) > 0;
        }
        //hàm kiểm tra bác sĩ đã tồn tại chưa theo số giấy phép
        public bool CheckDoctorsByLicenseNumber(string licenseNumber)
        {
            return t.CheckDoctorsByLicenseNumber(licenseNumber) > 0;
        }
        //hàm kiểm tra bác sĩ đã tồn tại chưa theo tên
        public bool CheckDoctorsByFirstName(string firstName)
        {
            return t.CheckDoctorsByFirstName(firstName) > 0;
        }
        //hàm kiểm tra bác sĩ đã tồn tại chưa theo lịch làm việc
        public bool CheckDoctorsBySpecialty(string specialty)
        {
            return t.CheckDoctorsBySpecialty(specialty) > 0;
        }
        //hàm kiểm tra bác sĩ đã tồn tại chưa theo chuyên khoa
        public bool CheckDoctorsBySchedule(string schedule)
        {
            return t.CheckDoctorsBySchedule(schedule) > 0;
        }
        //hàm selete all bac sĩ
        public DataTable GetAllDoctors()
        {
            return t.GetAllDoctors();
        }
        //hàm thêm bác sĩ
        public void Insert(DoctorsDML dml)
        {
            t.Insert(dml);
        }
        //hàm cập nhật bác sĩ
        public void Update(DoctorsDML dml)
        {
            t.Update(dml);
        }
        //hàm xóa bác sĩ
        public void Delete(DoctorsDML dml)
        {
            t.Delete(dml);
        }
        //hàm select bác sĩ theo ID
        public DataTable GetDoctorById(int doctorId)
        {
            return t.GetDoctorById(doctorId);
        }
        //hàm select bác sĩ theo tên
        public DataTable GetDoctorsByFirstName(string firstName)
        {
            return t.GetDoctorsByFirstName(firstName);
        }
        //hàm select bác sĩ theo chuyên khoa 
        public DataTable GetDoctorsBySpecialty(string specialty)
        {
            return t.GetDoctorsBySpecialty(specialty);
        }
        //hàm select bác sĩ theo số giấy phép
        public DataTable GetDoctorsByLicenseNumber(string licenseNumber)
        {
            return t.GetDoctorsByLicenseNumber(licenseNumber);
        }
        //hàm select bác sĩ theo lịch làm việc
        public DataTable GetDoctorsBySchedule(string schedule)
        {
            return t.GetDoctorsBySchedule(schedule);
        }
    }
}
