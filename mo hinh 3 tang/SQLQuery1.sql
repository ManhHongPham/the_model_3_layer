use master
go

create database quanlyhocsinh
go

use quanlyhocsinh
go

create table lop(
  malop char(10) primary key,
  tenlop nvarchar(50),
  soSV int,
)
go

insert into lop values('12a','toan',12),
('13a','van',1254),
('14a','hoa',43),
('15a','sinh',23),
('16a','su',1243),
('17a','dia',23),
('22a','toan',12)

select *from lop