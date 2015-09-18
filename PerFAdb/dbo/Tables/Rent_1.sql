CREATE TABLE [dbo].[Rent] (
    [ID]               INT   NOT NULL,
    [Rate]             MONEY NULL,
    [Meters]           MONEY NULL,
    [Public utilities] MONEY NULL,
    CONSTRAINT [PK_Rent] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Rent_Transaction] FOREIGN KEY ([ID]) REFERENCES [dbo].[Transaction] ([ID])
);

