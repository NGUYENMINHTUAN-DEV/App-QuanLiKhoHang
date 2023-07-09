use master
go
if exists(select name from sysdatabases where name='QUANLYKHOHANG')
drop Database QUANLYKHOHANG
go
Create Database QUANLYKHOHANG
go
use QUANLYKHOHANG
go


/*==============================================================*/
/* Table: KHACH_HANG                                            */
/*==============================================================*/
create table KHACH_HANG 
(
   MAKH                char(10)                       not null,
   TEN_KH               nvarchar(50)                    null,
   DIACHI_KH            Nvarchar(50)                    null,
   GIOITINH_KH          Nvarchar(5)                    null,
   SDT_KH               VARCHAR(12)                        null,
   EMAIL_KH             varchar(50)                    null,
   FAX                  VARCHAR(12)                        null,
   constraint PK_KHACH_HANG primary key (MAKH)
)
go
/*==============================================================*/
/* Table: KHO_HANG                                              */
/*==============================================================*/
create table KHO_HANG 
(
   MAKHO                char(10)                       not null,
   TENKHO               NVARchar(50)                       null,
   DIACHI_KHO           NVARchar(50)                       null,
   GHICHU_KHO           NVARchar(50)                       null,
   constraint PK_KHO_HANG primary key (MAKHO)
)
go

/*==============================================================*/
/* Table: NHAN_VIEN                                             */
/*==============================================================*/
create table NHAN_VIEN 
(
   MANV                 char(10)                       not null,
   TEN_NV               nvarchar(50)                  null,
   EMAIL_NV             varchar(50)                   null,
   NGSINH_NV            date                           null,
   GIOITINH_NV          nvarchar(10)                    null,
   SDT_NV               VARCHAR(12)                        null,
   CHUCVU_NV            nvarchar(50)                    null,
   DIACHI_NV            nvarchar(50)                    null,
   LUONG_NV             FLOAT                        null,
   BOPHAN_NV            nvarchar(50)                    null,
   constraint PK_NHAN_VIEN primary key (MANV)
)
GO
/*==============================================================*/
/* Table: NHA_CUNG_CAP                                          */
/*==============================================================*/
create table NHA_CUNG_CAP 
(
   MA_NCC               char(10)                       not null,
   TEN_NCC              nvarchar(50)                    null,
   DIACHI_NCC           nvarchar(50)                    null,
   constraint PK_NHA_CUNG_CAP primary key (MA_NCC)
)
GO

/*==============================================================*/
/* Table: PHIEU_NHAP_HANG                                       */
/*==============================================================*/
create table PHIEU_NHAP_HANG 
(   
	MAPHIEU_NH           char(10)                       not null,
   NGAY_NH              date                           null,
   TONGTIEN_NH          FLOAT                        null,
   MANV                 char(10)                       null,
   constraint PK_PHIEU_NHAP_HANG primary key (MAPHIEU_NH)
)
GO

/*==============================================================*/
/* Table: PHIEU_XUAT_HANG                                       */
/*==============================================================*/
create table PHIEU_XUAT_HANG 
(  
	MAPH_XH              char(10)                       not null,
   NGAY_XH              date                           null,
   TONGTIEN_XH          FLOAT                        null,
   MAKH                 char(10)                       null,
   MANV                 char(10)                       null,
   constraint PK_PHIEU_XUAT_HANG primary key (MAPH_XH)
)
GO

------------------- LOAI --------------------
CREATE TABLE LOAISP
(	
	MALOAI CHAR(10),
	TENLOAI NVARCHAR(50),
	PRIMARY KEY(MALOAI)
)
GO
/*==============================================================*/
/* Table: SAN_PHAM                                              */
/*==============================================================*/
create table SAN_PHAM 
(
   MA_SP                char(10)                       not null,
   MA_NCC               char(10)                       null,
   TEN_SP               nvarchar(50)                    null,
   NGAYSX               date                           null,
   HSD                  date                           null,
   SOLUONG_SP           INT                        null,
	MALOAI CHAR(10),	
   GIA                  INT                        null,
   GHICHU_SP            nvarchar(50)                    null,
   MAKHO CHAR(10),
   ANH Image ,
   constraint PK_SAN_PHAM primary key (MA_SP)
)
GO
--- CHI TIET NHAP HANG -----------
CREATE TABLE CHITIET_NH
(
	MAPHIEU_NH CHAR(10),
	MA_SP CHAR(10),
	SOLUONG INT,
	THANHTIEN FLOAT,
	PRIMARY KEY(MAPHIEU_NH,MA_SP)
)
GO

--- CHI TIET XUAT HANG ---
CREATE TABLE CHITIET_XH
(
	MAPH_XH CHAR(10),
	MA_SP CHAR(10),
	SOLUONG INT,
	THANHTIEN FLOAT,
	PRIMARY KEY(MAPH_XH,MA_SP)
)
GO
---
CREATE TABLE TAI_KHOAN
(
	TK CHAR(10) NOT NULL,
	MK CHAR(15),
	EMAIL NVARCHAR(50),
	QUYEN CHAR(10),
	PRIMARY KEY(TK)
)
GO
---------------- CONSTRAINT ---------------
ALTER TABLE CHITIET_NH
ADD
	CONSTRAINT FK_CTNH_NH FOREIGN KEY(MAPHIEU_NH) REFERENCES PHIEU_NHAP_HANG(MAPHIEU_NH)
ALTER TABLE CHITIET_NH
ADD
	CONSTRAINT FK_CTNH_SP FOREIGN KEY(MA_SP) REFERENCES SAN_PHAM(MA_SP)

ALTER TABLE CHITIET_XH
ADD
	CONSTRAINT FK_CTXH_XH FOREIGN KEY(MAPH_XH) REFERENCES PHIEU_XUAT_HANG(MAPH_XH),
	CONSTRAINT FK_CTXH_SP FOREIGN KEY(MA_SP) REFERENCES SAN_PHAM(MA_SP)


alter table SAN_PHAM
add 
	constraint FK_SP_KHO foreign key (MAKHO) references KHO_HANG (MAKHO),
	constraint FK_SP_NCC foreign key (MA_NCC) references NHA_CUNG_CAP (MA_NCC),
	constraint FK_SP_LOAI foreign key (MALOAI) references LOAISP(MALOAI)

ALTER TABLE PHIEU_NHAP_HANG
ADD	
	constraint FK_NH_NV foreign key (MANV) references NHAN_VIEN (MANV)

alter table PHIEU_XUAT_HANG
   add constraint FK_XH_NV foreign key (MANV)
      references NHAN_VIEN (MANV)

ALTER TABLE PHIEU_XUAT_HANG
ADD CONSTRAINT FK_XH_KH FOREIGN KEY(MAKH) REFERENCES KHACH_HANG(MAKH)


---===============================INSERT DỮ LIỆU=======================================
---insert khach Hang
insert into KHACH_HANG
values ('KH001', N'NGUYỄN MINH TUẤN',N'CỦ CHI',N'NAM','0851478532','minhtuan@gmail.com','0001'),
	   ('KH002', N'TRẦN THANH NAM',N'GIA LAI',N'NAM','0857845522','thanhnam22@gmail.com','0002'),
	   ('KH003', N'VÕ THỊ HUỲNH NHƯ',N'TRÀ VINH',N'NỮ','085147652','vothihuynhnhu.22042002@gmail.com','0003'),
	   ('KH004', N'BÙI LÊ THANH NGÂN',N'SÓC TRĂNG',N'NỮ','082684852','thanhnqan@gmail.com','0004'),
	   ('KH005', N'TRẦN MẠNH CƯỜNG',N'ĐỒNG THÁP',N'NAM','085147741','manhcuongtran@gmail.com','0005'),
	   ('KH006', N'DƯƠNG QUANG DŨNG',N'NGHỆ AN',N'NAM','085165423','dungquangwd@gmail.com','0006'),
	   ('KH007', N'NGUYỄN LÊ THẢO AN',N'LẠNG SƠN',N'NỮ','085146742','anbabe@gmail.com','0007'),
	   ('KH008', N'ĐỖ TRÍ PHÚC',N'THÁI BÌNH',N'NAM','085147451','phucdo@gmail.com','0008'),
	   ('KH009', N'TRẦN TUẤN KHANH',N'PHÚ YÊN',N'NAM','08627852','khanhtran@gmail.com','0009'),
	   ('KH010', N'TẠ THANH TRÚC',N'KHÁNH HÒA',N'NỮ','085187452','threeti@gmail.com','0010')
select * from KHACH_HANG

insert into KHO_HANG
VALUES ('K01', N'KHO LONG XUYÊN',N'AN GIANG',N'Chỉ nhận nước uống đóng chai'),
	   ('K02', N'KHO BÀ RỊA',N'BÀ RỊA - VŨNG TÀU',N'Chỉ nhận các loại hải sản'),
	   ('K03', N'KHO BẠC LIÊU',N'BẠC LIÊU',N'Nhận các đồ dùng nội thất'),
	   ('K04', N'KHO BẮC GIANG',N'BẮC GIANG',N'Chỉ nhận sữa'),
	   ('K05', N'KHO BẾN TRE',N'BẾN TRE',N'Chỉ nhận sản phẩm mỹ nghệ làm từ dừa'),
	   ('K06', N'KHO THỦ DẦU MỘT',N'BÌNH DƯƠNG',N'Nhận tất cả trái cây tươi trừ vải thiều'),
	   ('K07', N'KHO QUY NHƠN',N'BÌNH ĐỊNH',N'Chỉ nhận tinh dầu thiên nhiên'),
	   ('K08', N'KHO ĐỒNG XOÀI',N'BÌNH PHƯỚC',N'Nhận các linh kiện điện tử'),
	   ('K09', N'KHO PHAN THIẾT',N'BÌNH THUẬN',N'Chỉ nhận mỹ phẩm'),
	   ('K10', N'KHO NINH KIỀU',N'CẦN THƠ',N'Chỉ nhận rau, củ, quả tươi')
	   SELECT * FROM KHO_HANG
insert into NHA_CUNG_CAP
values ('NCC01',N'CÔNG TY NHẬP KHẨU TRÁI CÂY V-FOOD VIỆT NAM',N'HÀ NỘI'),
	   ('NCC02',N'CÔNG TY CỔ PHẦN RAU QUẢ TIỀN GIANG',N'TIỀN GIANG'),
	   ('NCC03',N'CÔNG TY CỔ PHẦN HẢI SẢN ĐÔNG LẠNH',N'BÌNH DƯƠNG'),
	   ('NCC04',N'CÔNG TY TNHH SUNTORY PEPSICO VIỆT NAM',N'HỒ CHÍ MINH'),
	   ('NCC05',N'CÔNG TY TNHH HANDMADE VIỆT NAM',N'HỒ CHÍ MINH'),
	   ('NCC06',N'CÔNG TY MỸ PHẨM ORGANIC',N'HÀ NỘI'),
	   ('NCC07',N'CÔNG TY NỘI THẤT TRUNG ĐÔNG',N'ĐÀ NẴNG'),
	   ('NCC08',N'CÔNG TY TNHH ĐIỆN TỬ ABECO VIỆT NAM',N'HÀ NỘI'),
	   ('NCC09',N'CÔNG TY TNHH NESTLE VIỆT NAM',N'HỒ CHÍ MINH'),
	   ('NCC10',N'CÔNG TY CỔ PHẦN TINH DẦU AVAN',N'HẢI PHÒNG')
 SELECT * FROM NHA_CUNG_CAP
 SET DATEFORMAT DMY
INSERT INTO NHAN_VIEN
values ('NV01', N'TRẦN HOÀI PHONG', 'hoaiphong@gmail.com','29/01/2000',N'NAM',085963258,N'Nhân viên kiểm hàng',N'CẦN THƠ',3000000,N'KIỂM HÀNG'),
	   ('NV02', N'LƯƠNG MẠNH CƯỜNG', 'manhcuong@gmail.com','20/02/2000',N'NAM',084785625,N'Nhân viên kiểm hàng',N'SÓC TRĂNG',3000000,N'KIỂM HÀNG'),
	   ('NV03', N'TRẦN XUÂN NHI', 'nhicutegird@gmail.com','12/04/2000',N'NỮ',0854796823,N'Nhân viên nhập hàng',N'HỒ CHÍ MINH',2500000,N'NHẬP HÀNG'),
	   ('NV04', N'LÊ HOÀNG TIẾN', 'hoangtienle@gmail.com','23/06/2002',N'NAM',0853214569,N'Nhân viên nhập hàng',N'TIỀN GIANG',2500000,N'NHẬP HÀNG'),
	   ('NV05', N'TRẦN ĐỨC PHÚC', 'ducphuctran@gmail.com','15/07/2001',N'NAM',0857453298,N'Nhân viên nhập hàng',N'AN GIANG',2500000,N'NHẬP HÀNG'),
	   ('NV06', N'THÁI THANH ĐÀN', 'danthai@gmail.com','06/03/2001',N'NAM',0862457896,N'Nhân viên nhập hàng',N'BẾN NGHÉ',2500000,N'NHẬP HÀNG'),
	   ('NV07', N'NGUYỄN TRẦN TRUNG QUÂN', 'quantran@gmail.com','14/02/2001',N'NAM',0859683258,N'Nhân viên xuất hàng',N'CHÂU ĐỐC',2500000,N'XUẤT HÀNG'),
	   ('NV08', N'LÊ KIM PHỤNG', 'phungkim@gmail.com','23/01/2001',N'NỮ',0781246088,N'Nhân viên xuất hàng',N'KHÁNH HÒA',2500000,N'XUẤT HÀNG'),
	   ('NV09', N'PHẠM KHÁNH AN', 'khanhan@gmail.com','26/05/2002',N'NỮ',0915789111,N'Nhân viên xuất hàng',N'YÊN BÁI',2500000,N'XUẤT HÀNG'),
	   ('NV10', N'LƯU HÀ TRINH', 'trinhha@gmail.com','28/12/2001',N'NỮ',083628787,N'Nhân viên xuất hàng',N'ĐỒNG THÁP',2500000,N'XUẤT HÀNG')
select * from NHAN_VIEN
INSERT INTO TAI_KHOAN
VALUES ('TuanNguyen','123','tuannguyen@gmail.com','Admin'),
	   ('NamTran','4568','namtranu@gmail.com','Admin'),
	   ('NhuVo','7812','nhuvo@gmail.com','Admin'),
	   ('NqanBui','3534','nganbui@gmail.com','User'),
	   ('CuongManh','4352','manhcuong@gmail.com','User'),
	   ('DungQuang','2346','dungquang@gmail.com','User'),
	   ('AnThao','3462','anthao@gmail.com','User'),
	   ('PhucDo','2452','phucdo@gmail.com','User'),
	   ('KhanhTran','2546','khanhtran@gmail.com','User'),
	   ('TrucTa','2345','tructa@gmail.com','User')
select * from TAI_KHOAN



INSERT INTO LOAISP
VALUES  ('L01',N'HẢI SẢN'),
		('L02',N'TRÁI CÂY'),
		('L03',N'NƯỚC UỐNG ĐÓNG CHAI'),
		('L04',N'ĐỒ DÙNG THỦ CÔNG'),
		('L05',N'LINH KIỆN ĐIỆN TỬ'),
		('L06',N'MỸ PHẨM'),
		('L07',N'RAU, CỦ, QUẢ'),
		('L08',N'TINH DẦU THIÊN NHIÊN'),
		('L09',N'NỘI THẤT'),
		('L10',N'SỮA')
SELECT * FROM LOAISP

SET DATEFORMAT DMY
INSERT INTO PHIEU_NHAP_HANG
VALUES  ('PN001','06/06/2020','2000000','NV03'),
		('PN002','22/08/2020','1800000','NV04'),
		('PN003','13/05/2021','45300000','NV05'),
		('PN004','19/07/2021','1500000','NV06'),
		('PN005','30/11/2021','3900000','NV03'),
		('PN006','02/01/2022','19900000','NV04'),
		('PN007','10/03/2022','11800000','NV05'),
		('PN008','15/04/2022','69750000','NV06'),
		('PN009','20/05/2022','34980000','NV03'),
		('PN010','28/07/2022','15000000','NV06')
SELECT * FROM PHIEU_NHAP_HANG

SET DATEFORMAT DMY
INSERT INTO PHIEU_XUAT_HANG
VALUES  ('PX001','06/07/2020','50','KH001','NV07'),
		('PX002','22/09/2020','75','KH002','NV08'),
		('PX003','13/06/2021','100','KH003','NV09'),
		('PX004','19/08/2021','100','KH004','NV10'),
		('PX005','30/12/2021','125','KH005','NV07'),
		('PX006','02/02/2022','110','KH006','NV08'),
		('PX007','10/04/2022','60','KH007','NV09'),
		('PX008','15/05/2022','75','KH008','NV10'),
		('PX009','20/06/2022','100','KH009','NV07'),
		('PX010','28/08/2022','125','KH010','NV10')
SELECT * FROM PHIEU_XUAT_HANG

SET DATEFORMAT DMY
INSERT INTO SAN_PHAM
VALUES  ('SP001','NCC01',N'TÁO ĐỎ','22/10/2021','22/11/2021','100','L02',20000,N'Táo đỏ bảo quản lạnh','K06',NULL),
		('SP002','NCC02',N'BÍ NGÔ','02/01/2022','02/02/2022','100','L07',15000,N'Bí ngô 1 bao 10kg','K10',NULL),
		('SP003','NCC03',N'TÔM CÀNG XANH','10/05/2022','15/05/2022','100','L01',300000,N'Tôm càng xanh loại 1','K02',NULL),
		('SP004','NCC04',N'STING','03/06/2022','03/06/2023','200','L03',10000,N'Sting đỏ 1 thùng 24 chai','K01',NULL),
		('SP005','NCC05',N'BỘ ẤM TRÀ','11/10/2022','11/10/2028','50','L04',39000,N'Bộ ấm trà làm thủ công từ dừa','K05',NULL),
		('SP006','NCC06',N'SON MERZY','15/06/2022','15/06/2023','300','L06',199000,N'Son dạng thỏi','K09',NULL),
		('SP007','NCC07',N'GƯƠNG TREO TƯỜNG','22/12/2020','22/12/2030','150','L09',59000,N'Gương có cảm biến đèn led','K03',NULL),
		('SP008','NCC08',N'BÀN PHÍM MÁY TÍNH','07/09/2022','07/09/2025','250','L05',279000,N'Bàn phím có 6 chế độ chuyển màu đèn led','K08',NULL),
		('SP009','NCC09',N'SỮA MILO','18/09/2022','18/09/2023','100','L10',159000,N'Thùng 24 lốc','K04',NULL),
		('SP010','NCC10',N'TINH DẦU SẢ CHANH','04/06/2022','04/06/2024','200','L08',150000,N'Tinh dầu nguyên chất thiên nhiên','K07',NULL)

SELECT * FROM SAN_PHAM
INSERT INTO CHITIET_NH
VALUES  ('PN001','SP001','100',2000000),
		('PN002','SP002','120',1800000),
		('PN003','SP003','150',45300000),
		('PN004','SP004','150',1500000),
		('PN005','SP005','100',3900000),
		('PN006','SP006','100',19900000),
		('PN007','SP007','200',11800000),
		('PN008','SP008','250',69750000),
		('PN009','SP009','220',34980000),
		('PN010','SP010','100',15000000)
select * from CHITIET_NH

INSERT INTO CHITIET_XH
VALUES  ('PX001','SP001','50',1000000),
		('PX002','SP002','60',900000),
		('PX003','SP003','75',22500000),
		('PX004','SP004','75',750000),
		('PX005','SP005','50',1950000),
		('PX006','SP006','50',9950000),
		('PX007','SP007','100',5900000),
		('PX008','SP008','125',34875000),
		('PX009','SP009','110',17490000),
		('PX010','SP010','50',7500000)

		select * from PHIEU_NHAP_HANG
		select * from SAN_PHAM
		select * from CHITIET_NH

--=======================DEFAULT, CHECK=========================================
ALTER TABLE CHITIET_NH
ADD CONSTRAINT DF_SL DEFAULT 0 FOR SOLUONG
ALTER TABLE CHITIET_NH
ADD CONSTRAINT C_SLNH CHECK (SOLUONG >= 0)
ALTER TABLE CHITIET_XH
ADD CONSTRAINT C_SLXH CHECK (SOLUONG >= 0)
ALTER TABLE NHAN_VIEN
ADD CONSTRAINT C_LUONGNV CHECK (LUONG_NV >= 1000)
---=================================Các trigger======================================
--Cập nhật số lượng khi insert chi tiet nhap hang
create trigger CN_soluong_NH_INSERT
on CHITIET_NH
for insert
as
begin
	declare @a int =( select SOLUONG from inserted)
	update SAN_PHAM set SOLUONG_SP=SOLUONG_SP+@a where MA_SP= (select MA_SP from inserted)
end
--DROP TRIGGER CN_soluong_NH_INSERT 
--SELECT * FROM SAN_PHAM

--Cập nhật số lượng khi insert chi tiet xuat hang
create trigger CN_soluong_XH_INSERT
on CHITIET_XH
for insert
as
begin
	declare @a int =( select SOLUONG from inserted)
	update SAN_PHAM set SOLUONG_SP=SOLUONG_SP-@a where MA_SP= (select MA_SP from inserted)
end
--DROP TRIGGER CN_soluong_XH_INSERT
--SELECT * FROM SAN_PHAM



----- Cập nhật số lượng sản phẩm khi xuất hàng-------
create trigger CN_soluong_XH
on CHITIET_XH
for insert,update
as
begin
declare @old_sl int ,@new_sl int,@code nvarchar(10)
select @old_sl =deleted.SOLUONG
from deleted 
select @new_sl=inserted.SOLUONG,@code=inserted.MA_SP
from inserted
if @old_sl<>@new_sl
	begin 
	update SAN_PHAM
	SET SOLUONG_SP=(SELECT SOLUONG_SP FROM SAN_PHAM WHERE MA_SP=@code)-(@old_sl-@new_sl)
	from SAN_PHAM,CHITIET_XH
	where SAN_PHAM.MA_SP=@code and SAN_PHAM.MA_SP=CHITIET_XH.MA_SP
	end
END
select * from SAN_PHAM
select * from CHITIET_XH
--DROP TRIGGER CN_soluong_XH

------- Cập nhật số lượng sản phẩm khi nhập hàng
create trigger CN_soluong_NH
on CHITIET_NH
for insert,update
as
begin
	declare @old_sl int ,@new_sl int,@code nvarchar(10)
	select @old_sl =deleted.SOLUONG
	from deleted 
	select @new_sl=inserted.SOLUONG,@code=inserted.MA_SP
	from inserted
	if @old_sl<>@new_sl
		begin
			update SAN_PHAM
			SET SOLUONG_SP=(SELECT SOLUONG_SP FROM SAN_PHAM WHERE MA_SP=@code)+(@new_sl-@old_sl)
			from SAN_PHAM,CHITIET_NH
			where SAN_PHAM.MA_SP=@code and SAN_PHAM.MA_SP=CHITIET_NH.MA_SP
		end
end
--DROP TRIGGER CN_soluong_NH
--TỔNG TIỀN PHIẾU NHẬP HÀNG
create trigger tongtienphieunhap
on CHITIET_NH
FOR INSERT,UPDATE
AS
BEGIN
	IF EXISTS (SELECT * FROM inserted)
		update PHIEU_NHAP_HANG
		SET TONGTIEN_NH = (SELECT SUM(THANHTIEN) FROM CHITIET_NH WHERE CHITIET_NH.MAPHIEU_NH = PHIEU_NHAP_HANG.MAPHIEU_NH)
END

--TỔNG THÀNH TIỀN CHI TIẾT PHIẾU NHẬP KHI THAY ĐỔI SỐ LƯỢNG

create trigger TongTT_CHITIETPN
ON CHITIET_NH
for insert, update
as
begin
	declare @old_sl int , @new_sl int , @code nvarchar(50)
	select @old_sl = deleted.SOLUONG
	from deleted
	select @new_sl = inserted.SOLUONG , @code = inserted.MA_SP
	from inserted
	IF EXISTS (SELECT * FROM inserted)
	begin
		update CHITIET_NH
		set thanhtien = @new_sl * SAN_PHAM.GIA
		from san_pham, CHITIET_NH
		where SAN_PHAM.MA_SP = @code
		and SAN_PHAM.MA_SP = CHITIET_NH.MA_SP
	end
end
--TỔNG TIỀN PHIẾU XUẤT HÀNG
create trigger tongtienphieuXUAT
on CHITIET_XH
FOR INSERT,UPDATE
AS
BEGIN
	IF EXISTS (SELECT * FROM inserted)
		update PHIEU_XUAT_HANG
		SET TONGTIEN_XH = (SELECT SUM(THANHTIEN) FROM CHITIET_XH WHERE CHITIET_XH.MAPH_XH = PHIEU_XUAT_HANG.MAPH_XH)
END
--drop trigger tongtienphieuXUAT
--TỔNG THÀNH TIỀN CHI TIẾT PHIẾU XUẤT KHI THAY ĐỔI SỐ LƯỢNG
CREATE trigger TongTT_CHITIETPX
ON CHITIET_XH
for insert, update
as
begin
	declare @old_sl int , @new_sl int , @code nvarchar(50)
	select @old_sl = deleted.SOLUONG
	from deleted
	select @new_sl = inserted.SOLUONG , @code = inserted.MA_SP
	from inserted
	IF EXISTS (SELECT * FROM inserted)
	begin
		update CHITIET_XH
		set thanhtien = @new_sl * SAN_PHAM.GIA
		from san_pham, CHITIET_XH
		where SAN_PHAM.MA_SP = @code
		and SAN_PHAM.MA_SP = CHITIET_XH.MA_SP
	end
end
--DROP TRIGGER TongTT_CHITIETPX
--TỔNG THÀNH TIỀN SẢN PHẨM KHI THAY ĐỔI ĐƠN GIÁ SẢN PHẨM
create trigger TongTT_SANPHAM
ON SAN_PHAM
for insert, update
as
begin
	declare @old_gia int , @new_gia int , @code nvarchar(50)
	select @old_gia = deleted.GIA
	from deleted
	select @new_gia = inserted.GIA , @code = inserted.MA_SP
	from inserted
	IF EXISTS (SELECT * FROM inserted)
	begin
		update CHITIET_NH
		set thanhtien = @new_gia * CHITIET_NH.SOLUONG
		from SAN_PHAM, CHITIET_NH
		where SAN_PHAM.MA_SP = @code
		and SAN_PHAM.MA_SP = CHITIET_NH.MA_SP
	end
end

-------------------------------------------DANH SÁCH BẰNG PROC--------------------------------------------------------
--IN DANH SÁCH SẢN PHẨM
CREATE PROC danhsachsanpham
as
begin
select * from SAN_PHAM
end
--IN DANH SÁCH KHÁCH HÀNG
CREATE PROC danhsachkhachhang
as
begin
select * from KHACH_HANG
end
--IN DANH SÁCH NHÂN VIÊN
CREATE PROC danhsachnhanvien
as
begin
select * from NHAN_VIEN
end
--IN DANH SÁCH KHO HÀNG
CREATE PROC danhsachkhohang
as
begin
select * from KHO_HANG
end
--IN DANH SÁCH LOẠI SP
CREATE PROC danhsachloaisp
as
begin
select * from LOAISP
end
--IN DANH SÁCH NHÀ CUNG CẤP
CREATE PROC danhsachnhacungcap
as
begin
select * from NHA_CUNG_CAP
end
--IN DANH SÁCH PHIẾU NHẬP HÀNG
CREATE PROC danhsachphieunhaphang
as
begin
select * from PHIEU_NHAP_HANG
end
--IN DANH SÁCH PHIẾU XUẤT HÀNG
CREATE PROC danhsachphieuxuathang
as
begin
select * from PHIEU_XUAT_HANG
end
--IN DANH SÁCH CHI TIẾT XUẤT HÀNG
CREATE PROC danhsachchitietphieuxuat
as
begin
select * from CHITIET_XH
end
--IN DANH SÁCH CHI TIẾT NHẬP HÀNG
CREATE PROC danhsachchitietphieunhap
as
begin
select * from CHITIET_NH
end

------------------------------------------INSERT UPDATE DELETE-----------------------------------------------
SELECT * FROM CHITIET_NH
-------------------------------CHITIET_NH--------------------
----INSERT 
CREATE PROC INSERT_CHITIET_NH @MAPHIEUNH NCHAR(20),@MASP NCHAR(20),@SOLUONG INT ,@THANHTIEN FLOAT
AS
BEGIN
INSERT INTO CHITIET_NH VALUES(@MAPHIEUNH,@MASP,@SOLUONG,@THANHTIEN)
END
EXEC INSERT_CHITIET_NH 'PN006','SP005',30,5000
---- UPDATE 
CREATE PROC UPDATE_CHITIET_NH @MAPHIEUNH NCHAR(20),@MASP NCHAR(20),@SOLUONG INT 
AS
BEGIN 
UPDATE CHITIET_NH
SET SOLUONG=@SOLUONG 
WHERE MAPHIEU_NH=@MAPHIEUNH AND MA_SP=@MASP
END 
EXEC UPDATE_CHITIET_NH 'PN006','SP006',30
----DELETE 
CREATE PROC DELETE_CHITIET_NH @MAPHIEUNH NCHAR(20),@MASP NCHAR(20)
AS
BEGIN 
DELETE CHITIET_NH
WHERE MAPHIEU_NH =@MAPHIEUNH AND MA_SP=@MASP
END
EXEC DELETE_CHITIET_NH 'PN006','SP005'
--
--	
----------------------CHITIET_XH---------------------------

SELECT* FROM CHITIET_XH
----INSERT 
CREATE PROC INSERT_CHITIET_XH @MAPH_XH NCHAR(20),@MASP NCHAR(20),@SOLUONG INT ,@THANHTIEN FLOAT
AS
BEGIN
INSERT INTO CHITIET_XH VALUES(@MAPH_XH,@MASP,@SOLUONG,@THANHTIEN)
END
EXEC INSERT_CHITIET_XH 'PN006','SP005',30,5000
---- UPDATE 
CREATE PROC UPDATE_CHITIET_XH @MAPH_XH NCHAR(20),@MASP NCHAR(20),@SOLUONG INT 
AS
BEGIN 
UPDATE CHITIET_XH
SET SOLUONG=@SOLUONG 
WHERE MAPH_XH=@MAPH_XH AND MA_SP=@MASP
END 
EXEC UPDATE_CHITIET_XH 'PN006','SP006',30
----DELETE 
CREATE PROC DELETE_CHITIET_XH @MAPH_XH NCHAR(20),@MASP NCHAR(20)
AS
BEGIN 
DELETE CHITIET_XH
WHERE MAPH_XH =@MAPH_XH AND MA_SP=@MASP
END
EXEC DELETE_CHITIET_XH 'PN006','SP005'
--
--
----------------------KHÁCH HÀNG--------------------------
---INSERT--
SELECT *FROM KHACH_HANG
CREATE PROC INSERT_KHACH_HANG @MAKH NCHAR(10),@TENKH NVARCHAR(50),@DIACHI NVARCHAR(50),@GIOITINH NVARCHAR(10),@SDT CHAR(20),@EMAIL NVARCHAR(50),@FAX NCHAR(10)
AS
BEGIN
INSERT INTO KHACH_HANG VALUES(@MAKH,@TENKH,@DIACHI,@GIOITINH,@SDT,@EMAIL,@FAX)
END 
--UPDATE--
CREATE PROC UPDATE_KHACH_HANG @MAKH NCHAR(10),@TENKH NVARCHAR(50),@DIACHI NVARCHAR(50),@GIOITINH NVARCHAR(10),@SDT CHAR(20),@EMAIL NVARCHAR(50),@FAX NCHAR(10)
AS
BEGIN
UPDATE KHACH_HANG 
SET TEN_KH=@TENKH,DIACHI_KH=@DIACHI,GIOITINH_KH=@GIOITINH,SDT_KH=@SDT,EMAIL_KH=@EMAIL,FAX=@FAX
WHERE MAKH=@MAKH
END 
--DELETE--
CREATE PROC DELETE_KHACH_HANG @MAKH NCHAR(10)
AS
BEGIN
DELETE KHACH_HANG
WHERE MAKH=@MAKH
END 
--
--
---------------------------KHO HÀNG--------------------------
SELECT* FROM KHO_HANG
--INSERT--
CREATE PROC INSERT_KHO_HANG @MAKHO NCHAR(10),@TENKHO NVARCHAR(50),@DIACHI NVARCHAR(50),@GHICHU NVARCHAR(100)
AS
BEGIN
INSERT INTO KHO_HANG VALUES (@MAKHO,@TENKHO,@DIACHI,@GHICHU)
END
--UPDATE
CREATE PROC UPDATE_KHO_HANG @MAKHO NCHAR(10),@TENKHO NVARCHAR(50),@DIACHI NVARCHAR(50),@GHICHU NVARCHAR(100)
AS
BEGIN
UPDATE KHO_HANG
SET TENKHO=@TENKHO,DIACHI_KHO=@DIACHI,GHICHU_KHO=@GHICHU
WHERE MAKHO=@MAKHO
END
--DELETE
CREATE PROC DELETE_KHO_HANG @MAKHO NCHAR(10)
AS
BEGIN
DELETE KHO_HANG
WHERE MAKHO=@MAKHO
END
--
--
-------------LỌAI SẢN PHẨM------------------
SELECT *FROM LOAISP
--INSERT
CREATE PROC INSERT_LOAISP @MALOAI NCHAR(10), @TENLOAI NVARCHAR(50)
AS
BEGIN
INSERT INTO LOAISP VALUES (@MALOAI,@TENLOAI)
END
--UPDATE-
CREATE PROC UPDATE_LOAISP @MALOAI NCHAR(10), @TENLOAI NVARCHAR(50)
AS
BEGIN
UPDATE LOAISP
SET TENLOAI=@TENLOAI
WHERE MALOAI=@MALOAI
END
--DELETE
CREATE PROC DELETE_LOAISP @MALOAI NCHAR(10)
AS
BEGIN
DELETE LOAISP
WHERE MALOAI=@MALOAI
END
--
--
------------------------------NHÀ CUNG CẤP -------------------------
SELECT * FROM NHA_CUNG_CAP
--INSERT-
CREATE PROC INSERT_NHA_CUNG_CAP @MA_NCC CHAR(10),@TEN_NCC NVARCHAR(50),@DICHI_NCC NVARCHAR(50)
AS
BEGIN 
INSERT INTO NHA_CUNG_CAP VALUES(@MA_NCC,@TEN_NCC,@DICHI_NCC)
END
--UPDATE
CREATE PROC UPDATE_NHA_CUNG_CAP @MA_NCC CHAR(10),@TEN_NCC NVARCHAR(50),@DICHI_NCC NVARCHAR(50)
AS
BEGIN 
UPDATE NHA_CUNG_CAP
SET TEN_NCC=@TEN_NCC,DIACHI_NCC=@DICHI_NCC
WHERE MA_NCC=@MA_NCC
END
--DELETE
CREATE PROC DELETE_NHA_CUNG_CAP @MA_NCC CHAR(10)
AS
BEGIN 
DELETE NHA_CUNG_CAP
WHERE MA_NCC=@MA_NCC
END
--
--
------------------------------NHÂN VIÊN----------------------------
SELECT* FROM NHAN_VIEN
--INSERT
CREATE PROC INSERT_NHAN_VIEN @MANV CHAR(10),@TEN_NV NVARCHAR(50),@EMAIL_NV NVARCHAR(50),@NGSINH_NV NCHAR(30),@GIOITINH_NV NVARCHAR(10),@SDT_NV CHAR(20),@CHUCVU_NV NVARCHAR(50),@DIACHI_NV NVARCHAR(50),@LUONG_NV FLOAT,@BOPHAN_NV NVARCHAR(50)
AS
BEGIN
SET DATEFORMAT DMY
INSERT INTO NHAN_VIEN VALUES(@MANV,@TEN_NV,@EMAIL_NV,@NGSINH_NV,@GIOITINH_NV,@SDT_NV,@CHUCVU_NV,@DIACHI_NV,@LUONG_NV,@BOPHAN_NV)
END
--UPDATE 
CREATE PROC UPDATE_NHAN_VIEN @MANV CHAR(10),@TEN_NV NVARCHAR(50),@EMAIL_NV NVARCHAR(50),@NGSINH_NV NCHAR(30),@GIOITINH_NV NVARCHAR(10),@SDT_NV CHAR(20),@CHUCVU_NV NVARCHAR(50),@DIACHI_NV NVARCHAR(50),@LUONG_NV FLOAT,@BOPHAN_NV NVARCHAR(50)
AS
BEGIN
UPDATE NHAN_VIEN
SET TEN_NV=@TEN_NV,EMAIL_NV=@EMAIL_NV,NGSINH_NV=@NGSINH_NV,GIOITINH_NV=@GIOITINH_NV,SDT_NV=@SDT_NV,CHUCVU_NV=@CHUCVU_NV,DIACHI_NV=@DIACHI_NV,LUONG_NV=@LUONG_NV,BOPHAN_NV=@BOPHAN_NV
WHERE MANV=@MANV
END
--DELETE
CREATE PROC DELETE_NHAN_VIEN @MANV CHAR(10)
AS
BEGIN
DELETE NHAN_VIEN
WHERE MANV=@MANV
END
--
--
----------------------------PHIEU NHAP HANG----------------------------------------
SELECT *FROM PHIEU_NHAP_HANG
--INSERT
CREATE PROC INSERT_PHIEU_NHAPHANG @MAPHIEU_NH CHAR(10),@NGAY_NH NCHAR(20) ,@TONGTIEN_NH FLOAT ,@MANV NCHAR(10)
AS
BEGIN
SET DATEFORMAT DMY
INSERT INTO PHIEU_NHAP_HANG VALUES(@MAPHIEU_NH,@NGAY_NH,@TONGTIEN_NH,@MANV)
END
--UPDATE
CREATE PROC UPDATE_PHIEU_NHAPHANG @MAPHIEU_NH CHAR(10),@NGAY_NH NCHAR(20),@TONGTIEN_NH FLOAT ,@MANV NCHAR(10)
AS
BEGIN
UPDATE PHIEU_NHAP_HANG
SET NGAY_NH=@NGAY_NH,TONGTIEN_NH=@TONGTIEN_NH,MANV=@MANV
WHERE MAPHIEU_NH=@MAPHIEU_NH
END 
--DELETE
CREATE PROC DELETE_PHIEU_NHAPHANG @MAPHIEU_NH CHAR(10)
AS
BEGIN
DELETE PHIEU_NHAP_HANG
WHERE MAPHIEU_NH=@MAPHIEU_NH
END 
--
--
------------------------------PHIẾU XUẤT HÀNG--------------------
SELECT *FROM PHIEU_XUAT_HANG
--INSERT
CREATE PROC INSERT_PHIEU_XUATHANG @MAPH_XH CHAR(10),@NGAY_XH NCHAR(20) ,@TONGTIEN_XH FLOAT ,@MAKH NVARCHAR(10),@MANV NCHAR(10)
AS
BEGIN
SET DATEFORMAT DMY
INSERT INTO PHIEU_XUAT_HANG VALUES(@MAPH_XH,@NGAY_XH,@TONGTIEN_XH,@MAKH,@MANV)
END
--UPDATE
CREATE PROC UPDATE_PHIEU_XUATHANG @MAPH_XH CHAR(10),@NGAY_XH NCHAR(20),@TONGTIEN_XH FLOAT ,@MANV NCHAR(10),@MAKH NVARCHAR(10)
AS
BEGIN
UPDATE PHIEU_XUAT_HANG
SET NGAY_XH=@NGAY_XH,TONGTIEN_XH=@TONGTIEN_XH,MANV=@MANV,MAKH=@MAKH
WHERE MAPH_XH=@MAPH_XH
END 
--DELETE
CREATE PROC DELETE_PHIEU_XUATHANG @MAPH_XH CHAR(10)
AS
BEGIN
DELETE PHIEU_XUAT_HANG
WHERE MAPH_XH=@MAPH_XH
END 
--
--
-------------------------------SẢN PHẨM---------------------------------
SELECT *FROM SAN_PHAM
--INSERT
CREATE PROC INSERT_SAN_PHAM @MA_SP CHAR(10),@MANCC CHAR(10),@TEN_SP NVARCHAR(50),@NGAYSX VARCHAR(20),@HSD VARCHAR(20),@SOLUONG_SP INT,@MALOAI CHAR(10),@GIA FLOAT,@GHICHU_SP NVARCHAR(50),@MAKHO CHAR(10), @ANH IMAGE
AS
BEGIN 
SET DATEFORMAT DMY
INSERT INTO SAN_PHAM VALUES(@MA_SP,@MANCC,@TEN_SP,@NGAYSX,@HSD,@SOLUONG_SP,@MALOAI,@GIA,@GHICHU_SP,@MAKHO,@ANH)
END
--UPDATE 
CREATE PROC UPDATE_SAN_PHAM @MA_SP CHAR(10),@MANCC CHAR(10),@TEN_SP NVARCHAR(50),@NGAYSX VARCHAR(20),@HSD VARCHAR(20),@SOLUONG_SP INT,@MALOAI CHAR(10),@GIA FLOAT,@GHICHU_SP NVARCHAR(50),@MAKHO CHAR(10), @ANH IMAGE
AS
BEGIN 
UPDATE SAN_PHAM
SET MA_NCC=@MANCC,TEN_SP=@TEN_SP,NGAYSX=@NGAYSX,HSD=@HSD,SOLUONG_SP=@SOLUONG_SP,MALOAI=@MALOAI,GIA=@GIA,GHICHU_SP=@GHICHU_SP,MAKHO=@MAKHO,ANH=@ANH
WHERE MA_SP=@MA_SP
END
--DELETE
CREATE PROC DELETE_SAN_PHAM @MA_SP CHAR(10)
AS
BEGIN 
DELETE SAN_PHAM
WHERE MA_SP=@MA_SP
END
--
--
-----------------------------TÀI KHOẢN-----------------------------
SELECT*FROM TAI_KHOAN
--INSERT
CREATE PROC INSERT_TAI_KHOAN @TK VARCHAR(20),@MK VARCHAR(40),@EMAIL NVARCHAR(50),@QUYEN CHAR(10)
AS
BEGIN 
INSERT INTO TAI_KHOAN VALUES(@TK,@MK,@EMAIL,@QUYEN)
END
--UPDATE
CREATE PROC UPDATE_TAI_KHOAN @TK VARCHAR(20),@MK VARCHAR(40),@EMAIL NVARCHAR(50),@QUYEN CHAR(10)
AS
BEGIN 
UPDATE TAI_KHOAN
SET MK=@MK,EMAIL=@EMAIL,QUYEN=@QUYEN
WHERE TK=@TK
END
--DELETE 
CREATE PROC DELETE_TAI_KHOAN @TK VARCHAR(20),@MK VARCHAR(40),@EMAIL NVARCHAR(50),@QUYEN CHAR(10)
AS
BEGIN 
DELETE TAI_KHOAN
WHERE TK=@TK
END

----PHÂN QUYỀN
SP_ADDLOGIN 'MinhTuan','123'
SP_ADDUSER 'MinhTuan','123'
SP_ADDLOGIN 'HuynhNhu','234'
SP_ADDUSER 'HuynhNhu','234'
SP_DROPUSer '234'
SP_GRANTDBACCESS 'MinhTuan','MinhTuan'
SP_GRANTDBACCESS 'HuynhNhu','HuynhNhu'
GRANT INSERT, SELECT, UPDATE
ON CHITIET_NH
TO HuynhNhu

GRANT INSERT, SELECT, UPDATE
ON CHITIET_NH
TO MinhTuan

GRANT ALL
ON CHITIET_XH
TO MinhTuan

GRANT ALL
ON KHACH_HANG
TO MinhTuan

GRANT ALL
ON KHO_HANG
TO MinhTuan

GRANT ALL
ON LOAISP
TO MinhTuan

GRANT ALL
ON NHA_CUNG_CAP
TO MinhTuan

GRANT ALL
ON NHAN_VIEN
TO MinhTuan

GRANT ALL
ON PHIEU_NHAP_HANG
TO MinhTuan

GRANT ALL
ON PHIEU_XUAT_HANG
TO MinhTuan

GRANT ALL
ON SAN_PHAM
TO MinhTuan

GRANT ALL
ON TAI_KHOAN
TO MinhTuan

-------------------------CURSOR-------------------------
---In ra danh sach SAN PHAM trong KHO  bao gom: Ma SP va ten SP va so luong
DECLARE  INSANPHAMCURSOR  CURSOR FOR SELECT MA_SP,TEN_SP,SOLUONG_SP   FROM dbo.SAN_PHAM

DECLARE @MASP NVARCHAR(20)
DECLARE @TENSP NVARCHAR(50)
DECLARE @SOLUONG_SP NVARCHAR(20)
PRINT 'Danh sách SAN PHAM : '
OPEN INSANPHAMCURSOR

FETCH NEXT FROM INSANPHAMCURSOR  INTO @MASP, @TENSP,@SOLUONG_SP
WHILE @@FETCH_STATUS =0
BEGIN
	print @MASP + ' : ' + @TENSP+' : '+ @SOLUONG_SP
	PRINT '---------------------'
	FETCH NEXT FROM INSANPHAMCURSOR  INTO @MASP, @TENSP, @SOLUONG_SP
END

CLOSE INSANPHAMCURSOR
DEALLOCATE INSANPHAMCURSOR
---------------------------------------------------------------------
--Từ bộ phận làm việc của nhân viên
---Nếu bộ phận kiểm hàng thì lương là 7000000
---Nếu bộ phận nhập hàng thì lương là 7500000
---Bô phận xuất hàng lương là 7800000 

DECLARE NHANVIENCURSOR CURSOR FOR SELECT MANV, BOPHAN_NV FROM dbo.NHAN_VIEN

OPEN NHANVIENCURSOR

DECLARE @MANV CHAR(20)
DECLARE @NBOPHAN_NV NVARCHAR(50)

FETCH NEXT FROM NHANVIENCURSOR INTO @MANV,@NBOPHAN_NV
WHILE @@FETCH_STATUS =0
BEGIN
	IF @NBOPHAN_NV =N'KIỂM HÀNG'
		BEGIN 
			UPDATE dbo.NHAN_VIEN SET LUONG_NV = 7000000 WHERE MANV = @MANV
		END
		ELSE
		IF  @NBOPHAN_NV =N'NHẬP HÀNG'
		BEGIN
			UPDATE dbo.NHAN_VIEN SET LUONG_NV=7500000 WHERE MANV = @MANV
		END
		ELSE
		BEGIN
			UPDATE dbo.NHAN_VIEN SET LUONG_NV=7800000 WHERE MANV = @MANV
		END

		FETCH NEXT FROM NHANVIENCURSOR INTO @MANV, @NBOPHAN_NV
END

CLOSE NHANVIENCURSOR
DEALLOCATE NHANVIENCURSOR
SELECT * FROM NHAN_VIEN
---------------------------------------------------------
--In ra danh sách SAN PHAM trong KHO  bao gồm: MaSP, tenSP và số lượng---
DECLARE  INSANPHAMCURSOR  CURSOR FOR SELECT MA_SP,TEN_SP,SOLUONG_SP   FROM dbo.SAN_PHAM

DECLARE @MASP NVARCHAR(20)
DECLARE @TENSP NVARCHAR(50)
DECLARE @SOLUONG_SP NVARCHAR(20)
PRINT 'Danh sách SAN PHAM : '
OPEN INSANPHAMCURSOR

FETCH NEXT FROM INSANPHAMCURSOR  INTO @MASP, @TENSP,@SOLUONG_SP
WHILE @@FETCH_STATUS =0
BEGIN
	print @MASP + ' : ' + @TENSP+' : '+ @SOLUONG_SP
	PRINT '---------------------'
	FETCH NEXT FROM INSANPHAMCURSOR  INTO @MASP, @TENSP, @SOLUONG_SP
END

CLOSE INSANPHAMCURSOR
DEALLOCATE INSANPHAMCURSOR
-------------------------FUNCTION-----------------------
--Function cho biết số lượng  SAN PHAM của một kho với mã kho là tham số 

create function Func_DemSLSP (@MAKHO CHAR(20))
RETURNS INT AS
BEGIN
	DECLARE @DEM INT;
	SELECT @DEM =COUNT(SAN_PHAM.MAKHO)
	FROM SAN_PHAM 
	WHERE SAN_PHAM.MAKHO=@MAKHO
	RETURN @DEM;
END
--KETQUA SAU KHI GOI
GO
SELECT dbo.Func_DemSLSP('K09')
----------------------------------------------
--Với 1 mã sản phẩm và 1 mã NCC, kiểm tra xem sản phẩm có thuộc NCC này không (trả về đúng hoặc sai)
CREATE FUNCTION KT_SPham(@MA_SP CHAR(10),@MA_NCC CHAR(10))
RETURNS VARCHAR(5)
AS
BEGIN
DECLARE @KQ VARCHAR(5)
SET @KQ = 'FALSE'
IF(EXISTS(SELECT * FROM dbo.SAN_PHAM LEFT JOIN dbo.NHA_CUNG_CAP ON NHA_CUNG_CAP.MA_NCC = SAN_PHAM.MA_NCC  WHERE dbo.SAN_PHAM.MA_SP = @MA_SP AND dbo.NHA_CUNG_CAP.MA_NCC =@MA_NCC))
SET @KQ = 'TRUE'
RETURN @KQ
END
  --DROP FUNCTION KT_SPham
GO
SELECT dbo.KT_SPham('SP001','NCC02')
------------------------------------------------------------------------------------
