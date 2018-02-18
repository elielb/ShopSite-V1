CREATE TABLE Users
(
UserId bigint not null identity(1,1),
FirstName nvarchar(20)not null,
LastName nvarchar(20)not null,
Email nvarchar(50)not null,
Pass nvarchar(50)not null,
BirthDate smalldatetime 

PRIMARY KEY (UserId),
);
go

CREATE TABLE Items
(
ItemId bigint identity(1,1),
OwnerId bigint,
UserId bigint,
Title nvarchar(50),
ShortDescription nvarchar(500),
LongDescription nvarchar(4000),
Price decimal(18,0),
Date smalldatetime,
PicLink1 image,
PicLink2 image,
PicLink3 image,
StatusSail bit 
 PRIMARY KEY (ItemId),
   FOREIGN KEY (OwnerId) REFERENCES Users(UserId),
      FOREIGN KEY (UserId) REFERENCES Users(UserId)
);
go
    