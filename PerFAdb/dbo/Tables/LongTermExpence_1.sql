CREATE TABLE [dbo].[LongTermExpence] (
    [ID]            INT           NOT NULL,
    [LtE type]      VARCHAR (MAX) NULL,
    [Comment]       VARCHAR (MAX) NULL,
    [Term of usage] VARCHAR (MAX) NULL,
    CONSTRAINT [PK_Long-term expence] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Long-term expence_Transaction] FOREIGN KEY ([ID]) REFERENCES [dbo].[Transaction] ([ID])
);

