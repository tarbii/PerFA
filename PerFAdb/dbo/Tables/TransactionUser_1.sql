CREATE TABLE [dbo].[TransactionUser] (
    [ID_transaction] INT   NOT NULL,
    [ID_user]        INT   NOT NULL,
    [Sum]            MONEY NULL,
    CONSTRAINT [PK_Transaction-User] PRIMARY KEY CLUSTERED ([ID_transaction] ASC, [ID_user] ASC),
    CONSTRAINT [FK_Transaction-User_Transaction] FOREIGN KEY ([ID_transaction]) REFERENCES [dbo].[Transaction] ([ID]),
    CONSTRAINT [FK_Transaction-User_User] FOREIGN KEY ([ID_user]) REFERENCES [dbo].[User] ([ID])
);

