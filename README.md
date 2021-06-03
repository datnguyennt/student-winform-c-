# student-winform-c-
Student Management CRUD winform C# .Netframework with entityframework (h2)  
Database:  
Create database HoTenDB  
Use HoTenDB  
CREATE TABLE EmpType(  
__TypeId int IDENTITY(1,1) primary key,  __
__TypeName nvarchar(50) NULL  __
__)  __
CREATE TABLE Employee(  
__EmployeeId int IDENTITY(1,1) primary key,  __
__Name nvarchar(50) NOT NULL,  __
__Address nvarchar(255) NULL, __ 
__Department nvarchar(20) NOT NULL,  __
__Gender bit,  __
__EmployeeType int NULL,  __
__constraint fk_Employee_Type foreign key (EmployeeType) references EmpType(TypeId) __ 
__)  __
INSERT INTO EmpType(TypeName) VALUES (N'Fulltime')  
INSERT INTO EmpType(TypeName) VALUES (N'PartTime')  
INSERT INTO EmpType(TypeName) VALUES (N'Contract')  
  
INSERT INTO Employee (Name, Address, Department, Gender, EmployeeType) VALUES ( N'Thuận', N'Huế', N'IT', 'True', 1)  
INSERT INTO Employee (Name, Address, Department, Gender, EmployeeType) VALUES ( N'Lan', N'Hà Nội', N'IT', 'False', 1)  
INSERT INTO Employee (Name, Address, Department, Gender, EmployeeType) VALUES ( N'Nhã', N'Quảng Ngãi', N'HR', 'True', 1)  
INSERT INTO Employee (Name, Address, Department, Gender, EmployeeType) VALUES ( N'Hương', N'Huế', N'HR', 'False', 3)  
INSERT INTO Employee (Name, Address, Department, Gender, EmployeeType) VALUES ( N'Hiếu', N'Đà Nẵng', N'Marketing', 'True', 3)  

