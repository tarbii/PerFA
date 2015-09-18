CREATE TABLE [dbo].[Credit] (
    [ID]              INT        NOT NULL,
    [Credit rate(%)]  FLOAT (53) NULL,
    [Credti body]     MONEY      NULL,
    [Monthly payment] MONEY      NULL,
    CONSTRAINT [PK_Credit] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Credit_Transaction] FOREIGN KEY ([ID]) REFERENCES [dbo].[Transaction] ([ID])
);

