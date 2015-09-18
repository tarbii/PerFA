CREATE TABLE [dbo].[OtherExpence](
	[ID] [int] NOT NULL,
	[OE type] [varchar](max) NULL,
	[Comment] [varchar](max) NULL,
 CONSTRAINT [PK_Other expence] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[OtherExpence]  WITH CHECK ADD  CONSTRAINT [FK_Other expence_Transaction] FOREIGN KEY([ID])
REFERENCES [dbo].[Transaction] ([ID])
GO

ALTER TABLE [dbo].[OtherExpence] CHECK CONSTRAINT [FK_Other expence_Transaction]