CREATE TABLE [dbo].[LongTermExpence](
	[ID] [int] NOT NULL,
	[LtE type] [varchar](max) NULL,
	[Comment] [varchar](max) NULL,
	[Term of usage] [varchar](max) NULL,
 CONSTRAINT [PK_Long-term expence] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[LongTermExpence]  WITH CHECK ADD  CONSTRAINT [FK_Long-term expence_Transaction] FOREIGN KEY([ID])
REFERENCES [dbo].[Transaction] ([ID])
GO

ALTER TABLE [dbo].[LongTermExpence] CHECK CONSTRAINT [FK_Long-term expence_Transaction]