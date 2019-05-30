Use StudentDB;
CREATE TABLE [dbo].[Users] (
    [Id]       INT          NOT NULL,
    [Username] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

