use Malaria
go

create table UserLevel
(
UserLevelID int identity(1,1),
Description varchar(500),
Access_Rights varchar(500),
primary key (UserLevelID)
)

create table UserDetails
(
UserID int identity(1,1),
Name varchar(500),
Surname varchar(500),
Email varchar(500),
DateOfBirth date,
primary key (UserID),
UserLevelID int,
constraint FK_UserLevel foreign key (UserLevelID) REFERENCES UserLevel(UserLevelID)
)

create table UserNames
(
ID int identity(1,1),
UserName varchar(50),
Password varchar(1000),
Token varchar (1000),
fk_UserId int,
primary key (ID),
constraint FK_UserDetails foreign key (fk_UserId) REFERENCES UserDetails(UserID)
)


--how to treat an infection
create table Malaria_Treatments
(
ID int identity(1,1) primary key,
Treatment_Details varchar(5000),
Date_Created date
)

--how to control the infection rate
create table Malaria_Controls
(
ID int identity(1,1) primary key,
Control_Details varchar(5000),
Date_Created date
)

--general facts about Malaria
create table Malaria_Facts
(
ID int identity(1,1) primary key,
Facts_Details varchar(5000),
Date_Created date
)

--locations where you can get infected
create table Malaria_Areas
(
ID int identity(1,1) primary key,
Area_Details varchar(5000),
Date_Created date
)

--general prevention techniques
create table Malaria_Prevention
(
ID int identity(1,1) primary key,
Prevention_Details varchar(5000),
Date_Created date
)

--audit log to see who created what and when
create table Malaria_Log
(
Log_ID int identity(1,1) primary key,
fk_MT_ID int null,
fk_MC_ID int null,
fk_MF_ID int null,
fk_MA_ID int null,
fk_MP_ID int null,
constraint fk_MT_ID foreign key (fk_MT_ID) REFERENCES Malaria_Treatments(ID),
constraint fk_MC_ID foreign key (fk_MC_ID) REFERENCES Malaria_Controls(ID),
constraint fk_MF_ID foreign key (fk_MF_ID) REFERENCES Malaria_Facts(ID),
constraint fk_MA_ID foreign key (fk_MA_ID) REFERENCES Malaria_Areas(ID),
constraint fk_MP_ID foreign key (fk_MP_ID) REFERENCES Malaria_Prevention(ID),
User_Name_ID int,
constraint User_Name_ID foreign key (User_Name_ID) REFERENCES UserNames(ID)
)


create table UserLogInInfo
(
ID int primary key identity(1,1),
userID int,
LoginDate date
constraint FK_UserLog foreign key (UserID) REFERENCES UserDetails(UserID)
)