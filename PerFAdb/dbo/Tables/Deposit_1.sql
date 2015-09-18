CREATE TABLE [dbo].[Deposit] (
    [ID]               INT        NOT NULL,
    [Deposit rate(%)]  FLOAT (53) NULL,
    [Money on deposit] MONEY      NULL,
    [Expected income]  MONEY      NULL,
    CONSTRAINT [PK_Deposit] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Deposit_Transaction] FOREIGN KEY ([ID]) REFERENCES [dbo].[Transaction] ([ID])
);

