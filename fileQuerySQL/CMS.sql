-- Tạo cơ sở dữ liệu CMS
CREATE DATABASE CMS;
GO

USE CMS;
GO

-- Tạo bảng Users
CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(256) NOT NULL,
    RoleUsers NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    SecurityQuestion NVARCHAR(256) NOT NULL,
    SecurityAnswerHash NVARCHAR(256) NOT NULL,
    LastLogin DATETIME NULL,
    IsActive BIT DEFAULT 1 NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE()
);

-- Tạo bảng Patients
CREATE TABLE Patients (
    PatientId INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender NVARCHAR(6) NOT NULL,
    PhoneNumber NVARCHAR(15) NOT NULL CHECK (PhoneNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    AddressPatients NVARCHAR(100) NOT NULL,
    SocialSecurityNumber NVARCHAR(12) NOT NULL
        CHECK (SocialSecurityNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
        UNIQUE,
    IsEncrypted BIT DEFAULT 0 NOT NULL
);

-- Tạo bảng Doctors
CREATE TABLE Doctors (
    DoctorId INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Specialty NVARCHAR(50) NOT NULL,
    LicenseNumber NVARCHAR(20) UNIQUE NOT NULL,
    Schedule NVARCHAR(100) NOT NULL
);

-- Tạo bảng Visits
CREATE TABLE Visits (
    VisitId INT IDENTITY(1,1) PRIMARY KEY,
    PatientId INT NOT NULL,
    DoctorId INT NOT NULL,
    VisitDate DATETIME NOT NULL DEFAULT GETDATE(),
    Diagnosis NVARCHAR(200) NOT NULL,
    Prescription NVARCHAR(500) NOT NULL,
    FOREIGN KEY (PatientId) REFERENCES Patients(PatientId),
    FOREIGN KEY (DoctorId) REFERENCES Doctors(DoctorId)
);

-- Nhập 10 hàng dữ liệu vào bảng Patients
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES (N'Lê', N'Thị Hồng', '1992-08-22', N'Nữ', '0931122334', N'10 Nguyễn Trãi, Q.1, TP.HCM', '234567890123', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES (N'Phan', N'Văn Bình', '1985-04-10', N'Nam', '0977889900', N'25 Trần Hưng Đạo, Hà Nội', '345678901234', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES (N'Hoàng', N'Thu Trang', '1998-12-05', N'Nữ', '0909112233', N'5 Lê Lợi, Đà Nẵng', '456789012345', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES (N'Vũ', N'Đức Mạnh', '1980-07-18', N'Nam', '0966554433', N'15 Hai Bà Trưng, Huế', '567890123456', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES (N'Trần', N'Ngọc Ánh', '1993-01-28', N'Nữ', '0944332211', N'30 Quang Trung, Cần Thơ', '678901234567', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES (N'Nguyễn', N'Minh Tuấn', '1987-09-14', N'Nam', '0922445566', N'8 Võ Văn Tần, Nha Trang', '789012345678', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES (N'Đặng', N'Thùy Linh', '1996-03-03', N'Nữ', '0911667788', N'22 Nguyễn Huệ, Vũng Tàu', '890123456789', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES (N'Bùi', N'Quốc Huy', '1983-11-09', N'Nam', '0955778899', N'17 Phan Đình Phùng, Đà Lạt', '901234567890', 0)
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES (N'Lâm', N'Khánh Vy', '1999-06-25', N'Nữ', '0988990011', N'50 Ba Tháng Hai, Mỹ Tho', '012345678901', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES (N'Đỗ', N'Văn Hoàng', '1991-04-01', N'Nam', '0977001122', N'11 Nguyễn Thị Minh Khai, Biên Hòa', '112233445566', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES ('John', 'Doe', '1980-05-15', 'Male', '1234567890', '123 Main St', '111111111111', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES ('Jane', 'Smith', '1990-08-22', 'Female', '2345678901', '456 Oak St', '222222222222', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES ('Alex', 'Brown', '1975-03-10', 'Female', '3456789012', '789 Pine St', '333333333333', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES ('Mary', 'Johnson', '1985-12-01', 'Female', '4567890123', '101 Maple St', '444444444444', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES ('Peter', 'Parker', '1995-07-19', 'Male', '5678901234', '202 Cedar St', '555555555555', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES ('Lisa', 'Davis', '1988-09-25', 'Female', '6789012345', '303 Birch St', '666666666666', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES ('Tom', 'Wilson', '1970-11-30', 'Male', '7890123456', '404 Elm St', '777777777777', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES ('Emma', 'Taylor', '1992-02-14', 'Female', '8901234567', '505 Spruce St', '888888888888', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES ('James', 'Moore', '1983-06-08', 'Male', '9012345678', '606 Willow St', '999999999999', 0);
INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted) 
VALUES ('Sarah', 'Lee', '1998-04-17', 'Female', '0123456789', '707 Ash St', '000000000000', 0);

-- Nhập 10 hàng dữ liệu vào bảng Doctors
INSERT INTO Doctors (FirstName, LastName, Specialty, LicenseNumber, Schedule)
VALUES
(N'Lý', N'Văn Quyết', N'Tim Mạch', 'BS23456', N'Thứ 2, Thứ 4 (8:00 - 12:00), Thứ 6 (13:00 - 17:00)'),
(N'Cao', N'Thị Mai', N'Răng Hàm Mặt', 'BS78901', N'Thứ 3, Thứ 5 (9:00 - 17:00), Thứ 7 (8:00 - 11:00)'),
(N'Đinh', N'Hoàng Nam', N'Mắt', 'BS34567', N'Thứ 2-Thứ 5 (14:00 - 18:00)'),
(N'Võ', N'Minh Châu', N'Tai Mũi Họng', 'BS89012', N'Thứ 2, Thứ 3, Thứ 6 (8:30 - 16:30)'),
(N'Trịnh', N'Thanh Hà', N'Nhi Khoa', 'BS45678', N'Thứ 4, Thứ 5, Thứ 7 (9:30 - 12:30)'),
(N'Ngô', N'Quang Huy', N'Thần Kinh', 'BS90123', N'Thứ 2, Thứ 6 (9:00 - 16:00)'),
(N'Phạm', N'Thùy Dương', N'Vật Lý Trị Liệu', 'BS56789', N'Thứ 3, Thứ 5 (10:00 - 18:00)'),
(N'Lê', N'Đức Anh', N'Ung Bướu', 'BS01234', N'Thứ 2-Thứ 4 (8:00 - 17:00)'),
(N'Hoàng', N'Ngọc Lan', N'Dinh Dưỡng', 'BS67891', N'Thứ 5, Thứ 6 (13:00 - 19:00)'),
(N'Phan', N'Văn Mạnh', N'Y Học Cổ Truyền', 'BS12346', N'Thứ 3, Thứ 7 (8:00 - 16:00)');
INSERT INTO Doctors (FirstName, LastName, Specialty, LicenseNumber, Schedule) 
VALUES ('Robert', 'Miller', 'Cardiology', 'LIC001', 'Mon-Fri 9-5');
INSERT INTO Doctors (FirstName, LastName, Specialty, LicenseNumber, Schedule) 
VALUES ('Susan', 'Clark', 'Pediatrics', 'LIC002', 'Tue-Sat 10-6');
INSERT INTO Doctors (FirstName, LastName, Specialty, LicenseNumber, Schedule) 
VALUES ('David', 'Lewis', 'Neurology', 'LIC003', 'Mon-Wed 8-4');
INSERT INTO Doctors (FirstName, LastName, Specialty, LicenseNumber, Schedule) 
VALUES ('Emily', 'Walker', 'Orthopedics', 'LIC004', 'Wed-Fri 9-5');
INSERT INTO Doctors (FirstName, LastName, Specialty, LicenseNumber, Schedule) 
VALUES ('Michael', 'Hall', 'Dermatology', 'LIC005', 'Mon-Fri 10-6');
INSERT INTO Doctors (FirstName, LastName, Specialty, LicenseNumber, Schedule) 
VALUES ('Laura', 'Allen', 'Oncology', 'LIC006', 'Tue-Thu 8-4');
INSERT INTO Doctors (FirstName, LastName, Specialty, LicenseNumber, Schedule) 
VALUES ('Chris', 'Young', 'Psychiatry', 'LIC007', 'Mon-Fri 9-5');
INSERT INTO Doctors (FirstName, LastName, Specialty, LicenseNumber, Schedule) 
VALUES ('Anna', 'King', 'Gastroenterology', 'LIC008', 'Wed-Sat 10-6');
INSERT INTO Doctors (FirstName, LastName, Specialty, LicenseNumber, Schedule) 
VALUES ('Mark', 'Wright', 'Urology', 'LIC009', 'Mon-Thu 8-4');
INSERT INTO Doctors (FirstName, LastName, Specialty, LicenseNumber, Schedule) 
VALUES ('Kelly', 'Scott', 'Endocrinology', 'LIC010', 'Tue-Fri 9-5');

        INSERT INTO Visits (PatientId, DoctorId, VisitDate, Diagnosis, Prescription)
        VALUES (2, 10, '2024-07-21 10:07:56', 'Diagnosis 4', 'Prescription 5');
        

        INSERT INTO Visits (PatientId, DoctorId, VisitDate, Diagnosis, Prescription)
        VALUES (9, 8, '2024-07-03 10:07:56', 'Diagnosis 10', 'Prescription 37');
        

        INSERT INTO Visits (PatientId, DoctorId, VisitDate, Diagnosis, Prescription)
        VALUES (9, 10, '2024-09-24 10:07:56', 'Diagnosis 17', 'Prescription 34');
        

        INSERT INTO Visits (PatientId, DoctorId, VisitDate, Diagnosis, Prescription)
        VALUES (10, 9, '2024-08-04 10:07:56', 'Diagnosis 9', 'Prescription 2');
        

        INSERT INTO Visits (PatientId, DoctorId, VisitDate, Diagnosis, Prescription)
        VALUES (10, 4, '2024-08-16 10:07:56', 'Diagnosis 18', 'Prescription 29');
        

        INSERT INTO Visits (PatientId, DoctorId, VisitDate, Diagnosis, Prescription)
        VALUES (3, 1, '2025-03-12 10:07:56', 'Diagnosis 8', 'Prescription 40');
        

        INSERT INTO Visits (PatientId, DoctorId, VisitDate, Diagnosis, Prescription)
        VALUES (2, 8, '2024-05-13 10:07:56', 'Diagnosis 18', 'Prescription 45');
        

        INSERT INTO Visits (PatientId, DoctorId, VisitDate, Diagnosis, Prescription)
        VALUES (2, 9, '2024-09-05 10:07:56', 'Diagnosis 18', 'Prescription 45');
        

        INSERT INTO Visits (PatientId, DoctorId, VisitDate, Diagnosis, Prescription)
        VALUES (9, 10, '2025-04-22 10:07:56', 'Diagnosis 11', 'Prescription 43');
        

        INSERT INTO Visits (PatientId, DoctorId, VisitDate, Diagnosis, Prescription)
        VALUES (7, 7, '2025-04-20 10:07:56', 'Diagnosis 3', 'Prescription 15');
        


----------------------------------------------
--các procedure Patient***********************************************************
go --procedure select all patient
create procedure getALlPatients
as begin 
select PatientId, FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber from Patients
end
------------------------------------------------------------------------------

go --procedure check patient  by ssn
create procedure checkPatientsBySSN
@SocialSecurityNumber NVARCHAR(12)
as begin
select count(SocialSecurityNumber) from Patients where SocialSecurityNumber = @SocialSecurityNumber
end
------------------------------------------------------------------------------
go --procedure check patient by id
create procedure checkPatientsByID
@PatientId INT
as begin
select count(PatientId) from Patients where PatientId = @PatientId
end
------------------------------------------------------------------------------

go --procedure insert patient
CREATE PROCEDURE insertPatient (
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @DateOfBirth DATE,
    @Gender NVARCHAR(6),
    @PhoneNumber NVARCHAR(15),
    @AddressPatients NVARCHAR(100),
    @SocialSecurityNumber NVARCHAR(12),
    @IsEncrypted BIT = 0
)
AS
BEGIN
    INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, AddressPatients, SocialSecurityNumber, IsEncrypted)
    VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @PhoneNumber, @AddressPatients, @SocialSecurityNumber, @IsEncrypted);
END;
------------------------------------------------------------------------------

go --procedure update patient by ssn(CCCD)	
CREATE PROCEDURE updatePatientBySSN (
	@PatientId INT,
    @SocialSecurityNumber NVARCHAR(12),
    @FirstName NVARCHAR(50) = NULL,
    @LastName NVARCHAR(50) = NULL,
    @DateOfBirth DATE = NULL,
    @Gender NVARCHAR(6) = NULL, 
    @PhoneNumber NVARCHAR(15) = NULL,  
    @AddressPatients NVARCHAR(100) = NULL,
    @IsEncrypted BIT = NULL 
)
AS
BEGIN
        -- Thực hiện cập nhật các trường nếu giá trị tương ứng được cung cấp (không phải là NULL)
        UPDATE Patients
        SET
            FirstName = ISNULL(@FirstName, FirstName),       -- Nếu @FirstName là NULL, giữ nguyên giá trị hiện tại
            LastName = ISNULL(@LastName, LastName),         -- Tương tự cho các trường khác
            DateOfBirth = ISNULL(@DateOfBirth, DateOfBirth),
            Gender = ISNULL(@Gender, Gender),
            PhoneNumber = ISNULL(@PhoneNumber, PhoneNumber),
            AddressPatients = ISNULL(@AddressPatients, AddressPatients),
            IsEncrypted = ISNULL(@IsEncrypted, IsEncrypted),
			SocialSecurityNumber = ISNULL(@SocialSecurityNumber, SocialSecurityNumber)
        WHERE
            PatientId = @PatientId;
END
------------------------------------------------------------------------------

go --procedure delete patient
CREATE PROCEDURE deletePatient (
	@PatientId INT
)
AS
BEGIN
	delete Patients where PatientId = @PatientId;
END;
------------------------------------------------------------------------------

go --procedure Select patient by ssn
CREATE PROCEDURE SelectPatietBySSN (
	@SocialSecurityNumber NVARCHAR(12)
)
AS
BEGIN
	select * from Patients where SocialSecurityNumber = @SocialSecurityNumber;
END;
------------------------------------------------------------------------------

go --procedure Select check Patient sBy FirstName
CREATE PROCEDURE checkPatientsByFirstName (
	@FirstName NVARCHAR(50)
)
AS
BEGIN
	select count(PatientId) from Patients where FirstName = @FirstName;
END;
------------------------------------------------------------------------------

go --procedure Select check Patient sBy Phone
CREATE PROCEDURE checkPatientsByPhoneNumber (
	@PhoneNumber NVARCHAR(15)
)
AS
BEGIN
	select count(PatientId) from Patients where PhoneNumber = @PhoneNumber;
END;
------------------------------------------------------------------------------

go --procedure Select all by firstname
CREATE PROCEDURE getALlPatientsByFirstName (
    @FirstName NVARCHAR(50)
)
AS
BEGIN
	select * from Patients where FirstName = @FirstName;
END;

------------------------------------------------------------------------------

go --procedure Select all by firstname
CREATE PROCEDURE getALlPatientsById (
    @PatientId INT
)
AS
BEGIN
	select * from Patients where PatientId = @PatientId;
END;
------------------------------------------------------------------------------

go --procedure Select all by firstname
CREATE PROCEDURE SelectPatietByPhoneNumber (
    @PhoneNumber NVARCHAR(15)
)
AS
BEGIN
	select * from Patients where PhoneNumber = @PhoneNumber;
END;

--các procedure Doctor***********************************************************

-- Procedure lấy danh sách tất cả bác sĩ
GO
CREATE PROCEDURE getALlDoctors
AS
BEGIN
    SELECT * FROM Doctors
END;

-- Procedure kiểm tra bác sĩ theo DoctorId
GO
CREATE PROCEDURE checkDoctorsByDoctorId
    @DoctorId INT
AS
BEGIN
    SELECT COUNT(DoctorId) FROM Doctors WHERE DoctorId = @DoctorId
END;

-- Procedure kiểm tra bác sĩ theo LicenseNumber
GO
CREATE PROCEDURE checkDoctorsByLicenseNumber
    @LicenseNumber NVARCHAR(20)
AS
BEGIN
    SELECT COUNT(LicenseNumber) FROM Doctors WHERE LicenseNumber = @LicenseNumber
END;

-- Procedure kiểm tra bác sĩ theo FirstName
GO
CREATE PROCEDURE checkDoctorsByFirstName
    @FirstName NVARCHAR(50)
AS
BEGIN
    SELECT COUNT(DoctorId) FROM Doctors WHERE FirstName = @FirstName
END;

-- Procedure kiểm tra bác sĩ theo Specialty
GO
CREATE PROCEDURE checkDoctorsBySpecialty
    @Specialty NVARCHAR(50)
AS
BEGIN
    SELECT COUNT(DoctorId) FROM Doctors WHERE Specialty = @Specialty
END;

-- Procedure kiểm tra bác sĩ theo Schedule
GO
CREATE PROCEDURE checkDoctorsBySchedule
    @Schedule NVARCHAR(100)
AS
BEGIN
    SELECT COUNT(DoctorId) FROM Doctors WHERE Schedule = @Schedule
END;

-- Procedure thêm bác sĩ mới
GO
CREATE PROCEDURE insertDoctors
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Specialty NVARCHAR(50),
    @LicenseNumber NVARCHAR(20),
    @Schedule NVARCHAR(100)
AS
BEGIN
    INSERT INTO Doctors (FirstName, LastName, Specialty, LicenseNumber, Schedule)
    VALUES (@FirstName, @LastName, @Specialty, @LicenseNumber, @Schedule);
END;

-- Procedure cập nhật bác sĩ theo DoctorId
GO
CREATE PROCEDURE updateDoctorById
    @DoctorId INT,
    @FirstName NVARCHAR(50) = NULL,
    @LastName NVARCHAR(50) = NULL,
    @Specialty NVARCHAR(50) = NULL,
    @LicenseNumber NVARCHAR(20) = NULL,
    @Schedule NVARCHAR(100) = NULL
AS
BEGIN
    UPDATE Doctors
    SET
        FirstName = ISNULL(@FirstName, FirstName),
        LastName = ISNULL(@LastName, LastName),
        Specialty = ISNULL(@Specialty, Specialty),
        LicenseNumber = ISNULL(@LicenseNumber, LicenseNumber),
        Schedule = ISNULL(@Schedule, Schedule)
    WHERE DoctorId = @DoctorId;
END;

-- Procedure xóa bác sĩ theo DoctorId
GO
CREATE PROCEDURE deleteDoctorById
    @DoctorId INT
AS
BEGIN
    DELETE FROM Doctors WHERE DoctorId = @DoctorId;
END;

-- Procedure tìm kiếm bác sĩ theo DoctorId
GO
CREATE PROCEDURE getDoctorById
    @DoctorId INT
AS
BEGIN
    SELECT * FROM Doctors WHERE DoctorId = @DoctorId;
END;

-- Procedure tìm kiếm bác sĩ theo FirstName
GO
CREATE PROCEDURE getDoctorsByFirstName
    @FirstName NVARCHAR(50)
AS
BEGIN
    SELECT * FROM Doctors WHERE FirstName = @FirstName;
END;

-- Procedure tìm kiếm bác sĩ theo Specialty
GO
CREATE PROCEDURE getDoctorsBySpecialty
    @Specialty NVARCHAR(50)
AS
BEGIN
    SELECT * FROM Doctors WHERE Specialty = @Specialty;
END;

-- Procedure tìm kiếm bác sĩ theo LicenseNumber
GO
CREATE PROCEDURE getDoctorsByLicenseNumber
    @LicenseNumber NVARCHAR(20)
AS
BEGIN
    SELECT * FROM Doctors WHERE LicenseNumber = @LicenseNumber;
END;

-- Procedure tìm kiếm bác sĩ theo Schedule
GO
CREATE PROCEDURE getDoctorsBySchedule
    @Schedule NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Doctors WHERE Schedule = @Schedule;
END;

-- Procedure lấy toàn bộ bảng visit kèm tên
GO
CREATE PROCEDURE GetVisitsWithPatientAndDoctorNames
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        v.VisitId,
        v.PatientId,
        p.FirstName AS PatientFirstName,
        p.LastName AS PatientLastName,
        v.DoctorId,
        d.FirstName AS DoctorFirstName,
        d.LastName AS DoctorLastName,
        v.VisitDate,
        v.Diagnosis,
        v.Prescription
    FROM 
        Visits v
        INNER JOIN Patients p ON v.PatientId = p.PatientId
        INNER JOIN Doctors d ON v.DoctorId = d.DoctorId;
END;

-- Procedure kiểm tra visit theo id
GO
CREATE PROCEDURE checkVisitsByID
    @VisitId INT
AS
BEGIN
    SELECT COUNT(VisitId) FROM Visits WHERE VisitId = @VisitId
END;--

-- Procedure thêm visit moi
GO
CREATE PROCEDURE insertVisits
	@PatientId INT,
    @DoctorId INT,
    @VisitDate DATETIME ,
    @Diagnosis NVARCHAR(200) ,
    @Prescription NVARCHAR(500) 
AS
BEGIN
    INSERT INTO Visits (PatientId, DoctorId, VisitDate, Diagnosis, Prescription)
    VALUES (@PatientId, @DoctorId, @VisitDate, @Diagnosis, @Prescription);
END;

-- Procedure cập nhật visit theo visitId
GO
CREATE PROCEDURE updateVisitByID
	@VisitId INT,
    @PatientId INT,
    @DoctorId INT = NULL,
    @VisitDate DATETIME = NULL,
    @Diagnosis NVARCHAR(200) = NULL,
    @Prescription NVARCHAR(500) = NULL
AS
BEGIN				select * from Visits
    UPDATE Visits
    SET
        PatientId = ISNULL(@PatientId, PatientId),
        DoctorId = ISNULL(@DoctorId, DoctorId),
		VisitDate = ISNULL(@VisitDate, VisitDate),
        Diagnosis = ISNULL(@Diagnosis, Diagnosis),
        Prescription = ISNULL(@Prescription, Prescription)
    WHERE VisitId = @VisitId;
END;

-- Procedure xóa visit theo visit id
GO
CREATE PROCEDURE deleteVisitById
    @VisitId INT
AS
BEGIN
    DELETE FROM Visits WHERE VisitId = @VisitId;
END;
