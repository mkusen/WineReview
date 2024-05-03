use master;
go
drop database if exists wine_review;
go
create database wine_review;
go
use wine_review;
go

create table reviewer(
id int,
email varchar (50),
pass varchar (20),
firstname varchar(20),
lastname varchar(20)
);

create table wine(
id int,
maker varchar(20),
wine_name varchar (20),
year_of_harvest int,
price decimal(10,2),
review varchar (255)
);

create table tasting(
id_reviewer int,
id_wine int,
id_place int
);

create table admin(
id int,
email varchar (50),
pass varchar(20),
firstname varchar(20),
lastname varchar(20)
);

create table place(
id int,
state varchar(50),
city varchar(50),
place varchar(50)
);
