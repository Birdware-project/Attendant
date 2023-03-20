CREATE TABLE Users (
    ID int identity(1,1) primary key,
    Name varchar(255),
    Password varchar(255)
);
create table attendant(
	ID int identity(1,1) primary key,
	UserID int ,
	timeIn datetime,
	timeOut datetime
);
