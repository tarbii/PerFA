CREATE TABLE [dbo].[HouseholdExpence](
	[ID] [int] NOT NULL,
	[HE type] [varchar](max) NULL,
	[Comment] [varchar](max) NULL,
 CONSTRAINT [PK_Household expence] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[HouseholdExpence]  WITH CHECK ADD  CONSTRAINT [FK_Household expence_Transaction] FOREIGN KEY([ID])
REFERENCES [dbo].[Transaction] ([ID])
GO

ALTER TABLE [dbo].[HouseholdExpence] CHECK CONSTRAINT [FK_Household expence_Transaction]