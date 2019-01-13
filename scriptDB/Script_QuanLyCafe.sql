drop database quanlycafe;
create database quanlycafe;
use quanlycafe;

create table nhomthucuong(
id_nhomthucuong int NOT NULL IDENTITY(1,1) primary key,
tennhomthucuong nvarchar(50) not null,
xoa_flag bit
);

create table thucuong(
id_thucuong int NOT NULL IDENTITY(1,1) primary key,
tenthucuong nvarchar(50) unique,
giaban money,
id_nhomthucuong int,
xoa_flag bit,
FOREIGN KEY (id_nhomthucuong) REFERENCES nhomthucuong(id_nhomthucuong)
);

create table giamgia(
id_giamgia int NOT NULL IDENTITY(1,1) primary key,
hesogiamgia float,
ngaybatdau date,
ngayketthuc date
);

///////////////////////////////////////////////////////////////

create table khonguyenlieu(
	idkhonguyenlieu int IDENTITY(1,1) PRIMARY KEY,
	tennguyenlieu nvarchar(50),
	tendonvi_dinh_luong char(8),
	dinhluong float, 
        xoa_flag bit
);

create table nguyenlieudadung(
	idnguyenlieudadung int IDENTITY(1,1) PRIMARY KEY,
	ngaynhap DateTime
);

create table chitietnguyenlieudadung(
	idchitietnguyenlieudadung int IDENTITY(1,1) PRIMARY KEY,
	idnguyenlieudadung int,
	idkhonguyenlieu int,
	dinhluong float,
	FOREIGN KEY (idkhonguyenlieu) REFERENCES khonguyenlieu(idkhonguyenlieu),
	FOREIGN KEY (idnguyenlieudadung) REFERENCES nguyenlieudadung(idnguyenlieudadung)
);

create table nhapkho(
	idnhapkho int IDENTITY(1,1) PRIMARY KEY,
        ngaynhap DateTime not null,
	id_nhanvien int not null,
	FOREIGN KEY (id_nhanvien)
        REFERENCES nhanvien(id_nhanvien),
)
create table chitietnhapkho(
	idchitietnhapkho int IDENTITY(1,1) PRIMARY KEY,
	tendonvi_so_luong char(8) not null,
	soluong int not null, 
	dinhluong float not null,
	dongia money not null,
	idnhapkho int not null,
	idkhonguyenlieu int not null,
	FOREIGN KEY (idkhonguyenlieu)
	REFERENCES khonguyenlieu(idkhonguyenlieu),
	FOREIGN KEY (idnhapkho)
	REFERENCES nhapkho(idnhapkho)
);

create table chitietcongthuc(
	id_chitietcongthuc int IDENTITY(1,1) PRIMARY KEY,
	id_thucuong int not null,
	dinhluong float not null,
	idkhonguyenlieu int not null,
	FOREIGN KEY (id_thucuong) REFERENCES thucuong(id_thucuong),
	FOREIGN KEY (idkhonguyenlieu) REFERENCES khonguyenlieu(idkhonguyenlieu)
);

CREATE TABLE nhanvien(
	id_nhanvien int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	hoten nvarchar(50) NOT NULL,
	ngaysinh date NULL,
	cmnd nvarchar(20) NOT NULL,
	diachi nvarchar(50) NULL,
	luong money NOT NULL,
	tentaikhoan varchar(30) NOT NULL,
	matkhau varchar(24) NOT NULL,
	quyen int NULL DEFAULT (0),
	xoa_flag bit,
);

create table hoadon(
	id_hoadon int IDENTITY(1,1) PRIMARY KEY,
	tongtien money not null,
	ngaylap datetime
)

create table chitiethoadon(
	id_chitiethoadon int IDENTITY(1,1) PRIMARY KEY,
	id_hoadon int,
	id_thucuong int,
	soluong int not null,
	dongia money,
	thanhtien money,
	FOREIGN KEY (id_thucuong)
    REFERENCES thucuong(id_thucuong),
	FOREIGN KEY (id_hoadon)
    REFERENCES hoadon(id_hoadon),
)

create table thamso(
id int primary key,
dinhluongtoida float,
dinhluongtoithieu float
);

create table cuahang(
idcuahang int IDENTITY(1,1) PRIMARY KEY,
ten nvarchar(100),
diachi nvarchar(300),
dienthoai varchar(20)
)

insert into cuahang(ten, diachi, dienthoai) values (N'2Land Coffee',N'123 Nguyễn Huệ, Quận 1, tp HCM',N'18001090')


