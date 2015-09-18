CREATE TABLE [dbo].[Deposit](
	[ID] [int] NOT NULL,
	[Deposit rate(%)] [float] NULL,
	[Money on deposit] [money] NULL,
	[Expected income] [money] NULL,
 CONSTRAINT [PK_Deposit] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Deposit]  WITH CHECK ADD  CONSTRAINT [FK_Deposit_Transaction] FOREIGN KEY([ID])
REFERENCES [dbo].[Transaction] ([ID])
GO

ALTER TABLE [dbo].[Deposit] CHECK CONSTRAINT [FK_Deposit_Transaction]