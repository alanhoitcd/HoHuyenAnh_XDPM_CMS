using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DML
{
    public class VisitDML
    {
        /*
             VisitId INT IDENTITY(1,1) PRIMARY KEY,
            PatientId INT NOT NULL,
            DoctorId INT NOT NULL,
            VisitDate DATETIME NOT NULL DEFAULT GETDATE(),
            Diagnosis NVARCHAR(200) NOT NULL,
            Prescription NVARCHAR(500) NOT NULL,*/
        private int VisitId;
        private int PatientId;
        private int DoctorId;
        private DateTime VisitDate;
        private string Diagnosis;
        private string Prescription;

        public VisitDML()
        {
        }

        public VisitDML(int visitId, int patientId, int doctorId, DateTime visitDate, string diagnosis, string prescription)
        {
            VisitId1 = visitId;
            PatientId1 = patientId;
            DoctorId1 = doctorId;
            VisitDate1 = visitDate;
            Diagnosis1 = diagnosis;
            Prescription1 = prescription;
        }

        public int VisitId1 { get => VisitId; set => VisitId = value; }
        public int PatientId1 { get => PatientId; set => PatientId = value; }
        public int DoctorId1 { get => DoctorId; set => DoctorId = value; }
        public DateTime VisitDate1 { get => VisitDate; set => VisitDate = value; }
        public string Diagnosis1 { get => Diagnosis; set => Diagnosis = value; }
        public string Prescription1 { get => Prescription; set => Prescription = value; }
    }
}
