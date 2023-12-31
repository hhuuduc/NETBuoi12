create database QLHN
go
use QLHN
go
 CREATE TABLE LoaiPhong(
   maLoaiPhong  VARCHAR (10) primary key,
   tenLoaiPhong NVARCHAR (30) NOT NULL,     
);
CREATE TABLE HoiNghi(
   maHoiNghi  VARCHAR (10) primary key,
   tenHoiNghi VARCHAR (30)  NULL,
   SoNguoi int, 
   maLoaiPhong  VARCHAR (10) ,  
   Constraint F_LP_HN Foreign key(maLoaiPhong) references LoaiPhong(maLoaiPhong),
);
INSERT LoaiPhong([maLoaiPhong], [tenLoaiPhong]) VALUES ('PHONG_HN', N'Phòng Hội Nghị')
INSERT LoaiPhong([maLoaiPhong], [tenLoaiPhong]) VALUES ('PHONG_HOP', N'Phòng Họp')


INSERT HoiNghi([maHoiNghi], [tenHoiNghi],[SoNguoi],[maLoaiPhong]) VALUES ('HN111', N'OPEN DAY 2018',200,N'PHONG_HN')

INSERT HoiNghi([maHoiNghi], [tenHoiNghi],[SoNguoi],[maLoaiPhong]) VALUES ('HN223', N'Giao lưu cựu sinh viên',240,N'PHONG_HN')

INSERT HoiNghi([maHoiNghi], [tenHoiNghi],[SoNguoi],[maLoaiPhong]) VALUES ('HN421', N'Startup',100,N'PHONG_HOP')

INSERT HoiNghi([maHoiNghi], [tenHoiNghi],[SoNguoi],[maLoaiPhong]) VALUES ('HN522', N'Đại Hội Công Nhân Viên 2018',1000,N'PHONG_HN')
