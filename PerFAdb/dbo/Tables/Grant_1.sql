CREATE TABLE [dbo].[Grant] (
    [ID]         INT           NOT NULL,
    [Grant type] VARCHAR (MAX) NULL,
    [Grant-rate] MONEY         NULL,
    CONSTRAINT [PK_Grant] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Grant_Transaction] FOREIGN KEY ([ID]) REFERENCES [dbo].[Transaction] ([ID])
);

