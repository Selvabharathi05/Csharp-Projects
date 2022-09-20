create database Shopping

use Shopping

create table Customer
(
custid int,
custname varchar(20),
city varchar(20),
custstate varchar(20)
)

create table Products
(
Prodid int,
prodname varchar(20),
unitprice float,
unitofmeasurement int,
qtyinstock int
)

create table sales_header
(
invno int,
invdate date,
invamt float,
disPercent float
)

create table sales_details
(
invno int,
custid int,
prodid int,
qtysold int
)


alter table sales_header
alter column invno int not null

alter table sales_header
add primary key(invno)


alter table sales_details
add foreign key(invno) references sales_header(invno)


alter table customer
alter column custid int not null

alter table customer
add primary key(custid)

alter table products
alter column prodid int not null

alter table products
add primary key(prodid)

alter table sales_details
add foreign key(custid) references Customer(custid)

alter table sales_details
add foreign key(prodid) references Products(prodid)

alter table sales_details
drop column qtysold

alter table sales_details
add  qty int

