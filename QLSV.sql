Create Database QuanLySinhVien
on
(
	name = 'D:\WorkSpaces\Lab04\QLSV_Data',
	filename = 'D:\WorkSpaces\Lab04\QLSV.MDF'
)
log on
(
	name = 'D:\WorkSpaces\Lab04\QLSV_Log',
	filename = 'D:\WorkSpaces\Lab04\QLSV.LDF'
)

set dateformat dmy
SET FMTONLY ON;

drop database QuanLySinhVien

use QuanLySinhVien

create table FACULTY(
	FacultyID int not null constraint PK_FACULTY primary key,
	FacultyName nvarchar(200),	
)

create table STUDENT (
	StudentID nvarchar(20) not null constraint PK_STUDENT primary key,
	FullName nvarchar(200),
	AverageScore float,
	FacultyID int,
	constraint FK_STUDENT foreign key(FacultyID) references FACULTY (FacultyID)
)



Drop table FACULTY
go
Drop table STUDENT

insert into FACULTY
values (1, N'Công Nghệ Thông Tin');
insert into FACULTY
values (2, N'Ngôn Ngữ Anh');
insert into FACULTY
values (3, N'Quản Trị Kinh Doanh');
insert into STUDENT
values ('1611061916', N'Nguyễn Trần Hoàng Lan', 4.5, 1);
insert into STUDENT
values ('1711060596', N'Đàm Đức Minh', 2.5, 1);
insert into STUDENT
values ('1711061004', N'Nguyễn Quốc An', 10.0, 2);

