CREATE TABLE [dbo].[Wage] (
    [ID]        INT           NOT NULL,
    [Workplace] VARCHAR (MAX) NULL,
    [Wage-rate] MONEY         NULL,
    CONSTRAINT [PK_Wage] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Wage_Transaction] FOREIGN KEY ([ID]) REFERENCES [dbo].[Transaction] ([ID])
);

