CREATE TABLE [dbo].[User] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (MAX) NULL,
    [Login]    VARCHAR (MAX) NULL,
    [Password] VARCHAR (MAX) NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([ID] ASC)
);

