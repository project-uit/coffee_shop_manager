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
hesogiamgia int,
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

///////////////////////////////////////////////////////////////

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
// lay dinh luong ly thuyet
select  knl.tennguyenlieu,   knl.idkhonguyenlieu, knl.tendonvi_dinh_luong, knl.xoa_flag, cthd.dongia, cthd.soluong, th.id_thucuong,ctct.dinhluong
from hoadon hd, chitiethoadon cthd, thucuong th, chitietcongthuc ctct, khonguyenlieu knl
where hd.id_hoadon = cthd.id_hoadon 
and cthd.id_thucuong = th.id_thucuong
and ctct.id_thucuong = th.id_thucuong
and knl.idkhonguyenlieu = ctct.idkhonguyenlieu
and MONTH(hd.ngaylap) = 12 and YEAR(hd.ngaylap)= 2018
and knl.xoa_flag = 0
group by knl.tennguyenlieu,  knl.idkhonguyenlieu, knl.tendonvi_dinh_luong,knl.xoa_flag,cthd.dongia, cthd.soluong

select  knl.tennguyenlieu, sum(ctct.dinhluong*cthd.soluong) as dinhluong, knl.idkhonguyenlieu,knl.tendonvi_dinh_luong, knl.xoa_flag 
from hoadon hd, chitiethoadon cthd, thucuong th, chitietcongthuc ctct, khonguyenlieu knl 
where hd.id_hoadon = cthd.id_hoadon 
and cthd.id_thucuong = th.id_thucuong 
and ctct.id_thucuong = th.id_thucuong 
and knl.idkhonguyenlieu = ctct.idkhonguyenlieu 
and MONTH(hd.ngaylap) = 12 and YEAR(hd.ngaylap) = 2018 
group by knl.tennguyenlieu, knl.idkhonguyenlieu, knl.xoa_flag, knl.tendonvi_dinh_luong

// lay dinh luong thuc te
select knl.tennguyenlieu, sum(ctnldd.dinhluong) as dinhluong,   knl.idkhonguyenlieu, knl.tendonvi_dinh_luong, knl.xoa_flag
from nguyenlieudadung nldd, chitietnguyenlieudadung ctnldd, khonguyenlieu knl
where nldd.idnguyenlieudadung = ctnldd.idnguyenlieudadung
and knl.idkhonguyenlieu = ctnldd.idkhonguyenlieu
and MONTH(nldd.ngaynhap) = 12 and YEAR(nldd.ngaynhap)= 2018
group by knl.tennguyenlieu,  knl.idkhonguyenlieu, knl.tendonvi_dinh_luong,knl.xoa_flag
