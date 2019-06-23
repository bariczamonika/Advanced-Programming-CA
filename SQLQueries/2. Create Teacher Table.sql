USE StudentDB;
CREATE TABLE [dbo].[Teacher]
(
	[TeacherID] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [PhoneNumber] CHAR(15) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL);