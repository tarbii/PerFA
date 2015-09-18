CREATE TABLE [dbo].[OtherIncome] (
    [ID]      INT           NOT NULL,
    [OI type] VARCHAR (MAX) NULL,
    [Comment] VARCHAR (MAX) NULL,
    CONSTRAINT [PK_Other income] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Other income_Transaction] FOREIGN KEY ([ID]) REFERENCES [dbo].[Transaction] ([ID])
);

