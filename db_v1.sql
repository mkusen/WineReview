use master;
go
drop database if exists wine_review;
go
create database wine_review;
go
use wine_review;
go

--osoba koja piše recenziju
create table reviewers(
id int not null primary key identity(1,1),
email varchar (50) not null,
pass char (32) not null,
firstname varchar(20) not null,
lastname varchar(20)
);

--vino koje se opisuje
create table wines(
id int not null primary key identity(1,1),
maker varchar(20) not null,
wine_name varchar (20) not null,
year_of_harvest int not null,
price decimal(10,2),
review varchar (255) not null
);

--događaj na kojem je recenzent kušao vino
create table event_places(
id int not null primary key identity(1,1),
country varchar(50) not null,
city varchar(50) not null,
place_name varchar(50),
event_name varchar(50)
);

--spaja recenzenta, vino i event (mjesto) kušanja
create table tasting (
id_reviewer int not null,
id_wine int not null,
id_event_place int not null,
foreign key (id_reviewer) references reviewers (id),
foreign key (id_wine) references wines (id),
foreign key (id_event_place) references event_places (id)
);

--podaci o adminu web stranice
insert into reviewers (email, pass, firstname, lastname) values ('kusen.mario@gmail.com', HashBytes ('MD5', 'admin'), 'Mario', 'Kušen');

