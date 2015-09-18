CREATE TABLE [dbo].[TransactionUser](
	[ID_transaction] [int] NOT NULL,
	[ID_user] [int] NOT NULL,
	[Sum] [money] NULL,
 CONSTRAINT [PK_Transaction-User] PRIMARY KEY CLUSTERED 
(
	[ID_transaction] ASC,
	[ID_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TransactionUser]  WITH CHECK ADD  CONSTRAINT [FK_Transaction-User_Transaction] FOREIGN KEY([ID_transaction])
REFERENCES [dbo].[Transaction] ([ID])
GO

ALTER TABLE [dbo].[TransactionUser] CHECK CONSTRAINT [FK_Transaction-User_Transaction]
GO
ALTER TABLE [dbo].[TransactionUser]  WITH CHECK ADD  CONSTRAINT [FK_Transaction-User_User] FOREIGN KEY([ID_user])
REFERENCES [dbo].[User] ([ID])
GO

ALTER TABLE [dbo].[TransactionUser] CHECK CONSTRAINT [FK_Transaction-User_User]