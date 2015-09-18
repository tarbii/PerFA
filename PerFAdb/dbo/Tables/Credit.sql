CREATE TABLE [dbo].[Credit](
	[ID] [int] NOT NULL,
	[Credit rate(%)] [float] NULL,
	[Credti body] [money] NULL,
	[Monthly payment] [money] NULL,
 CONSTRAINT [PK_Credit] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Credit]  WITH CHECK ADD  CONSTRAINT [FK_Credit_Transaction] FOREIGN KEY([ID])
REFERENCES [dbo].[Transaction] ([ID])
GO

ALTER TABLE [dbo].[Credit] CHECK CONSTRAINT [FK_Credit_Transaction]