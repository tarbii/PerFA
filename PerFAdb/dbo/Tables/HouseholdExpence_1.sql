CREATE TABLE [dbo].[HouseholdExpence] (
    [ID]      INT           NOT NULL,
    [HE type] VARCHAR (MAX) NULL,
    [Comment] VARCHAR (MAX) NULL,
    CONSTRAINT [PK_Household expence] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Household expence_Transaction] FOREIGN KEY ([ID]) REFERENCES [dbo].[Transaction] ([ID])
);

