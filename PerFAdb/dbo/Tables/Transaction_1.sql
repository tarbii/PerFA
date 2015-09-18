CREATE TABLE [dbo].[Transaction] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [Date]        DATE          NULL,
    [Description] VARCHAR (MAX) NULL,
    [Author_ID]   INT           NOT NULL,
    CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Transaction_User] FOREIGN KEY ([Author_ID]) REFERENCES [dbo].[User] ([ID])
);

