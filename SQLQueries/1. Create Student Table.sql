USE StudentDB;
CREATE TABLE [dbo].[Student] (
    [StudentID]    INT NOT NULL CONSTRAINT ChkID CHECK ([StudentID] > 9999999),
    [FirstName]    VARCHAR (50) NOT NULL,
    [LastName]     VARCHAR (50) NOT NULL,
    [Country]      VARCHAR (50) NOT NULL,
    [County]       VARCHAR (50) NOT NULL,
    [City]         VARCHAR (50) NOT NULL,
    [AddressLine1] VARCHAR (50) NOT NULL,
    [AddressLine2] VARCHAR (50) NULL,
    [Level]        VARCHAR (50) NOT NULL,
    [PhoneNumber]  CHAR (15) NOT NULL,
    [Email]        VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([StudentID] ASC )
);