# student-winform-c-
Student Management CRUD winform C# .Netframework with entityframework
Database: 
Create database HoTenDB
Use HoTenDB
CREATE TABLE EmpType(
	TypeId int IDENTITY(1,1) primary key,
	TypeName nvarchar(50) NULL
	)
CREATE TABLE Employee(
	EmployeeId int IDENTITY(1,1) primary key,
	Name nvarchar(50) NOT NULL,
	Address nvarchar(255) NULL,
	Department nvarchar(20) NOT NULL,
	Gender bit,
	EmployeeType int NULL,
	constraint fk_Employee_Type foreign key (EmployeeType) references EmpType(TypeId)
	)
INSERT INTO EmpType(TypeName) VALUES (N'Fulltime')
INSERT INTO EmpType(TypeName) VALUES (N'PartTime')
INSERT INTO EmpType(TypeName) VALUES (N'Contract')

INSERT INTO Employee (Name, Address, Department, Gender, EmployeeType) VALUES ( N'Thuận', N'Huế', N'IT', 'True', 1)
INSERT INTO Employee (Name, Address, Department, Gender, EmployeeType) VALUES ( N'Lan', N'Hà Nội', N'IT', 'False', 1)
INSERT INTO Employee (Name, Address, Department, Gender, EmployeeType) VALUES ( N'Nhã', N'Quảng Ngãi', N'HR', 'True', 1)
INSERT INTO Employee (Name, Address, Department, Gender, EmployeeType) VALUES ( N'Hương', N'Huế', N'HR', 'False', 3)
INSERT INTO Employee (Name, Address, Department, Gender, EmployeeType) VALUES ( N'Hiếu', N'Đà Nẵng', N'Marketing', 'True', 3)

