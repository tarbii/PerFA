CREATE TABLE [dbo].[OtherExpence] (
    [ID]      INT           NOT NULL,
    [OE type] VARCHAR (MAX) NULL,
    [Comment] VARCHAR (MAX) NULL,
    CONSTRAINT [PK_Other expence] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Other expence_Transaction] FOREIGN KEY ([ID]) REFERENCES [dbo].[Transaction] ([ID])
);

