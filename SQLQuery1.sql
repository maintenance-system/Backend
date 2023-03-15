CREATE TABLE [dbo].[Handyman]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[FirstName] nvarchar(20) not null,
	[LastName] nvarchar(20) not null,
	[City] int FOREIGN KEY REFERENCES Cities(Id) not null,
	[PhoneNumber] varchar(10) not null,
	[EmailAddress] varchar(225) not null
)

CREATE TABLE [dbo].[Handyman]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[FirstName] nvarchar(20) not null,
	[LastName] nvarchar(20) not null,
	[City] int FOREIGN KEY REFERENCES Cities(Id) not null,
	[PhoneNumber] varchar(10) not null,
	[EmailAddress] varchar(225) not null
)

ALTER TABLE Handyman
ADD Password_login nvarchar(100);