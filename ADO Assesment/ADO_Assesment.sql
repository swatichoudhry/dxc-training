create database ADO_Assesment
drop database ADO_Assesment
use ADO_Assesment

create table Products(
ID int primary key identity,
Name varchar(30),
)

create table Suppliers(
ID int primary key identity,
Name varchar(30),
Location varchar(30),
Price int,
Product_ID int references Products(ID))


create table Customers(
ID int primary key identity,
Name varchar(20),
Product_ID int references Products,
Quantity int,
Supplier_ID int references Suppliers(ID)
)

